using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPS
{
    public class DownloadWorker
    {
        public Item currentDownload;
        private WebClient webClient;
        private DateTime lastUpdate;
        private long lastBytes;
        public ProgressBar progress = new ProgressBar();
        public ListViewItem lvi;

        //public bool isRunning { get; private set; }
        //public bool isCompleted { get; private set; }
        //public bool isCanceled { get; private set; }

        public WorkerStatus status { get; private set; }
        Timer timer = new Timer();

        Form formCaller;

        public DownloadWorker(Item itm, Form f)
        {
            currentDownload = itm;
            lvi = new ListViewItem(itm.TitleName);
            lvi.SubItems.Add("Waiting");
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            lvi.Tag = this;
            //isRunning = false;
            //isCanceled = false;
            //isCompleted = false;

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            formCaller = f;
            status = WorkerStatus.Queued;

        }



        public void Start()
        {
            Console.WriteLine("start process " + currentDownload.TitleName);
            timer.Start();
            //isRunning = true;
            status = WorkerStatus.Running;
            DownloadFile(/*currentDownload*/);
        }

        public void Cancel()
        {
            timer.Stop();
            status = WorkerStatus.Canceled;

            if (webClient != null)
                webClient.CancelAsync();
            if (unpackProcess != null) unpackProcess.Kill();

            lvi.SubItems[1].Text = "";
            lvi.SubItems[2].Text = "Canceled";
            progress.Value = 0;
        }

        public void DeletePkg()
        {
            if (currentDownload != null)
                if (File.Exists(Settings.instance.downloadDir + "\\" + currentDownload.TitleId + ".pkg"))
                    File.Delete(Settings.instance.downloadDir + "\\" + currentDownload.TitleId + ".pkg");
        }

        System.Diagnostics.Process unpackProcess = null;
        public void Unpack()
        {
            if (this.status == WorkerStatus.Queued || this.status == WorkerStatus.Running || this.status == WorkerStatus.Canceled) return;

            lvi.SubItems[2].Text = "Unpacking";

            System.Diagnostics.ProcessStartInfo a = new System.Diagnostics.ProcessStartInfo();
            a.WorkingDirectory = Settings.instance.downloadDir + "\\";
            a.FileName = string.Format("\"{0}\"", Settings.instance.pkgPath);
            a.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            a.CreateNoWindow = true;
            a.Arguments = Settings.instance.pkgParams.ToLower().Replace("{pkgfile}", "\"" + Settings.instance.downloadDir + "\\" + currentDownload.TitleId + ".pkg\"").Replace("{zrifkey}", currentDownload.zRfi);
            unpackProcess = new System.Diagnostics.Process();

            unpackProcess.StartInfo = a;

            a.UseShellExecute = false;
            //a.RedirectStandardOutput = true;
            a.RedirectStandardError = true;


            unpackProcess.EnableRaisingEvents = true;
            unpackProcess.Exited += Proc_Exited;
            //unpackProcess.OutputDataReceived += new DataReceivedEventHandler(partialOutputHandler);
            unpackProcess.ErrorDataReceived += new DataReceivedEventHandler(UnpackProcess_ErrorDataReceived);
            errors = new List<string>();
            unpackProcess.Start();
            //unpackProcess.BeginOutputReadLine();
            unpackProcess.BeginErrorReadLine();
        }

        List<string> errors = new List<string>();

        private void UnpackProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            errors.Add(e.Data);
        }

        //private void partialOutputHandler(object sender, DataReceivedEventArgs e)
        //{
        //    //Console.WriteLine(e.Data);
        //}

        private void Proc_Exited(object sender, EventArgs e)
        {
            this.status = WorkerStatus.Completed;

            var proc = (sender as System.Diagnostics.Process);
            if (proc.ExitCode == 0)
            {
                formCaller.Invoke(new Action(() =>
                {
                    lvi.SubItems[1].Text = "";
                    lvi.SubItems[2].Text = "Completed";
                    if (Settings.instance.deleteAfterUnpack)
                        DeletePkg();
                }));
            }
            else
            {
                formCaller.Invoke(new Action(() =>
                {
                    lvi.SubItems[1].Text = "PKG decrypt err!";
                    lvi.SubItems[2].Text = "";

                    errors.Remove(null);
                    if (errors.Count > 0)
                    {
                        if (errors[0].Contains("pkg_dec - PS Vita PKG decryptor/unpacker")) errors.Remove(errors[0]);
                        if (errors.Count > 0)
                            lvi.SubItems[2].Text = errors[0];
                    }

                }
                ));
            }

        }

        private void DownloadFile(/*Item item*/)
        {
            try
            {
                FetchFileName();
                webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webClient.DownloadProgressChanged += (sender, e) => progressChangeForSpeed(e.BytesReceived);
                webClient.DownloadFileAsync(new Uri(currentDownload.pkg), Settings.instance.downloadDir + "\\" + currentDownload.TitleId + ".pkg");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void FetchFileName()
        {
            int count = 1;
            string orgTitle = currentDownload.TitleId;

            while (File.Exists(Settings.instance.downloadDir + "\\" + currentDownload.TitleId + ".pkg"))
            {
                currentDownload.TitleId = orgTitle + "_" + count;
                count++;
            }


        }

        private string currentSpeed = "Queued", progressString = "Queued";
        int percent = 0;
        private void progressChangeForSpeed(long bytes)
        {
            if (lastBytes == 0)
            {
                lastUpdate = DateTime.Now;
                lastBytes = bytes;
                return;
            }

            var now = DateTime.Now;
            var timeSpan = now - lastUpdate;
            var bytesChange = bytes - lastBytes;
            if (timeSpan.Seconds == 0) return;
            var bytesPerSecond = bytesChange / timeSpan.Seconds;
            lastBytes = bytes;
            lastUpdate = now;

            bytesPerSecond = bytesPerSecond / 1024;
            if (bytesPerSecond < 1500)
                currentSpeed = bytesPerSecond.ToString() + " KB/s";
            else
            {
                currentSpeed = ((float)((float)bytesPerSecond / 1024)).ToString("0.00") + " MB/s";
            }

        }
        //  
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressString = ((float)((float)e.BytesReceived / (1024 * 1024))).ToString("0.00") + " MB / " + ((float)((float)e.TotalBytesToReceive / (1024 * 1024))).ToString("0.00") + " MB";
            //progressBar1.Value = e.ProgressPercentage;
            percent = e.ProgressPercentage;
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            timer.Stop();

            //isRunning = false;

            if (!e.Cancelled)
            {

                this.status = WorkerStatus.Downloaded;

                lvi.SubItems[1].Text = "";
                Unpack();


                progress.Value = 100;
            }
            else
            {
                lvi.SubItems[1].Text = "";
                lvi.SubItems[2].Text = "Canceled";
                this.status = WorkerStatus.Canceled;

            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lvi.SubItems[1].Text = currentSpeed;
            lvi.SubItems[2].Text = progressString;
            progress.Value = percent;

        }

    }

    public enum WorkerStatus { Queued, Running, Completed, Downloaded, Canceled }


}
