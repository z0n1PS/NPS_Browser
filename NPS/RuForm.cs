using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPS
{
    public partial class NPSBrowser : Form
    {
        public const string version = "0.60";
        List<Item> currentDatabase = new List<Item>();
        List<Item> gamesDbs = new List<Item>();
        List<Item> dlcsDbs = new List<Item>();
        List<Item> psmDbs = new List<Item>();
        HashSet<string> regions = new HashSet<string>();
        int currentOrderColumn = 0;
        bool currentOrderInverted = false;

        List<DownloadWorker> downloads = new List<DownloadWorker>();

        public NPSBrowser()
        {

            InitializeComponent();
            this.Text += " " + version;
            new Settings();

            if (string.IsNullOrEmpty(Settings.instance.GamesUri) && string.IsNullOrEmpty(Settings.instance.DLCUri))
            {
                MessageBox.Show("Application did not provide any links to external files or decrypt mechanism.\r\nYou need to specify tsv (tab splitted text) file with your personal links to pkg files on your own.\r\n\r\nFormat: TitleId Region Name Pkg Key", "Disclaimer!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Options o = new Options();
                o.ShowDialog();
            }
            else if (!File.Exists(Settings.instance.pkgPath))
            {
                MessageBox.Show("You are missing your pkg_dec.exe", "Whops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Options o = new Options();
                o.ShowDialog();
            }


            NewVersionCheck();

        }



        /// <summary>
        /// Exit Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Aboutbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void NoPayStationBrowser_Load(object sender, EventArgs e)
        {

            LoadDatabase(Settings.instance.DLCUri, (db) =>
            {
                dlcsDbs = db;
                Invoke(new Action(() =>
                {
                    if (dlcsDbs.Count > 0)
                        radioButton2.Enabled = true;
                    else radioButton2.Enabled = false;
                }));

                LoadDatabase(Settings.instance.GamesUri, (db2) =>
                {
                    gamesDbs = db2;

                    Invoke(new Action(() =>
                    {

                        if (gamesDbs.Count > 0)
                            radioButton1.Enabled = true;
                        else radioButton1.Enabled = false;

                        radioButton1.Checked = true;
                        currentDatabase = gamesDbs;

                        comboBox1.Items.Clear();

                        comboBox1.Items.Add("ALL");
                        comboBox1.Text = "ALL";

                        if (Settings.instance.records != 0)
                        {
                            var _new = gamesDbs.Count - Settings.instance.records;
                            if (_new > 0)
                                label1.Text += " (" + _new.ToString() + " new since last launch)";
                        }

                        Settings.instance.records = gamesDbs.Count;

                        foreach (string s in regions)
                            comboBox1.Items.Add(s);
                    }));

                }, true);
            });





            LoadDatabase(Settings.instance.PSMUri, (db) =>
            {
                psmDbs = db;
                Invoke(new Action(() =>
                {
                    if (psmDbs.Count > 0)
                        radioButton3.Enabled = true;
                    else radioButton3.Enabled = false;
                }));
            });

        }


        void LoadDatabase(string path, Action<List<Item>> result, bool addDlc = false)
        {
            List<Item> dbs = new List<Item>();
            if (string.IsNullOrEmpty(path)) result.Invoke(dbs);
            else
            {
                Task.Run(() =>
                {
                    path = new Uri(path).ToString();

                    try
                    {
                        WebClient wc = new WebClient();
                        string content = wc.DownloadString(new Uri(path));
                        wc.Dispose();
                        content = Encoding.UTF8.GetString(Encoding.Default.GetBytes(content));

                        string[] lines = content.Split(new string[] { "\r\n", "\n\r", "\n", "\r" }, StringSplitOptions.None);

                        for (int i = 1; i < lines.Length; i++)
                        {
                            var a = lines[i].Split('\t');
                            var itm = new Item(a[0], a[1], a[2], a[3], a[4]);
                            if (a.Length >= 7)
                            {
                                DateTime.TryParse(a[6], out itm.lastModifyDate);
                            }
                            if (!itm.zRfi.ToLower().Contains("missing") && itm.pkg.ToLower().Contains("http://"))
                            {
                                if (addDlc)
                                    itm.CalculateDlCs(dlcsDbs.ToArray());
                                dbs.Add(itm);
                                regions.Add(itm.Region.Replace(" ", ""));
                            }
                        }

                        dbs = dbs.OrderBy(i => i.TitleName).ToList();
                    }
                    catch
                    {

                    }
                    result.Invoke(dbs);
                });
            }
        }


        void RefreshList(List<Item> items)
        {
            label1.Text = items.Count + " items";

            List<ListViewItem> list = new List<ListViewItem>();

            foreach (var item in items)
            {
                var a = new ListViewItem(item.TitleId);
                a.SubItems.Add(item.Region);
                a.SubItems.Add(item.TitleName);
                if (item.DLCs > 0)
                    a.SubItems.Add(item.DLCs.ToString());
                else a.SubItems.Add("");
                if (item.lastModifyDate != DateTime.MinValue)
                    a.SubItems.Add(item.lastModifyDate.ToString());
                else a.SubItems.Add("");
                a.Tag = item;
                list.Add(a);
            }

            listView1.BeginUpdate();
            listView1.Items.Clear();
            listView1.Items.AddRange(list.ToArray());
            listView1.EndUpdate();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Item> itms = new List<Item>();

            foreach (var item in currentDatabase)
            {
                if (item.CompareName(textBox1.Text) && (comboBox1.Text == "ALL" || item.Region.Contains(comboBox1.Text)))
                    itms.Add(item);
            }

            RefreshList(itms);
        }




        private void showTitleDlcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            Item t = (listView1.SelectedItems[0].Tag as Item);
            if (t.DLCs > 0)
            {
                radioButton2.Checked = true;
                textBox1.Text = t.TitleId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(Settings.instance.downloadDir) || string.IsNullOrEmpty(Settings.instance.pkgPath))
            {
                MessageBox.Show("You don't have proper config", "Whops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Options o = new Options();
                o.ShowDialog();
                return;
            }

            if (!File.Exists(Settings.instance.pkgPath))
            {
                MessageBox.Show("You missing your pkg dec", "Whops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Options o = new Options();
                o.ShowDialog();
                return;
            }

            if (listView1.SelectedItems.Count == 0) return;

            foreach (ListViewItem itm in listView1.SelectedItems)
            {

                var a = (itm.Tag as Item);

                bool contains = false;
                foreach (var d in downloads)
                    if (d.currentDownload == a)
                    {
                        contains = true;
                        break; //already downloading
                    }

                if (!contains)
                {
                    DownloadWorker dw = new DownloadWorker(a, this);
                    listViewEx1.Items.Add(dw.lvi);
                    listViewEx1.AddEmbeddedControl(dw.progress, 3, listViewEx1.Items.Count - 1);
                    downloads.Add(dw);
                }
            }


        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options o = new Options();
            o.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                currentDatabase = dlcsDbs;
                textBox1_TextChanged(null, null);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                currentDatabase = gamesDbs;
                textBox1_TextChanged(null, null);
            }
        }

        CancellationTokenSource tokenSource = new CancellationTokenSource();

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        Item previousSelectedItem = null;
        private void timer2_Tick(object sender, EventArgs e)
        {
            //update view

            if (listView1.SelectedItems.Count == 0) return;
            Item itm = (listView1.SelectedItems[0].Tag as Item);

            if (itm != previousSelectedItem)
            {
                previousSelectedItem = itm;

                tokenSource.Cancel();
                tokenSource = new CancellationTokenSource();

                Task.Run(() =>
                {
                    Helpers.Renascene r = new Helpers.Renascene(itm);

                    if (r.imgUrl != null)
                    {
                        Invoke(new Action(() =>
                        {
                            pictureBox1.LoadAsync(r.imgUrl);
                            label5.Text = r.ToString();
                        }));

                    }
                    else
                    {
                        Invoke(new Action(() =>
                        {
                            pictureBox1.Image = null;
                            label5.Text = "";
                        }));

                    }
                }, tokenSource.Token);
            }
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewEx1.SelectedItems.Count == 0) return;
            foreach (ListViewItem a in listViewEx1.SelectedItems)
            {
                DownloadWorker itm = (a.Tag as DownloadWorker);
                itm.Cancel();
                itm.DeletePkg();
            }


        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (listViewEx1.SelectedItems.Count == 0) return;
            foreach (ListViewItem a in listViewEx1.SelectedItems)
            {
                DownloadWorker itm = (a.Tag as DownloadWorker);
                itm.DeletePkg();
            }

        }

        private void retryUnpackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewEx1.SelectedItems.Count == 0) return;
            foreach (ListViewItem a in listViewEx1.SelectedItems)
            {
                DownloadWorker itm = (a.Tag as DownloadWorker);
                itm.Unpack();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int workingThreads = 0;
            foreach (var dw in downloads)
            {
                if (!dw.isCompleted && dw.isRunning)
                    workingThreads++;
            }

            if (workingThreads < Settings.instance.simultaneousDl)
            {
                foreach (var dw in downloads)
                {
                    if (!dw.isCompleted && !dw.isRunning && !dw.isCanceled)
                    {
                        dw.Start();
                        break;
                    }
                }
            }
        }

        private void clearCompletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DownloadWorker> toDel = new List<DownloadWorker>();
            List<ListViewItem> toDelLVI = new List<ListViewItem>();

            foreach (var i in downloads)
            {
                if (i.isCompleted || i.isCanceled)
                {
                    toDel.Add(i);
                }
            }


            foreach (ListViewItem i in listViewEx1.Items)
            {
                if (toDel.Contains(i.Tag as DownloadWorker))
                    toDelLVI.Add(i);

            }

            foreach (var i in toDel)
                downloads.Remove(i);
            toDel.Clear();

            foreach (var i in toDelLVI)
                listViewEx1.Items.Remove(i);
            toDelLVI.Clear();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (currentOrderColumn == e.Column) { currentOrderInverted = !currentOrderInverted; }
            else
            {
                currentOrderColumn = e.Column; currentOrderInverted = false;
            }

            this.listView1.ListViewItemSorter = new ListViewItemComparer(currentOrderColumn, currentOrderInverted);
            // Call the sort method to manually sort.
            listView1.Sort();
        }

        Release[] releases = null;

        void NewVersionCheck()
        {
            Task.Run(() =>
            {
                try
                {


                    WebClient wc = new WebClient();
                    wc.Credentials = CredentialCache.DefaultCredentials;
                    wc.Headers.Add("user-agent", "MyPersonalApp :)");
                    string content = wc.DownloadString("https://api.github.com/repos/jhonhenry10/NPS_Browser/releases");
                    wc.Dispose();

                    //dynamic test = JsonConvert.DeserializeObject<dynamic>(content);
                    releases = SimpleJson.SimpleJson.DeserializeObject<Release[]>(content);

                    string newVer = releases[0].tag_name;
                    if (version != newVer)
                    {
                        Invoke(new Action(() =>
                        {
                            downloadUpdateToolStripMenuItem.Visible = true;
                            this.Text += string.Format("         (!! new version {0} available !!)", newVer);
                        }));
                    }

                }
                catch { }
            });

        }

        private void downloadUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = releases?[0]?.assets?[0]?.browser_download_url;
            if (!string.IsNullOrEmpty(url))
                System.Diagnostics.Process.Start(url);
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                //listView1.MultiSelect = true;
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void listViewEx1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                //listView1.MultiSelect = true;
                foreach (ListViewItem item in listViewEx1.Items)
                {
                    item.Selected = true;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                currentDatabase = psmDbs;
                textBox1_TextChanged(null, null);
            }
        }

        private void downloadAllDlcsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.SelectedItems)
            {

                var parrent = (itm.Tag as Item);

                foreach (var a in parrent.DlcItm)
                {
                    bool contains = false;
                    foreach (var d in downloads)
                        if (d.currentDownload == a)
                        {
                            contains = true;
                            break; //already downloading
                        }

                    if (!contains)
                    {
                        DownloadWorker dw = new DownloadWorker(a, this);
                        listViewEx1.Items.Add(dw.lvi);
                        listViewEx1.AddEmbeddedControl(dw.progress, 3, listViewEx1.Items.Count - 1);
                        downloads.Add(dw);
                    }
                }
            }
        }
    }


    class Release
    {
        public string tag_name = "";
        public Asset[] assets = null;
    }
    class Asset
    {
        public string browser_download_url = "";
    }


}
