namespace NPS
{
    partial class NPSBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPSBrowser));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstTitles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DLCs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTitlesMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadAndUnpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTitleDlcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadAllDlcsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.rbnGames = new System.Windows.Forms.RadioButton();
            this.rbnDLC = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ptbCover = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDownloadStatusMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retryUnpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.rbnPSM = new System.Windows.Forms.RadioButton();
            this.lstDownloadStatus = new ListViewEmbeddedControls.ListViewEx();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnkOpenRenaScene = new System.Windows.Forms.LinkLabel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.splMain = new System.Windows.Forms.SplitContainer();
            this.splList = new System.Windows.Forms.SplitContainer();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCount = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pauseResumeLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.ResumeAll = new System.Windows.Forms.Button();
            this.PauseAll = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.lstTitlesMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCover)).BeginInit();
            this.lstDownloadStatusMenuStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).BeginInit();
            this.splMain.Panel1.SuspendLayout();
            this.splMain.Panel2.SuspendLayout();
            this.splMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splList)).BeginInit();
            this.splList.Panel1.SuspendLayout();
            this.splList.Panel2.SuspendLayout();
            this.splList.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pauseResumeLayoutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.downloadUpdateToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(909, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_reload;
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.NoPayStationBrowser_Load);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_options;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Tag = "Exit";
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // downloadUpdateToolStripMenuItem
            // 
            this.downloadUpdateToolStripMenuItem.Name = "downloadUpdateToolStripMenuItem";
            this.downloadUpdateToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.downloadUpdateToolStripMenuItem.Text = "Download update";
            this.downloadUpdateToolStripMenuItem.Visible = false;
            this.downloadUpdateToolStripMenuItem.Click += new System.EventHandler(this.downloadUpdateToolStripMenuItem_Click);
            // 
            // lstTitles
            // 
            this.lstTitles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.DLCs,
            this.modDate});
            this.lstTitles.ContextMenuStrip = this.lstTitlesMenuStrip;
            this.lstTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTitles.FullRowSelect = true;
            this.lstTitles.Location = new System.Drawing.Point(0, 52);
            this.lstTitles.Name = "lstTitles";
            this.lstTitles.Size = new System.Drawing.Size(676, 341);
            this.lstTitles.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstTitles.TabIndex = 1;
            this.lstTitles.UseCompatibleStateImageBehavior = false;
            this.lstTitles.View = System.Windows.Forms.View.Details;
            this.lstTitles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstTitles_ColumnClick);
            this.lstTitles.SelectedIndexChanged += new System.EventHandler(this.lstTitles_SelectedIndexChanged);
            this.lstTitles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTitles_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TitleId";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Region";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 286;
            // 
            // DLCs
            // 
            this.DLCs.Text = "DLCs";
            // 
            // modDate
            // 
            this.modDate.Text = "Last modify";
            this.modDate.Width = 119;
            // 
            // lstTitlesMenuStrip
            // 
            this.lstTitlesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadAndUnpackToolStripMenuItem,
            this.showTitleDlcToolStripMenuItem,
            this.downloadAllDlcsToolStripMenuItem});
            this.lstTitlesMenuStrip.Name = "contextMenuStrip2";
            this.lstTitlesMenuStrip.Size = new System.Drawing.Size(195, 70);
            // 
            // downloadAndUnpackToolStripMenuItem
            // 
            this.downloadAndUnpackToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_unpack;
            this.downloadAndUnpackToolStripMenuItem.Name = "downloadAndUnpackToolStripMenuItem";
            this.downloadAndUnpackToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.downloadAndUnpackToolStripMenuItem.Text = "Download and Unpack";
            this.downloadAndUnpackToolStripMenuItem.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // showTitleDlcToolStripMenuItem
            // 
            this.showTitleDlcToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_show_dlc;
            this.showTitleDlcToolStripMenuItem.Name = "showTitleDlcToolStripMenuItem";
            this.showTitleDlcToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.showTitleDlcToolStripMenuItem.Text = "Show Title DLCs";
            this.showTitleDlcToolStripMenuItem.Click += new System.EventHandler(this.showTitleDlcToolStripMenuItem_Click);
            // 
            // downloadAllDlcsToolStripMenuItem
            // 
            this.downloadAllDlcsToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_download_dlc;
            this.downloadAllDlcsToolStripMenuItem.Name = "downloadAllDlcsToolStripMenuItem";
            this.downloadAllDlcsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.downloadAllDlcsToolStripMenuItem.Text = "Download All DLCs";
            this.downloadAllDlcsToolStripMenuItem.Click += new System.EventHandler(this.downloadAllDlcsToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(590, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.Image = global::NPS.Properties.Resources.menu_download;
            this.btnDownload.Location = new System.Drawing.Point(3, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(211, 23);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download and Unpack";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // rbnGames
            // 
            this.rbnGames.AutoSize = true;
            this.rbnGames.Checked = true;
            this.rbnGames.Enabled = false;
            this.rbnGames.Location = new System.Drawing.Point(69, 3);
            this.rbnGames.Name = "rbnGames";
            this.rbnGames.Size = new System.Drawing.Size(58, 17);
            this.rbnGames.TabIndex = 8;
            this.rbnGames.TabStop = true;
            this.rbnGames.Text = "Games";
            this.rbnGames.UseVisualStyleBackColor = true;
            this.rbnGames.CheckedChanged += new System.EventHandler(this.rbnGames_CheckedChanged);
            // 
            // rbnDLC
            // 
            this.rbnDLC.AutoSize = true;
            this.rbnDLC.Enabled = false;
            this.rbnDLC.Location = new System.Drawing.Point(133, 3);
            this.rbnDLC.Name = "rbnDLC";
            this.rbnDLC.Size = new System.Drawing.Size(51, 17);
            this.rbnDLC.TabIndex = 9;
            this.rbnDLC.Text = "DLCs";
            this.rbnDLC.UseVisualStyleBackColor = true;
            this.rbnDLC.CheckedChanged += new System.EventHandler(this.rbnDLC_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Browse for:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ptbCover
            // 
            this.ptbCover.ImageLocation = "";
            this.ptbCover.Location = new System.Drawing.Point(3, 32);
            this.ptbCover.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.ptbCover.Name = "ptbCover";
            this.ptbCover.Size = new System.Drawing.Size(211, 198);
            this.ptbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCover.TabIndex = 11;
            this.ptbCover.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(3, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 66);
            this.label5.TabIndex = 12;
            // 
            // lstDownloadStatusMenuStrip
            // 
            this.lstDownloadStatusMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.retryUnpackToolStripMenuItem,
            this.clearCompletedToolStripMenuItem});
            this.lstDownloadStatusMenuStrip.Name = "contextMenuStrip1";
            this.lstDownloadStatusMenuStrip.Size = new System.Drawing.Size(164, 116);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pauseToolStripMenuItem.Image")));
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_resume;
            this.resumeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_cancel;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // retryUnpackToolStripMenuItem
            // 
            this.retryUnpackToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_retry;
            this.retryUnpackToolStripMenuItem.Name = "retryUnpackToolStripMenuItem";
            this.retryUnpackToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.retryUnpackToolStripMenuItem.Text = "Retry Unpack";
            this.retryUnpackToolStripMenuItem.Click += new System.EventHandler(this.retryUnpackToolStripMenuItem_Click);
            // 
            // clearCompletedToolStripMenuItem
            // 
            this.clearCompletedToolStripMenuItem.Image = global::NPS.Properties.Resources.menu_clear;
            this.clearCompletedToolStripMenuItem.Name = "clearCompletedToolStripMenuItem";
            this.clearCompletedToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.clearCompletedToolStripMenuItem.Text = "Clear Completed";
            this.clearCompletedToolStripMenuItem.Click += new System.EventHandler(this.clearCompletedToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmbRegion
            // 
            this.cmbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(599, 3);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(74, 21);
            this.cmbRegion.TabIndex = 15;
            this.cmbRegion.SelectedIndexChanged += new System.EventHandler(this.cmbRegion_SelectedIndexChanged);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // rbnPSM
            // 
            this.rbnPSM.AutoSize = true;
            this.rbnPSM.Enabled = false;
            this.rbnPSM.Location = new System.Drawing.Point(190, 3);
            this.rbnPSM.Name = "rbnPSM";
            this.rbnPSM.Size = new System.Drawing.Size(48, 17);
            this.rbnPSM.TabIndex = 16;
            this.rbnPSM.Text = "PSM";
            this.rbnPSM.UseVisualStyleBackColor = true;
            this.rbnPSM.CheckedChanged += new System.EventHandler(this.rbnPSM_CheckedChanged);
            // 
            // lstDownloadStatus
            // 
            this.lstDownloadStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lstDownloadStatus.ContextMenuStrip = this.lstDownloadStatusMenuStrip;
            this.lstDownloadStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDownloadStatus.FullRowSelect = true;
            this.lstDownloadStatus.Location = new System.Drawing.Point(0, 0);
            this.lstDownloadStatus.Name = "lstDownloadStatus";
            this.lstDownloadStatus.Size = new System.Drawing.Size(897, 207);
            this.lstDownloadStatus.TabIndex = 14;
            this.lstDownloadStatus.UseCompatibleStateImageBehavior = false;
            this.lstDownloadStatus.View = System.Windows.Forms.View.Details;
            this.lstDownloadStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstDownloadStatus_KeyDown);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Title";
            this.columnHeader8.Width = 230;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Speed";
            this.columnHeader9.Width = 105;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Progress";
            this.columnHeader10.Width = 155;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "";
            this.columnHeader11.Width = 255;
            // 
            // lnkOpenRenaScene
            // 
            this.lnkOpenRenaScene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkOpenRenaScene.Location = new System.Drawing.Point(3, 299);
            this.lnkOpenRenaScene.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lnkOpenRenaScene.Name = "lnkOpenRenaScene";
            this.lnkOpenRenaScene.Size = new System.Drawing.Size(214, 21);
            this.lnkOpenRenaScene.TabIndex = 17;
            this.lnkOpenRenaScene.TabStop = true;
            this.lnkOpenRenaScene.Text = "Open renascene.com (screens, video)";
            this.lnkOpenRenaScene.Visible = false;
            this.lnkOpenRenaScene.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOpenRenaScene_LinkClicked);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.splMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(6);
            this.pnlMain.Size = new System.Drawing.Size(909, 616);
            this.pnlMain.TabIndex = 18;
            // 
            // splMain
            // 
            this.splMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splMain.IsSplitterFixed = true;
            this.splMain.Location = new System.Drawing.Point(6, 6);
            this.splMain.Name = "splMain";
            this.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splMain.Panel1
            // 
            this.splMain.Panel1.Controls.Add(this.splList);
            // 
            // splMain.Panel2
            // 
            this.splMain.Panel2.Controls.Add(this.lstDownloadStatus);
            this.splMain.Size = new System.Drawing.Size(897, 604);
            this.splMain.SplitterDistance = 393;
            this.splMain.TabIndex = 18;
            // 
            // splList
            // 
            this.splList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splList.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splList.IsSplitterFixed = true;
            this.splList.Location = new System.Drawing.Point(0, 0);
            this.splList.Name = "splList";
            // 
            // splList.Panel1
            // 
            this.splList.Panel1.Controls.Add(this.lstTitles);
            this.splList.Panel1.Controls.Add(this.pnlSearch);
            // 
            // splList.Panel2
            // 
            this.splList.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splList.Panel2.Controls.Add(this.panel1);
            this.splList.Panel2.Controls.Add(this.pauseResumeLayoutPnl);
            this.splList.Size = new System.Drawing.Size(897, 393);
            this.splList.SplitterDistance = 676;
            this.splList.TabIndex = 18;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.flowLayoutPanel3);
            this.pnlSearch.Controls.Add(this.flowLayoutPanel1);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.cmbRegion);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(676, 52);
            this.pnlSearch.TabIndex = 17;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.lblCount);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(517, 26);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(156, 23);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(3, 3);
            this.lblCount.Margin = new System.Windows.Forms.Padding(3);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(150, 17);
            this.lblCount.TabIndex = 11;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.rbnGames);
            this.flowLayoutPanel1.Controls.Add(this.rbnDLC);
            this.flowLayoutPanel1.Controls.Add(this.rbnPSM);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 23);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnDownload);
            this.flowLayoutPanel2.Controls.Add(this.ptbCover);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.lnkOpenRenaScene);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(217, 320);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 52);
            this.panel1.TabIndex = 18;
            // 
            // pauseResumeLayoutPnl
            // 
            this.pauseResumeLayoutPnl.ColumnCount = 2;
            this.pauseResumeLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pauseResumeLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pauseResumeLayoutPnl.Controls.Add(this.ResumeAll, 1, 0);
            this.pauseResumeLayoutPnl.Controls.Add(this.PauseAll, 0, 0);
            this.pauseResumeLayoutPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pauseResumeLayoutPnl.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.pauseResumeLayoutPnl.Location = new System.Drawing.Point(0, 372);
            this.pauseResumeLayoutPnl.Margin = new System.Windows.Forms.Padding(0);
            this.pauseResumeLayoutPnl.Name = "pauseResumeLayoutPnl";
            this.pauseResumeLayoutPnl.RowCount = 1;
            this.pauseResumeLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pauseResumeLayoutPnl.Size = new System.Drawing.Size(217, 21);
            this.pauseResumeLayoutPnl.TabIndex = 18;
            // 
            // ResumeAll
            // 
            this.ResumeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResumeAll.Image = global::NPS.Properties.Resources.menu_resume;
            this.ResumeAll.Location = new System.Drawing.Point(108, 0);
            this.ResumeAll.Margin = new System.Windows.Forms.Padding(0);
            this.ResumeAll.Name = "ResumeAll";
            this.ResumeAll.Size = new System.Drawing.Size(109, 21);
            this.ResumeAll.TabIndex = 1;
            this.ResumeAll.Text = "Resume All";
            this.ResumeAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResumeAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResumeAll.UseVisualStyleBackColor = true;
            this.ResumeAll.Click += new System.EventHandler(this.ResumeAllBtnClick);
            // 
            // PauseAll
            // 
            this.PauseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseAll.Image = ((System.Drawing.Image)(resources.GetObject("PauseAll.Image")));
            this.PauseAll.Location = new System.Drawing.Point(0, 0);
            this.PauseAll.Margin = new System.Windows.Forms.Padding(0);
            this.PauseAll.Name = "PauseAll";
            this.PauseAll.Size = new System.Drawing.Size(108, 21);
            this.PauseAll.TabIndex = 0;
            this.PauseAll.Text = "Pause All";
            this.PauseAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PauseAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PauseAll.UseVisualStyleBackColor = true;
            this.PauseAll.Click += new System.EventHandler(this.PauseAllBtnClick);
            // 
            // NPSBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 640);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "NPSBrowser";
            this.Text = "NPS Browser";
            this.Load += new System.EventHandler(this.NoPayStationBrowser_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.lstTitlesMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCover)).EndInit();
            this.lstDownloadStatusMenuStrip.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.splMain.Panel1.ResumeLayout(false);
            this.splMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMain)).EndInit();
            this.splMain.ResumeLayout(false);
            this.splList.Panel1.ResumeLayout(false);
            this.splList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splList)).EndInit();
            this.splList.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pauseResumeLayoutPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        #region Windows Form Designer generated code


        #endregion

        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ListView lstTitles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RadioButton rbnGames;
        private System.Windows.Forms.RadioButton rbnDLC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ptbCover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip lstDownloadStatusMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retryUnpackToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ListViewEmbeddedControls.ListViewEx lstDownloadStatus;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ToolStripMenuItem clearCompletedToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader DLCs;
        private System.Windows.Forms.ToolStripMenuItem downloadUpdateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip lstTitlesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showTitleDlcToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader modDate;
        private System.Windows.Forms.RadioButton rbnPSM;
        private System.Windows.Forms.ToolStripMenuItem downloadAllDlcsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadAndUnpackToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkOpenRenaScene;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.SplitContainer splMain;
        private System.Windows.Forms.SplitContainer splList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel pauseResumeLayoutPnl;
        private System.Windows.Forms.Button ResumeAll;
        private System.Windows.Forms.Button PauseAll;
    }
}

