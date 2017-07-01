namespace SAMPLauncherNET
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.serversPage = new System.Windows.Forms.TabPage();
            this.serversLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.serversSplitContainer = new System.Windows.Forms.SplitContainer();
            this.serversGridView = new System.Windows.Forms.DataGridView();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPlayersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAndPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serversContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectWithRCONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showExtendedServerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addServerToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeServerFromFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serversDataSet = new System.Data.DataSet();
            this.serversDataTable = new System.Data.DataTable();
            this.pingDataColumn = new System.Data.DataColumn();
            this.hostnameDataColumn = new System.Data.DataColumn();
            this.playersDataColumn = new System.Data.DataColumn();
            this.maxPlayersDataColumn = new System.Data.DataColumn();
            this.modeDataColumn = new System.Data.DataColumn();
            this.languageDataColumn = new System.Data.DataColumn();
            this.ipAndPortDataColumn = new System.Data.DataColumn();
            this.groupIDDataColumn = new System.Data.DataColumn();
            this.playersDataTable = new System.Data.DataTable();
            this.playerDataColumn = new System.Data.DataColumn();
            this.scoreDataColumn = new System.Data.DataColumn();
            this.rulesDataTable = new System.Data.DataTable();
            this.ruleDataColumn = new System.Data.DataColumn();
            this.valueDataColumn = new System.Data.DataColumn();
            this.serverInfoSplitContainer = new System.Windows.Forms.SplitContainer();
            this.playersGridView = new System.Windows.Forms.DataGridView();
            this.playerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rulesGridView = new System.Windows.Forms.DataGridView();
            this.ruleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputFilterLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.serverCountLabel = new MaterialSkin.Controls.MaterialLabel();
            this.connectButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.launchDebugModeButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.launchSingleplayerButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.closeWhenLaunchedCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.selectFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.showMasterListRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.showHostedListRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.showFavouritesRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.serversFilterLabel = new MaterialSkin.Controls.MaterialLabel();
            this.filterRadioGroupFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filterHostnameRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.filterModeRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.filterLanguageRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.filterIPAndPortRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.footerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gitHubProjectLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gitHubProjectPictureBox = new System.Windows.Forms.PictureBox();
            this.languageLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.languagesComboBox = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.galleryPage = new System.Windows.Forms.TabPage();
            this.galleryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.galleryMenuLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.galleryViewPictureBox = new System.Windows.Forms.PictureBox();
            this.showGalleryPictureBox = new System.Windows.Forms.PictureBox();
            this.galleryDeletePictureBox = new System.Windows.Forms.PictureBox();
            this.galleryListView = new System.Windows.Forms.ListView();
            this.galleryImageList = new System.Windows.Forms.ImageList(this.components);
            this.lastChatlogPage = new System.Windows.Forms.TabPage();
            this.lastChatlogTextBox = new System.Windows.Forms.TextBox();
            this.savedPositionsPage = new System.Windows.Forms.TabPage();
            this.savedPositionsTextBox = new System.Windows.Forms.TextBox();
            this.optionsPage = new System.Windows.Forms.TabPage();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.revertConfigButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveConfigButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fontWeightCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.fontFaceSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fontFaceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.noNametagStatusCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.audioProxyOffCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.audioMessageOffCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.directModeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.multiCoreCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.imeCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.timestampCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.disableHeadMoveCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.fpsLimitTrackBar = new System.Windows.Forms.TrackBar();
            this.fpsLimitSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fpsLimitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pageSizeSingleLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pageSizeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.apiPage = new System.Windows.Forms.TabPage();
            this.aboutPage = new System.Windows.Forms.TabPage();
            this.mainTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.serverListTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.galleryFileSystemWatcher = new System.IO.FileSystemWatcher();
            this.textFileSystemWatcher = new System.IO.FileSystemWatcher();
            this.mainTabControl.SuspendLayout();
            this.serversPage.SuspendLayout();
            this.serversLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversSplitContainer)).BeginInit();
            this.serversSplitContainer.Panel1.SuspendLayout();
            this.serversSplitContainer.Panel2.SuspendLayout();
            this.serversSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversGridView)).BeginInit();
            this.serversContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverInfoSplitContainer)).BeginInit();
            this.serverInfoSplitContainer.Panel1.SuspendLayout();
            this.serverInfoSplitContainer.Panel2.SuspendLayout();
            this.serverInfoSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            this.inputFilterLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.selectFlowLayoutPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.filterRadioGroupFlowLayoutPanel.SuspendLayout();
            this.footerTableLayoutPanel.SuspendLayout();
            this.gitHubProjectLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gitHubProjectPictureBox)).BeginInit();
            this.languageLayoutPanel.SuspendLayout();
            this.galleryPage.SuspendLayout();
            this.galleryTableLayoutPanel.SuspendLayout();
            this.galleryMenuLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryViewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGalleryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDeletePictureBox)).BeginInit();
            this.lastChatlogPage.SuspendLayout();
            this.savedPositionsPage.SuspendLayout();
            this.optionsPage.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsLimitTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryFileSystemWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.serversPage);
            this.mainTabControl.Controls.Add(this.galleryPage);
            this.mainTabControl.Controls.Add(this.lastChatlogPage);
            this.mainTabControl.Controls.Add(this.savedPositionsPage);
            this.mainTabControl.Controls.Add(this.optionsPage);
            this.mainTabControl.Controls.Add(this.apiPage);
            this.mainTabControl.Controls.Add(this.aboutPage);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Location = new System.Drawing.Point(5, 117);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1000, 562);
            this.mainTabControl.TabIndex = 2;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // serversPage
            // 
            this.serversPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.serversPage.Controls.Add(this.serversLayoutPanel);
            this.serversPage.Location = new System.Drawing.Point(4, 22);
            this.serversPage.Name = "serversPage";
            this.serversPage.Padding = new System.Windows.Forms.Padding(3);
            this.serversPage.Size = new System.Drawing.Size(992, 536);
            this.serversPage.TabIndex = 0;
            this.serversPage.Text = "{$SERVERS$}";
            // 
            // serversLayoutPanel
            // 
            this.serversLayoutPanel.ColumnCount = 1;
            this.serversLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.serversLayoutPanel.Controls.Add(this.serversSplitContainer, 0, 0);
            this.serversLayoutPanel.Controls.Add(this.inputFilterLayoutPanel, 0, 1);
            this.serversLayoutPanel.Controls.Add(this.footerTableLayoutPanel, 0, 2);
            this.serversLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.serversLayoutPanel.Name = "serversLayoutPanel";
            this.serversLayoutPanel.RowCount = 3;
            this.serversLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.serversLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.serversLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.serversLayoutPanel.Size = new System.Drawing.Size(986, 530);
            this.serversLayoutPanel.TabIndex = 0;
            // 
            // serversSplitContainer
            // 
            this.serversSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serversSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.serversSplitContainer.Name = "serversSplitContainer";
            // 
            // serversSplitContainer.Panel1
            // 
            this.serversSplitContainer.Panel1.Controls.Add(this.serversGridView);
            // 
            // serversSplitContainer.Panel2
            // 
            this.serversSplitContainer.Panel2.Controls.Add(this.serverInfoSplitContainer);
            this.serversSplitContainer.Size = new System.Drawing.Size(980, 283);
            this.serversSplitContainer.SplitterDistance = 632;
            this.serversSplitContainer.TabIndex = 2;
            // 
            // serversGridView
            // 
            this.serversGridView.AllowUserToAddRows = false;
            this.serversGridView.AllowUserToDeleteRows = false;
            this.serversGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(155)))), ((int)(((byte)(209)))));
            this.serversGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.serversGridView.AutoGenerateColumns = false;
            this.serversGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serversGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.serversGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serversGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.serversGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.serversGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serversGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.serversGridView.ColumnHeadersHeight = 32;
            this.serversGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.serversGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupIDDataGridViewTextBoxColumn,
            this.pingDataGridViewTextBoxColumn,
            this.hostnameDataGridViewTextBoxColumn,
            this.playersDataGridViewTextBoxColumn,
            this.maxPlayersDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.iPAndPortDataGridViewTextBoxColumn});
            this.serversGridView.ContextMenuStrip = this.serversContextMenuStrip;
            this.serversGridView.DataSource = this.serversBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serversGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.serversGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.serversGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.serversGridView.Location = new System.Drawing.Point(0, 0);
            this.serversGridView.MultiSelect = false;
            this.serversGridView.Name = "serversGridView";
            this.serversGridView.ReadOnly = true;
            this.serversGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.serversGridView.RowHeadersVisible = false;
            this.serversGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.serversGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.serversGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serversGridView.Size = new System.Drawing.Size(630, 281);
            this.serversGridView.TabIndex = 0;
            this.serversGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.genericGridView_DataError);
            this.serversGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.serversGridView_RowEnter);
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            this.groupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pingDataGridViewTextBoxColumn
            // 
            this.pingDataGridViewTextBoxColumn.DataPropertyName = "Ping";
            this.pingDataGridViewTextBoxColumn.HeaderText = "Ping";
            this.pingDataGridViewTextBoxColumn.Name = "pingDataGridViewTextBoxColumn";
            this.pingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hostnameDataGridViewTextBoxColumn
            // 
            this.hostnameDataGridViewTextBoxColumn.DataPropertyName = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.HeaderText = "Hostname";
            this.hostnameDataGridViewTextBoxColumn.Name = "hostnameDataGridViewTextBoxColumn";
            this.hostnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playersDataGridViewTextBoxColumn
            // 
            this.playersDataGridViewTextBoxColumn.DataPropertyName = "Players";
            this.playersDataGridViewTextBoxColumn.HeaderText = "Players";
            this.playersDataGridViewTextBoxColumn.Name = "playersDataGridViewTextBoxColumn";
            this.playersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxPlayersDataGridViewTextBoxColumn
            // 
            this.maxPlayersDataGridViewTextBoxColumn.DataPropertyName = "Max players";
            this.maxPlayersDataGridViewTextBoxColumn.HeaderText = "Max players";
            this.maxPlayersDataGridViewTextBoxColumn.Name = "maxPlayersDataGridViewTextBoxColumn";
            this.maxPlayersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            this.modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            this.modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            this.modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            this.modeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPAndPortDataGridViewTextBoxColumn
            // 
            this.iPAndPortDataGridViewTextBoxColumn.DataPropertyName = "IP and port";
            this.iPAndPortDataGridViewTextBoxColumn.HeaderText = "IP and port";
            this.iPAndPortDataGridViewTextBoxColumn.Name = "iPAndPortDataGridViewTextBoxColumn";
            this.iPAndPortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serversContextMenuStrip
            // 
            this.serversContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serversContextMenuStrip.Depth = 0;
            this.serversContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.connectWithRCONToolStripMenuItem,
            this.toolStripSeparator3,
            this.showExtendedServerInformationToolStripMenuItem,
            this.toolStripSeparator2,
            this.addServerToFavouritesToolStripMenuItem,
            this.removeServerFromFavouritesToolStripMenuItem});
            this.serversContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.serversContextMenuStrip.Name = "serversContextMenuStrip";
            this.serversContextMenuStrip.Size = new System.Drawing.Size(321, 126);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.connectToolStripMenuItem.Text = "{$CONNECT$}";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // connectWithRCONToolStripMenuItem
            // 
            this.connectWithRCONToolStripMenuItem.Name = "connectWithRCONToolStripMenuItem";
            this.connectWithRCONToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.connectWithRCONToolStripMenuItem.Text = "{$CONNECT_WITH_RCON$}";
            this.connectWithRCONToolStripMenuItem.Click += new System.EventHandler(this.connectWithRCONToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(317, 6);
            // 
            // showExtendedServerInformationToolStripMenuItem
            // 
            this.showExtendedServerInformationToolStripMenuItem.Name = "showExtendedServerInformationToolStripMenuItem";
            this.showExtendedServerInformationToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.showExtendedServerInformationToolStripMenuItem.Text = "{$SHOW_EXTENDED_SERVER_INFORMATION$}";
            this.showExtendedServerInformationToolStripMenuItem.Click += new System.EventHandler(this.showExtendedServerInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(317, 6);
            // 
            // addServerToFavouritesToolStripMenuItem
            // 
            this.addServerToFavouritesToolStripMenuItem.Name = "addServerToFavouritesToolStripMenuItem";
            this.addServerToFavouritesToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.addServerToFavouritesToolStripMenuItem.Text = "{$ADD_SERVER_TO_FAVOURITES$}";
            this.addServerToFavouritesToolStripMenuItem.Click += new System.EventHandler(this.addServerToFavouritesToolStripMenuItem_Click);
            // 
            // removeServerFromFavouritesToolStripMenuItem
            // 
            this.removeServerFromFavouritesToolStripMenuItem.Name = "removeServerFromFavouritesToolStripMenuItem";
            this.removeServerFromFavouritesToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.removeServerFromFavouritesToolStripMenuItem.Text = "{$REMOVE_SERVER_FROM_FAVOURITES$}";
            this.removeServerFromFavouritesToolStripMenuItem.Click += new System.EventHandler(this.removeServerFromFavouritesToolStripMenuItem_Click);
            // 
            // serversBindingSource
            // 
            this.serversBindingSource.DataMember = "Servers";
            this.serversBindingSource.DataSource = this.serversDataSet;
            this.serversBindingSource.Filter = "GroupID=0";
            // 
            // serversDataSet
            // 
            this.serversDataSet.DataSetName = "serversDataSet";
            this.serversDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.serversDataTable,
            this.playersDataTable,
            this.rulesDataTable});
            // 
            // serversDataTable
            // 
            this.serversDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.pingDataColumn,
            this.hostnameDataColumn,
            this.playersDataColumn,
            this.maxPlayersDataColumn,
            this.modeDataColumn,
            this.languageDataColumn,
            this.ipAndPortDataColumn,
            this.groupIDDataColumn});
            this.serversDataTable.TableName = "Servers";
            // 
            // pingDataColumn
            // 
            this.pingDataColumn.ColumnName = "GroupID";
            this.pingDataColumn.DataType = typeof(byte);
            this.pingDataColumn.DefaultValue = ((byte)(0));
            // 
            // hostnameDataColumn
            // 
            this.hostnameDataColumn.ColumnName = "Ping";
            this.hostnameDataColumn.DataType = typeof(uint);
            this.hostnameDataColumn.DefaultValue = ((uint)(0u));
            // 
            // playersDataColumn
            // 
            this.playersDataColumn.ColumnName = "Hostname";
            this.playersDataColumn.DefaultValue = "";
            // 
            // maxPlayersDataColumn
            // 
            this.maxPlayersDataColumn.Caption = "Players";
            this.maxPlayersDataColumn.ColumnName = "Players";
            this.maxPlayersDataColumn.DataType = typeof(ushort);
            this.maxPlayersDataColumn.DefaultValue = ((ushort)(0));
            // 
            // modeDataColumn
            // 
            this.modeDataColumn.Caption = "Max players";
            this.modeDataColumn.ColumnName = "Max players";
            this.modeDataColumn.DataType = typeof(ushort);
            this.modeDataColumn.DefaultValue = ((ushort)(0));
            // 
            // languageDataColumn
            // 
            this.languageDataColumn.ColumnName = "Mode";
            this.languageDataColumn.DefaultValue = "";
            // 
            // ipAndPortDataColumn
            // 
            this.ipAndPortDataColumn.Caption = "Language";
            this.ipAndPortDataColumn.ColumnName = "Language";
            this.ipAndPortDataColumn.DefaultValue = "";
            // 
            // groupIDDataColumn
            // 
            this.groupIDDataColumn.Caption = "IP and port";
            this.groupIDDataColumn.ColumnName = "IP and port";
            this.groupIDDataColumn.DefaultValue = "";
            // 
            // playersDataTable
            // 
            this.playersDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.playerDataColumn,
            this.scoreDataColumn});
            this.playersDataTable.TableName = "Players";
            // 
            // playerDataColumn
            // 
            this.playerDataColumn.ColumnName = "Player";
            this.playerDataColumn.DefaultValue = "";
            // 
            // scoreDataColumn
            // 
            this.scoreDataColumn.ColumnName = "Score";
            this.scoreDataColumn.DataType = typeof(int);
            this.scoreDataColumn.DefaultValue = 0;
            // 
            // rulesDataTable
            // 
            this.rulesDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.ruleDataColumn,
            this.valueDataColumn});
            this.rulesDataTable.TableName = "Rules";
            // 
            // ruleDataColumn
            // 
            this.ruleDataColumn.ColumnName = "Rule";
            this.ruleDataColumn.DefaultValue = "";
            // 
            // valueDataColumn
            // 
            this.valueDataColumn.ColumnName = "Value";
            this.valueDataColumn.DefaultValue = "";
            // 
            // serverInfoSplitContainer
            // 
            this.serverInfoSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverInfoSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverInfoSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.serverInfoSplitContainer.Name = "serverInfoSplitContainer";
            this.serverInfoSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // serverInfoSplitContainer.Panel1
            // 
            this.serverInfoSplitContainer.Panel1.Controls.Add(this.playersGridView);
            // 
            // serverInfoSplitContainer.Panel2
            // 
            this.serverInfoSplitContainer.Panel2.Controls.Add(this.rulesGridView);
            this.serverInfoSplitContainer.Size = new System.Drawing.Size(344, 283);
            this.serverInfoSplitContainer.SplitterDistance = 188;
            this.serverInfoSplitContainer.TabIndex = 0;
            // 
            // playersGridView
            // 
            this.playersGridView.AllowUserToAddRows = false;
            this.playersGridView.AllowUserToDeleteRows = false;
            this.playersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(155)))), ((int)(((byte)(209)))));
            this.playersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.playersGridView.AutoGenerateColumns = false;
            this.playersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.playersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.playersGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.playersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.playersGridView.ColumnHeadersHeight = 32;
            this.playersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.playersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.playersGridView.DataSource = this.playersBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playersGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.playersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.playersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.playersGridView.Location = new System.Drawing.Point(0, 0);
            this.playersGridView.MultiSelect = false;
            this.playersGridView.Name = "playersGridView";
            this.playersGridView.ReadOnly = true;
            this.playersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.playersGridView.RowHeadersVisible = false;
            this.playersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.playersGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.playersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playersGridView.Size = new System.Drawing.Size(342, 186);
            this.playersGridView.TabIndex = 1;
            this.playersGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.genericGridView_DataError);
            // 
            // playerDataGridViewTextBoxColumn
            // 
            this.playerDataGridViewTextBoxColumn.DataPropertyName = "Player";
            this.playerDataGridViewTextBoxColumn.HeaderText = "Player";
            this.playerDataGridViewTextBoxColumn.Name = "playerDataGridViewTextBoxColumn";
            this.playerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.serversDataSet;
            // 
            // rulesGridView
            // 
            this.rulesGridView.AllowUserToAddRows = false;
            this.rulesGridView.AllowUserToDeleteRows = false;
            this.rulesGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(155)))), ((int)(((byte)(209)))));
            this.rulesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.rulesGridView.AutoGenerateColumns = false;
            this.rulesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rulesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rulesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rulesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rulesGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.rulesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rulesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.rulesGridView.ColumnHeadersHeight = 32;
            this.rulesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rulesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruleDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.rulesGridView.DataSource = this.rulesBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rulesGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.rulesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rulesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.rulesGridView.Location = new System.Drawing.Point(0, 0);
            this.rulesGridView.MultiSelect = false;
            this.rulesGridView.Name = "rulesGridView";
            this.rulesGridView.ReadOnly = true;
            this.rulesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.rulesGridView.RowHeadersVisible = false;
            this.rulesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.rulesGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.rulesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesGridView.Size = new System.Drawing.Size(342, 89);
            this.rulesGridView.TabIndex = 1;
            this.rulesGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.genericGridView_DataError);
            // 
            // ruleDataGridViewTextBoxColumn
            // 
            this.ruleDataGridViewTextBoxColumn.DataPropertyName = "Rule";
            this.ruleDataGridViewTextBoxColumn.HeaderText = "Rule";
            this.ruleDataGridViewTextBoxColumn.Name = "ruleDataGridViewTextBoxColumn";
            this.ruleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rulesBindingSource
            // 
            this.rulesBindingSource.DataMember = "Rules";
            this.rulesBindingSource.DataSource = this.serversDataSet;
            // 
            // inputFilterLayoutPanel
            // 
            this.inputFilterLayoutPanel.ColumnCount = 2;
            this.inputFilterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.inputFilterLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputFilterLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.inputFilterLayoutPanel.Controls.Add(this.filterPanel, 1, 0);
            this.inputFilterLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFilterLayoutPanel.Location = new System.Drawing.Point(3, 292);
            this.inputFilterLayoutPanel.Name = "inputFilterLayoutPanel";
            this.inputFilterLayoutPanel.RowCount = 1;
            this.inputFilterLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputFilterLayoutPanel.Size = new System.Drawing.Size(980, 185);
            this.inputFilterLayoutPanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.serverCountLabel);
            this.flowLayoutPanel1.Controls.Add(this.connectButton);
            this.flowLayoutPanel1.Controls.Add(this.launchDebugModeButton);
            this.flowLayoutPanel1.Controls.Add(this.launchSingleplayerButton);
            this.flowLayoutPanel1.Controls.Add(this.closeWhenLaunchedCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.selectFlowLayoutPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(425, 179);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // serverCountLabel
            // 
            this.serverCountLabel.AutoSize = true;
            this.serverCountLabel.Depth = 0;
            this.serverCountLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.serverCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serverCountLabel.Location = new System.Drawing.Point(3, 0);
            this.serverCountLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.serverCountLabel.Name = "serverCountLabel";
            this.serverCountLabel.Size = new System.Drawing.Size(99, 19);
            this.serverCountLabel.TabIndex = 9;
            this.serverCountLabel.Text = "{$SERVERS$}";
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectButton.Depth = 0;
            this.connectButton.Icon = null;
            this.connectButton.Location = new System.Drawing.Point(3, 22);
            this.connectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectButton.Name = "connectButton";
            this.connectButton.Primary = true;
            this.connectButton.Size = new System.Drawing.Size(109, 36);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "{$CONNECT$}";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // launchDebugModeButton
            // 
            this.launchDebugModeButton.AutoSize = true;
            this.launchDebugModeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.launchDebugModeButton.Depth = 0;
            this.launchDebugModeButton.Icon = null;
            this.launchDebugModeButton.Location = new System.Drawing.Point(3, 64);
            this.launchDebugModeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.launchDebugModeButton.Name = "launchDebugModeButton";
            this.launchDebugModeButton.Primary = true;
            this.launchDebugModeButton.Size = new System.Drawing.Size(194, 36);
            this.launchDebugModeButton.TabIndex = 8;
            this.launchDebugModeButton.Text = "{$LAUNCH_DEBUG_MODE$}";
            this.launchDebugModeButton.UseVisualStyleBackColor = true;
            this.launchDebugModeButton.Click += new System.EventHandler(this.launchDebugModeButton_Click);
            // 
            // launchSingleplayerButton
            // 
            this.launchSingleplayerButton.AutoSize = true;
            this.launchSingleplayerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.launchSingleplayerButton.Depth = 0;
            this.launchSingleplayerButton.Icon = null;
            this.launchSingleplayerButton.Location = new System.Drawing.Point(3, 106);
            this.launchSingleplayerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.launchSingleplayerButton.Name = "launchSingleplayerButton";
            this.launchSingleplayerButton.Primary = true;
            this.launchSingleplayerButton.Size = new System.Drawing.Size(202, 36);
            this.launchSingleplayerButton.TabIndex = 7;
            this.launchSingleplayerButton.Text = "{$LAUNCH_SINGLEPLAYER$}";
            this.launchSingleplayerButton.UseVisualStyleBackColor = true;
            this.launchSingleplayerButton.Click += new System.EventHandler(this.launchSingleplayerButton_Click);
            // 
            // closeWhenLaunchedCheckBox
            // 
            this.closeWhenLaunchedCheckBox.AutoSize = true;
            this.closeWhenLaunchedCheckBox.Checked = true;
            this.closeWhenLaunchedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeWhenLaunchedCheckBox.Depth = 0;
            this.closeWhenLaunchedCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.closeWhenLaunchedCheckBox.Location = new System.Drawing.Point(0, 145);
            this.closeWhenLaunchedCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.closeWhenLaunchedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.closeWhenLaunchedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeWhenLaunchedCheckBox.Name = "closeWhenLaunchedCheckBox";
            this.closeWhenLaunchedCheckBox.Ripple = true;
            this.closeWhenLaunchedCheckBox.Size = new System.Drawing.Size(219, 30);
            this.closeWhenLaunchedCheckBox.TabIndex = 10;
            this.closeWhenLaunchedCheckBox.Text = "{$CLOSE_WHEN_LAUNCHED$}";
            this.closeWhenLaunchedCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectFlowLayoutPanel
            // 
            this.selectFlowLayoutPanel.Controls.Add(this.showMasterListRadioButton);
            this.selectFlowLayoutPanel.Controls.Add(this.showHostedListRadioButton);
            this.selectFlowLayoutPanel.Controls.Add(this.showFavouritesRadioButton);
            this.selectFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.selectFlowLayoutPanel.Location = new System.Drawing.Point(222, 3);
            this.selectFlowLayoutPanel.Name = "selectFlowLayoutPanel";
            this.selectFlowLayoutPanel.Size = new System.Drawing.Size(200, 172);
            this.selectFlowLayoutPanel.TabIndex = 11;
            // 
            // showMasterListRadioButton
            // 
            this.showMasterListRadioButton.AutoSize = true;
            this.showMasterListRadioButton.Depth = 0;
            this.showMasterListRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.showMasterListRadioButton.Location = new System.Drawing.Point(0, 142);
            this.showMasterListRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.showMasterListRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.showMasterListRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showMasterListRadioButton.Name = "showMasterListRadioButton";
            this.showMasterListRadioButton.Ripple = true;
            this.showMasterListRadioButton.Size = new System.Drawing.Size(188, 30);
            this.showMasterListRadioButton.TabIndex = 2;
            this.showMasterListRadioButton.Text = "{$SHOW_MASTER_LIST$}";
            this.showMasterListRadioButton.UseVisualStyleBackColor = true;
            this.showMasterListRadioButton.CheckedChanged += new System.EventHandler(this.showGenericRadioButton_CheckedChanged);
            // 
            // showHostedListRadioButton
            // 
            this.showHostedListRadioButton.AutoSize = true;
            this.showHostedListRadioButton.Depth = 0;
            this.showHostedListRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.showHostedListRadioButton.Location = new System.Drawing.Point(0, 112);
            this.showHostedListRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.showHostedListRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.showHostedListRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showHostedListRadioButton.Name = "showHostedListRadioButton";
            this.showHostedListRadioButton.Ripple = true;
            this.showHostedListRadioButton.Size = new System.Drawing.Size(186, 30);
            this.showHostedListRadioButton.TabIndex = 1;
            this.showHostedListRadioButton.Text = "{$SHOW_HOSTED_LIST$}";
            this.showHostedListRadioButton.UseVisualStyleBackColor = true;
            this.showHostedListRadioButton.CheckedChanged += new System.EventHandler(this.showGenericRadioButton_CheckedChanged);
            // 
            // showFavouritesRadioButton
            // 
            this.showFavouritesRadioButton.AutoSize = true;
            this.showFavouritesRadioButton.Checked = true;
            this.showFavouritesRadioButton.Depth = 0;
            this.showFavouritesRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.showFavouritesRadioButton.Location = new System.Drawing.Point(0, 82);
            this.showFavouritesRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.showFavouritesRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.showFavouritesRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showFavouritesRadioButton.Name = "showFavouritesRadioButton";
            this.showFavouritesRadioButton.Ripple = true;
            this.showFavouritesRadioButton.Size = new System.Drawing.Size(180, 30);
            this.showFavouritesRadioButton.TabIndex = 0;
            this.showFavouritesRadioButton.TabStop = true;
            this.showFavouritesRadioButton.Text = "{$SHOW_FAVOURITES$}";
            this.showFavouritesRadioButton.UseVisualStyleBackColor = true;
            this.showFavouritesRadioButton.CheckedChanged += new System.EventHandler(this.showGenericRadioButton_CheckedChanged);
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.filterPanel.Controls.Add(this.filterSingleLineTextField);
            this.filterPanel.Controls.Add(this.serversFilterLabel);
            this.filterPanel.Controls.Add(this.filterRadioGroupFlowLayoutPanel);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Location = new System.Drawing.Point(434, 3);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(543, 179);
            this.filterPanel.TabIndex = 7;
            // 
            // filterSingleLineTextField
            // 
            this.filterSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterSingleLineTextField.Depth = 0;
            this.filterSingleLineTextField.Hint = "...";
            this.filterSingleLineTextField.Location = new System.Drawing.Point(7, 22);
            this.filterSingleLineTextField.MaxLength = 32767;
            this.filterSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterSingleLineTextField.Name = "filterSingleLineTextField";
            this.filterSingleLineTextField.PasswordChar = '\0';
            this.filterSingleLineTextField.SelectedText = "";
            this.filterSingleLineTextField.SelectionLength = 0;
            this.filterSingleLineTextField.SelectionStart = 0;
            this.filterSingleLineTextField.Size = new System.Drawing.Size(533, 23);
            this.filterSingleLineTextField.TabIndex = 0;
            this.filterSingleLineTextField.TabStop = false;
            this.filterSingleLineTextField.UseSystemPasswordChar = false;
            this.filterSingleLineTextField.TextChanged += new System.EventHandler(this.filterSingleLineTextField_TextChanged);
            // 
            // serversFilterLabel
            // 
            this.serversFilterLabel.AutoSize = true;
            this.serversFilterLabel.Depth = 0;
            this.serversFilterLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.serversFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.serversFilterLabel.Location = new System.Drawing.Point(3, 0);
            this.serversFilterLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.serversFilterLabel.Name = "serversFilterLabel";
            this.serversFilterLabel.Size = new System.Drawing.Size(153, 19);
            this.serversFilterLabel.TabIndex = 1;
            this.serversFilterLabel.Text = "{$SERVERS_FILTER$}";
            // 
            // filterRadioGroupFlowLayoutPanel
            // 
            this.filterRadioGroupFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterRadioGroupFlowLayoutPanel.Controls.Add(this.filterHostnameRadioButton);
            this.filterRadioGroupFlowLayoutPanel.Controls.Add(this.filterModeRadioButton);
            this.filterRadioGroupFlowLayoutPanel.Controls.Add(this.filterLanguageRadioButton);
            this.filterRadioGroupFlowLayoutPanel.Controls.Add(this.filterIPAndPortRadioButton);
            this.filterRadioGroupFlowLayoutPanel.Location = new System.Drawing.Point(7, 51);
            this.filterRadioGroupFlowLayoutPanel.Name = "filterRadioGroupFlowLayoutPanel";
            this.filterRadioGroupFlowLayoutPanel.Size = new System.Drawing.Size(533, 124);
            this.filterRadioGroupFlowLayoutPanel.TabIndex = 6;
            // 
            // filterHostnameRadioButton
            // 
            this.filterHostnameRadioButton.AutoSize = true;
            this.filterHostnameRadioButton.Checked = true;
            this.filterHostnameRadioButton.Depth = 0;
            this.filterHostnameRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.filterHostnameRadioButton.Location = new System.Drawing.Point(0, 0);
            this.filterHostnameRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.filterHostnameRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.filterHostnameRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterHostnameRadioButton.Name = "filterHostnameRadioButton";
            this.filterHostnameRadioButton.Ripple = true;
            this.filterHostnameRadioButton.Size = new System.Drawing.Size(178, 30);
            this.filterHostnameRadioButton.TabIndex = 2;
            this.filterHostnameRadioButton.TabStop = true;
            this.filterHostnameRadioButton.Text = "{$FILTER_HOSTNAME$}";
            this.filterHostnameRadioButton.UseVisualStyleBackColor = true;
            this.filterHostnameRadioButton.CheckedChanged += new System.EventHandler(this.filterGenericRadioButton_CheckedChanged);
            // 
            // filterModeRadioButton
            // 
            this.filterModeRadioButton.AutoSize = true;
            this.filterModeRadioButton.Depth = 0;
            this.filterModeRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.filterModeRadioButton.Location = new System.Drawing.Point(178, 0);
            this.filterModeRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.filterModeRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.filterModeRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterModeRadioButton.Name = "filterModeRadioButton";
            this.filterModeRadioButton.Ripple = true;
            this.filterModeRadioButton.Size = new System.Drawing.Size(142, 30);
            this.filterModeRadioButton.TabIndex = 3;
            this.filterModeRadioButton.Text = "{$FILTER_MODE$}";
            this.filterModeRadioButton.UseVisualStyleBackColor = true;
            this.filterModeRadioButton.CheckedChanged += new System.EventHandler(this.filterGenericRadioButton_CheckedChanged);
            // 
            // filterLanguageRadioButton
            // 
            this.filterLanguageRadioButton.AutoSize = true;
            this.filterLanguageRadioButton.Depth = 0;
            this.filterLanguageRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.filterLanguageRadioButton.Location = new System.Drawing.Point(320, 0);
            this.filterLanguageRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.filterLanguageRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.filterLanguageRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterLanguageRadioButton.Name = "filterLanguageRadioButton";
            this.filterLanguageRadioButton.Ripple = true;
            this.filterLanguageRadioButton.Size = new System.Drawing.Size(174, 30);
            this.filterLanguageRadioButton.TabIndex = 4;
            this.filterLanguageRadioButton.Text = "{$FILTER_LANGUAGE$}";
            this.filterLanguageRadioButton.UseVisualStyleBackColor = true;
            this.filterLanguageRadioButton.CheckedChanged += new System.EventHandler(this.filterGenericRadioButton_CheckedChanged);
            // 
            // filterIPAndPortRadioButton
            // 
            this.filterIPAndPortRadioButton.AutoSize = true;
            this.filterIPAndPortRadioButton.Depth = 0;
            this.filterIPAndPortRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.filterIPAndPortRadioButton.Location = new System.Drawing.Point(0, 30);
            this.filterIPAndPortRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.filterIPAndPortRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.filterIPAndPortRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterIPAndPortRadioButton.Name = "filterIPAndPortRadioButton";
            this.filterIPAndPortRadioButton.Ripple = true;
            this.filterIPAndPortRadioButton.Size = new System.Drawing.Size(192, 30);
            this.filterIPAndPortRadioButton.TabIndex = 5;
            this.filterIPAndPortRadioButton.Text = "{$FILTER_IP_AND_PORT$}";
            this.filterIPAndPortRadioButton.UseVisualStyleBackColor = true;
            this.filterIPAndPortRadioButton.CheckedChanged += new System.EventHandler(this.filterGenericRadioButton_CheckedChanged);
            // 
            // footerTableLayoutPanel
            // 
            this.footerTableLayoutPanel.ColumnCount = 2;
            this.footerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.footerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footerTableLayoutPanel.Controls.Add(this.gitHubProjectLayoutPanel, 0, 0);
            this.footerTableLayoutPanel.Controls.Add(this.languageLayoutPanel, 1, 0);
            this.footerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footerTableLayoutPanel.Location = new System.Drawing.Point(3, 483);
            this.footerTableLayoutPanel.Name = "footerTableLayoutPanel";
            this.footerTableLayoutPanel.RowCount = 1;
            this.footerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.footerTableLayoutPanel.Size = new System.Drawing.Size(980, 44);
            this.footerTableLayoutPanel.TabIndex = 4;
            // 
            // gitHubProjectLayoutPanel
            // 
            this.gitHubProjectLayoutPanel.Controls.Add(this.gitHubProjectPictureBox);
            this.gitHubProjectLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gitHubProjectLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.gitHubProjectLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.gitHubProjectLayoutPanel.Name = "gitHubProjectLayoutPanel";
            this.gitHubProjectLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gitHubProjectLayoutPanel.Size = new System.Drawing.Size(39, 38);
            this.gitHubProjectLayoutPanel.TabIndex = 1;
            // 
            // gitHubProjectPictureBox
            // 
            this.gitHubProjectPictureBox.Image = global::SAMPLauncherNET.Properties.Resources.github_icon;
            this.gitHubProjectPictureBox.Location = new System.Drawing.Point(3, 3);
            this.gitHubProjectPictureBox.Name = "gitHubProjectPictureBox";
            this.gitHubProjectPictureBox.Size = new System.Drawing.Size(32, 32);
            this.gitHubProjectPictureBox.TabIndex = 0;
            this.gitHubProjectPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.gitHubProjectPictureBox, "SAMPLauncherNET GitHub");
            this.gitHubProjectPictureBox.Click += new System.EventHandler(this.gitHubProjectPictureBox_Click);
            this.gitHubProjectPictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.gitHubProjectPictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // languageLayoutPanel
            // 
            this.languageLayoutPanel.Controls.Add(this.languagesComboBox);
            this.languageLayoutPanel.Controls.Add(this.materialLabel1);
            this.languageLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.languageLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.languageLayoutPanel.Location = new System.Drawing.Point(48, 3);
            this.languageLayoutPanel.Name = "languageLayoutPanel";
            this.languageLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.languageLayoutPanel.Size = new System.Drawing.Size(929, 38);
            this.languageLayoutPanel.TabIndex = 0;
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.languagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languagesComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languagesComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.Location = new System.Drawing.Point(726, 7);
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.languagesComboBox.Size = new System.Drawing.Size(200, 28);
            this.languagesComboBox.TabIndex = 13;
            this.languagesComboBox.SelectedIndexChanged += new System.EventHandler(this.languagesComboBox_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(546, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel1.Size = new System.Drawing.Size(174, 19);
            this.materialLabel1.TabIndex = 14;
            this.materialLabel1.Text = "{$SELECT_LANGUAGE$}";
            // 
            // galleryPage
            // 
            this.galleryPage.Controls.Add(this.galleryTableLayoutPanel);
            this.galleryPage.Location = new System.Drawing.Point(4, 22);
            this.galleryPage.Name = "galleryPage";
            this.galleryPage.Size = new System.Drawing.Size(992, 536);
            this.galleryPage.TabIndex = 2;
            this.galleryPage.Text = "{$GALLERY$}";
            this.galleryPage.UseVisualStyleBackColor = true;
            // 
            // galleryTableLayoutPanel
            // 
            this.galleryTableLayoutPanel.ColumnCount = 1;
            this.galleryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.galleryTableLayoutPanel.Controls.Add(this.galleryMenuLayoutPanel, 0, 0);
            this.galleryTableLayoutPanel.Controls.Add(this.galleryListView, 0, 1);
            this.galleryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.galleryTableLayoutPanel.Name = "galleryTableLayoutPanel";
            this.galleryTableLayoutPanel.RowCount = 2;
            this.galleryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.galleryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.galleryTableLayoutPanel.Size = new System.Drawing.Size(992, 536);
            this.galleryTableLayoutPanel.TabIndex = 0;
            // 
            // galleryMenuLayoutPanel
            // 
            this.galleryMenuLayoutPanel.Controls.Add(this.galleryViewPictureBox);
            this.galleryMenuLayoutPanel.Controls.Add(this.showGalleryPictureBox);
            this.galleryMenuLayoutPanel.Controls.Add(this.galleryDeletePictureBox);
            this.galleryMenuLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryMenuLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.galleryMenuLayoutPanel.Name = "galleryMenuLayoutPanel";
            this.galleryMenuLayoutPanel.Size = new System.Drawing.Size(986, 38);
            this.galleryMenuLayoutPanel.TabIndex = 0;
            // 
            // galleryViewPictureBox
            // 
            this.galleryViewPictureBox.Image = global::SAMPLauncherNET.Properties.Resources.view_icon;
            this.galleryViewPictureBox.Location = new System.Drawing.Point(3, 3);
            this.galleryViewPictureBox.Name = "galleryViewPictureBox";
            this.galleryViewPictureBox.Size = new System.Drawing.Size(32, 32);
            this.galleryViewPictureBox.TabIndex = 0;
            this.galleryViewPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.galleryViewPictureBox, "View image");
            this.galleryViewPictureBox.Click += new System.EventHandler(this.galleryViewPictureBox_Click);
            this.galleryViewPictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.galleryViewPictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // showGalleryPictureBox
            // 
            this.showGalleryPictureBox.Image = global::SAMPLauncherNET.Properties.Resources.open_folder_icon;
            this.showGalleryPictureBox.Location = new System.Drawing.Point(41, 3);
            this.showGalleryPictureBox.Name = "showGalleryPictureBox";
            this.showGalleryPictureBox.Size = new System.Drawing.Size(32, 32);
            this.showGalleryPictureBox.TabIndex = 2;
            this.showGalleryPictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.showGalleryPictureBox, "Open gallery folder");
            this.showGalleryPictureBox.Click += new System.EventHandler(this.showGalleryPictureBox_Click);
            this.showGalleryPictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.showGalleryPictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // galleryDeletePictureBox
            // 
            this.galleryDeletePictureBox.Image = global::SAMPLauncherNET.Properties.Resources.delete_icon;
            this.galleryDeletePictureBox.Location = new System.Drawing.Point(79, 3);
            this.galleryDeletePictureBox.Name = "galleryDeletePictureBox";
            this.galleryDeletePictureBox.Size = new System.Drawing.Size(32, 32);
            this.galleryDeletePictureBox.TabIndex = 1;
            this.galleryDeletePictureBox.TabStop = false;
            this.toolTip.SetToolTip(this.galleryDeletePictureBox, "Delete image");
            this.galleryDeletePictureBox.Click += new System.EventHandler(this.galleryDeletePictureBox_Click);
            this.galleryDeletePictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.galleryDeletePictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // galleryListView
            // 
            this.galleryListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.galleryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryListView.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galleryListView.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.galleryListView.LargeImageList = this.galleryImageList;
            this.galleryListView.Location = new System.Drawing.Point(3, 47);
            this.galleryListView.Name = "galleryListView";
            this.galleryListView.Size = new System.Drawing.Size(986, 486);
            this.galleryListView.SmallImageList = this.galleryImageList;
            this.galleryListView.TabIndex = 1;
            this.galleryListView.UseCompatibleStateImageBehavior = false;
            this.galleryListView.DoubleClick += new System.EventHandler(this.galleryListView_DoubleClick);
            this.galleryListView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.galleryListView_KeyUp);
            // 
            // galleryImageList
            // 
            this.galleryImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.galleryImageList.ImageSize = new System.Drawing.Size(256, 256);
            this.galleryImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lastChatlogPage
            // 
            this.lastChatlogPage.Controls.Add(this.lastChatlogTextBox);
            this.lastChatlogPage.Location = new System.Drawing.Point(4, 22);
            this.lastChatlogPage.Name = "lastChatlogPage";
            this.lastChatlogPage.Size = new System.Drawing.Size(992, 536);
            this.lastChatlogPage.TabIndex = 5;
            this.lastChatlogPage.Text = "{$LAST_CHATLOG$}";
            this.lastChatlogPage.UseVisualStyleBackColor = true;
            // 
            // lastChatlogTextBox
            // 
            this.lastChatlogTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lastChatlogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastChatlogTextBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastChatlogTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lastChatlogTextBox.Location = new System.Drawing.Point(0, 0);
            this.lastChatlogTextBox.Multiline = true;
            this.lastChatlogTextBox.Name = "lastChatlogTextBox";
            this.lastChatlogTextBox.ReadOnly = true;
            this.lastChatlogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lastChatlogTextBox.Size = new System.Drawing.Size(992, 536);
            this.lastChatlogTextBox.TabIndex = 0;
            // 
            // savedPositionsPage
            // 
            this.savedPositionsPage.Controls.Add(this.savedPositionsTextBox);
            this.savedPositionsPage.Location = new System.Drawing.Point(4, 22);
            this.savedPositionsPage.Name = "savedPositionsPage";
            this.savedPositionsPage.Size = new System.Drawing.Size(992, 536);
            this.savedPositionsPage.TabIndex = 6;
            this.savedPositionsPage.Text = "{$SAVED_POSITIONS$}";
            this.savedPositionsPage.UseVisualStyleBackColor = true;
            // 
            // savedPositionsTextBox
            // 
            this.savedPositionsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.savedPositionsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savedPositionsTextBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedPositionsTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.savedPositionsTextBox.Location = new System.Drawing.Point(0, 0);
            this.savedPositionsTextBox.Multiline = true;
            this.savedPositionsTextBox.Name = "savedPositionsTextBox";
            this.savedPositionsTextBox.ReadOnly = true;
            this.savedPositionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.savedPositionsTextBox.Size = new System.Drawing.Size(992, 536);
            this.savedPositionsTextBox.TabIndex = 1;
            // 
            // optionsPage
            // 
            this.optionsPage.Controls.Add(this.optionsPanel);
            this.optionsPage.Location = new System.Drawing.Point(4, 22);
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.optionsPage.Size = new System.Drawing.Size(992, 536);
            this.optionsPage.TabIndex = 1;
            this.optionsPage.Text = "{$OPTIONS$}";
            this.optionsPage.UseVisualStyleBackColor = true;
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.optionsPanel.Controls.Add(this.revertConfigButton);
            this.optionsPanel.Controls.Add(this.saveConfigButton);
            this.optionsPanel.Controls.Add(this.fontWeightCheckBox);
            this.optionsPanel.Controls.Add(this.fontFaceSingleLineTextField);
            this.optionsPanel.Controls.Add(this.fontFaceLabel);
            this.optionsPanel.Controls.Add(this.noNametagStatusCheckBox);
            this.optionsPanel.Controls.Add(this.audioProxyOffCheckBox);
            this.optionsPanel.Controls.Add(this.audioMessageOffCheckBox);
            this.optionsPanel.Controls.Add(this.directModeCheckBox);
            this.optionsPanel.Controls.Add(this.multiCoreCheckBox);
            this.optionsPanel.Controls.Add(this.imeCheckBox);
            this.optionsPanel.Controls.Add(this.timestampCheckBox);
            this.optionsPanel.Controls.Add(this.disableHeadMoveCheckBox);
            this.optionsPanel.Controls.Add(this.fpsLimitTrackBar);
            this.optionsPanel.Controls.Add(this.fpsLimitSingleLineTextField);
            this.optionsPanel.Controls.Add(this.fpsLimitLabel);
            this.optionsPanel.Controls.Add(this.pageSizeSingleLineTextField);
            this.optionsPanel.Controls.Add(this.pageSizeLabel);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(3, 3);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(986, 530);
            this.optionsPanel.TabIndex = 0;
            // 
            // revertConfigButton
            // 
            this.revertConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.revertConfigButton.AutoSize = true;
            this.revertConfigButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.revertConfigButton.Depth = 0;
            this.revertConfigButton.Icon = null;
            this.revertConfigButton.Location = new System.Drawing.Point(832, 491);
            this.revertConfigButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.revertConfigButton.Name = "revertConfigButton";
            this.revertConfigButton.Primary = true;
            this.revertConfigButton.Size = new System.Drawing.Size(151, 36);
            this.revertConfigButton.TabIndex = 32;
            this.revertConfigButton.Text = "{$REVERT_CONFIG$}";
            this.revertConfigButton.UseVisualStyleBackColor = true;
            this.revertConfigButton.Click += new System.EventHandler(this.revertConfigButton_Click);
            // 
            // saveConfigButton
            // 
            this.saveConfigButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveConfigButton.AutoSize = true;
            this.saveConfigButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveConfigButton.Depth = 0;
            this.saveConfigButton.Icon = null;
            this.saveConfigButton.Location = new System.Drawing.Point(3, 491);
            this.saveConfigButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveConfigButton.Name = "saveConfigButton";
            this.saveConfigButton.Primary = true;
            this.saveConfigButton.Size = new System.Drawing.Size(80, 36);
            this.saveConfigButton.TabIndex = 31;
            this.saveConfigButton.Text = "{$SAVE$}";
            this.saveConfigButton.UseVisualStyleBackColor = true;
            this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
            // 
            // fontWeightCheckBox
            // 
            this.fontWeightCheckBox.AutoSize = true;
            this.fontWeightCheckBox.Depth = 0;
            this.fontWeightCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.fontWeightCheckBox.Location = new System.Drawing.Point(3, 403);
            this.fontWeightCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.fontWeightCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fontWeightCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fontWeightCheckBox.Name = "fontWeightCheckBox";
            this.fontWeightCheckBox.Ripple = true;
            this.fontWeightCheckBox.Size = new System.Drawing.Size(147, 30);
            this.fontWeightCheckBox.TabIndex = 30;
            this.fontWeightCheckBox.Text = "{$FONT_WEIGHT$}";
            this.toolTip.SetToolTip(this.fontWeightCheckBox, "This option toggles whether your chat font is bold or not.\r\nOFF = BOLD (default) " +
        "and ON = NORMAL.");
            this.fontWeightCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontFaceSingleLineTextField
            // 
            this.fontFaceSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fontFaceSingleLineTextField.Depth = 0;
            this.fontFaceSingleLineTextField.Hint = "...";
            this.fontFaceSingleLineTextField.Location = new System.Drawing.Point(10, 377);
            this.fontFaceSingleLineTextField.MaxLength = 32767;
            this.fontFaceSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.fontFaceSingleLineTextField.Name = "fontFaceSingleLineTextField";
            this.fontFaceSingleLineTextField.PasswordChar = '\0';
            this.fontFaceSingleLineTextField.SelectedText = "";
            this.fontFaceSingleLineTextField.SelectionLength = 0;
            this.fontFaceSingleLineTextField.SelectionStart = 0;
            this.fontFaceSingleLineTextField.Size = new System.Drawing.Size(973, 23);
            this.fontFaceSingleLineTextField.TabIndex = 29;
            this.fontFaceSingleLineTextField.TabStop = false;
            this.toolTip.SetToolTip(this.fontFaceSingleLineTextField, "Allows you to change the font of chat, dialogs and the scoreboard. i.e. fontface=" +
        "\"Comic Sans MS\".\r\nNot officially supported, and may cause problems.");
            this.fontFaceSingleLineTextField.UseSystemPasswordChar = false;
            // 
            // fontFaceLabel
            // 
            this.fontFaceLabel.AutoSize = true;
            this.fontFaceLabel.Depth = 0;
            this.fontFaceLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fontFaceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fontFaceLabel.Location = new System.Drawing.Point(6, 355);
            this.fontFaceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fontFaceLabel.Name = "fontFaceLabel";
            this.fontFaceLabel.Size = new System.Drawing.Size(117, 19);
            this.fontFaceLabel.TabIndex = 28;
            this.fontFaceLabel.Text = "{$FONT_FACE$}";
            this.toolTip.SetToolTip(this.fontFaceLabel, "Allows you to change the font of chat, dialogs and the scoreboard. i.e. fontface=" +
        "\"Comic Sans MS\".\r\nNot officially supported, and may cause problems.");
            // 
            // noNametagStatusCheckBox
            // 
            this.noNametagStatusCheckBox.AutoSize = true;
            this.noNametagStatusCheckBox.Depth = 0;
            this.noNametagStatusCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.noNametagStatusCheckBox.Location = new System.Drawing.Point(3, 325);
            this.noNametagStatusCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.noNametagStatusCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.noNametagStatusCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.noNametagStatusCheckBox.Name = "noNametagStatusCheckBox";
            this.noNametagStatusCheckBox.Ripple = true;
            this.noNametagStatusCheckBox.Size = new System.Drawing.Size(203, 30);
            this.noNametagStatusCheckBox.TabIndex = 27;
            this.noNametagStatusCheckBox.Text = "{$NO_NAMETAG_STATUS$}";
            this.toolTip.SetToolTip(this.noNametagStatusCheckBox, resources.GetString("noNametagStatusCheckBox.ToolTip"));
            this.noNametagStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // audioProxyOffCheckBox
            // 
            this.audioProxyOffCheckBox.AutoSize = true;
            this.audioProxyOffCheckBox.Depth = 0;
            this.audioProxyOffCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.audioProxyOffCheckBox.Location = new System.Drawing.Point(3, 295);
            this.audioProxyOffCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.audioProxyOffCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioProxyOffCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioProxyOffCheckBox.Name = "audioProxyOffCheckBox";
            this.audioProxyOffCheckBox.Ripple = true;
            this.audioProxyOffCheckBox.Size = new System.Drawing.Size(176, 30);
            this.audioProxyOffCheckBox.TabIndex = 26;
            this.audioProxyOffCheckBox.Text = "{$AUDIO_PROXY_OFF$}";
            this.toolTip.SetToolTip(this.audioProxyOffCheckBox, "If this option is set to ON,\r\nand there is a proxy server set in your Windows Int" +
        "ernet Options,\r\nthe proxy will not be used when playing audio streams in SA-MP.");
            this.audioProxyOffCheckBox.UseVisualStyleBackColor = true;
            // 
            // audioMessageOffCheckBox
            // 
            this.audioMessageOffCheckBox.AutoSize = true;
            this.audioMessageOffCheckBox.Depth = 0;
            this.audioMessageOffCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.audioMessageOffCheckBox.Location = new System.Drawing.Point(3, 265);
            this.audioMessageOffCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.audioMessageOffCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioMessageOffCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioMessageOffCheckBox.Name = "audioMessageOffCheckBox";
            this.audioMessageOffCheckBox.Ripple = true;
            this.audioMessageOffCheckBox.Size = new System.Drawing.Size(195, 30);
            this.audioMessageOffCheckBox.TabIndex = 25;
            this.audioMessageOffCheckBox.Text = "{$AUDIO_MESSAGE_OFF$}";
            this.toolTip.SetToolTip(this.audioMessageOffCheckBox, resources.GetString("audioMessageOffCheckBox.ToolTip"));
            this.audioMessageOffCheckBox.UseVisualStyleBackColor = true;
            // 
            // directModeCheckBox
            // 
            this.directModeCheckBox.AutoSize = true;
            this.directModeCheckBox.Depth = 0;
            this.directModeCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.directModeCheckBox.Location = new System.Drawing.Point(3, 235);
            this.directModeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.directModeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.directModeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.directModeCheckBox.Name = "directModeCheckBox";
            this.directModeCheckBox.Ripple = true;
            this.directModeCheckBox.Size = new System.Drawing.Size(146, 30);
            this.directModeCheckBox.TabIndex = 24;
            this.directModeCheckBox.Text = "{$DIRECT_MODE$}";
            this.toolTip.SetToolTip(this.directModeCheckBox, "This allows players with chat text drawing problems to use the slower direct-to-s" +
        "creen text rendering mode.\r\nOFF to disable, ON to enable.");
            this.directModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // multiCoreCheckBox
            // 
            this.multiCoreCheckBox.AutoSize = true;
            this.multiCoreCheckBox.Depth = 0;
            this.multiCoreCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.multiCoreCheckBox.Location = new System.Drawing.Point(3, 205);
            this.multiCoreCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.multiCoreCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.multiCoreCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.multiCoreCheckBox.Name = "multiCoreCheckBox";
            this.multiCoreCheckBox.Ripple = true;
            this.multiCoreCheckBox.Size = new System.Drawing.Size(136, 30);
            this.multiCoreCheckBox.TabIndex = 23;
            this.multiCoreCheckBox.Text = "{$MULTI_CORE$}";
            this.toolTip.SetToolTip(this.multiCoreCheckBox, "Toggle whether the SA-MP client uses multiple CPU cores when running.\r\nDefault is" +
        " ON (DOES use multiple CPU cores). Set to OFF if you experience mouse problems.");
            this.multiCoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // imeCheckBox
            // 
            this.imeCheckBox.AutoSize = true;
            this.imeCheckBox.Depth = 0;
            this.imeCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.imeCheckBox.Location = new System.Drawing.Point(3, 175);
            this.imeCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.imeCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.imeCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.imeCheckBox.Name = "imeCheckBox";
            this.imeCheckBox.Ripple = true;
            this.imeCheckBox.Size = new System.Drawing.Size(78, 30);
            this.imeCheckBox.TabIndex = 22;
            this.imeCheckBox.Text = "{$IME$}";
            this.toolTip.SetToolTip(this.imeCheckBox, "This controls whether the chat window input supports Input Method text editing an" +
        "d language switching.\r\nON enables IME, OFF disables it.");
            this.imeCheckBox.UseVisualStyleBackColor = true;
            // 
            // timestampCheckBox
            // 
            this.timestampCheckBox.AutoSize = true;
            this.timestampCheckBox.Depth = 0;
            this.timestampCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.timestampCheckBox.Location = new System.Drawing.Point(3, 145);
            this.timestampCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.timestampCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.timestampCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.timestampCheckBox.Name = "timestampCheckBox";
            this.timestampCheckBox.Ripple = true;
            this.timestampCheckBox.Size = new System.Drawing.Size(133, 30);
            this.timestampCheckBox.TabIndex = 21;
            this.timestampCheckBox.Text = "{$TIMESTAMP$}";
            this.toolTip.SetToolTip(this.timestampCheckBox, "This allows players to show a local timestamp at the side of chat messages.\r\nON e" +
        "nables timestamps, and OFF disables them.\r\nThis can be toggled in-game using the" +
        " client-side /timestamp command.");
            this.timestampCheckBox.UseVisualStyleBackColor = true;
            // 
            // disableHeadMoveCheckBox
            // 
            this.disableHeadMoveCheckBox.AutoSize = true;
            this.disableHeadMoveCheckBox.Depth = 0;
            this.disableHeadMoveCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.disableHeadMoveCheckBox.Location = new System.Drawing.Point(3, 115);
            this.disableHeadMoveCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.disableHeadMoveCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.disableHeadMoveCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.disableHeadMoveCheckBox.Name = "disableHeadMoveCheckBox";
            this.disableHeadMoveCheckBox.Ripple = true;
            this.disableHeadMoveCheckBox.Size = new System.Drawing.Size(195, 30);
            this.disableHeadMoveCheckBox.TabIndex = 20;
            this.disableHeadMoveCheckBox.Text = "{$DISABLE_HEAD_MOVE$}";
            this.toolTip.SetToolTip(this.disableHeadMoveCheckBox, resources.GetString("disableHeadMoveCheckBox.ToolTip"));
            this.disableHeadMoveCheckBox.UseVisualStyleBackColor = true;
            // 
            // fpsLimitTrackBar
            // 
            this.fpsLimitTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsLimitTrackBar.AutoSize = false;
            this.fpsLimitTrackBar.Location = new System.Drawing.Point(3, 70);
            this.fpsLimitTrackBar.Maximum = 90;
            this.fpsLimitTrackBar.Minimum = 20;
            this.fpsLimitTrackBar.Name = "fpsLimitTrackBar";
            this.fpsLimitTrackBar.Size = new System.Drawing.Size(924, 42);
            this.fpsLimitTrackBar.TabIndex = 19;
            this.fpsLimitTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.toolTip.SetToolTip(this.fpsLimitTrackBar, resources.GetString("fpsLimitTrackBar.ToolTip"));
            this.fpsLimitTrackBar.Value = 50;
            this.fpsLimitTrackBar.ValueChanged += new System.EventHandler(this.fpsLimitTrackBar_ValueChanged);
            // 
            // fpsLimitSingleLineTextField
            // 
            this.fpsLimitSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsLimitSingleLineTextField.Depth = 0;
            this.fpsLimitSingleLineTextField.Hint = "...";
            this.fpsLimitSingleLineTextField.Location = new System.Drawing.Point(933, 89);
            this.fpsLimitSingleLineTextField.MaxLength = 32767;
            this.fpsLimitSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.fpsLimitSingleLineTextField.Name = "fpsLimitSingleLineTextField";
            this.fpsLimitSingleLineTextField.PasswordChar = '\0';
            this.fpsLimitSingleLineTextField.SelectedText = "";
            this.fpsLimitSingleLineTextField.SelectionLength = 0;
            this.fpsLimitSingleLineTextField.SelectionStart = 0;
            this.fpsLimitSingleLineTextField.Size = new System.Drawing.Size(50, 23);
            this.fpsLimitSingleLineTextField.TabIndex = 18;
            this.fpsLimitSingleLineTextField.TabStop = false;
            this.fpsLimitSingleLineTextField.Text = "50";
            this.toolTip.SetToolTip(this.fpsLimitSingleLineTextField, resources.GetString("fpsLimitSingleLineTextField.ToolTip"));
            this.fpsLimitSingleLineTextField.UseSystemPasswordChar = false;
            this.fpsLimitSingleLineTextField.TextChanged += new System.EventHandler(this.fpsLimitSingleLineTextField_TextChanged);
            // 
            // fpsLimitLabel
            // 
            this.fpsLimitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpsLimitLabel.AutoSize = true;
            this.fpsLimitLabel.Depth = 0;
            this.fpsLimitLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fpsLimitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fpsLimitLabel.Location = new System.Drawing.Point(3, 48);
            this.fpsLimitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fpsLimitLabel.Name = "fpsLimitLabel";
            this.fpsLimitLabel.Size = new System.Drawing.Size(106, 19);
            this.fpsLimitLabel.TabIndex = 17;
            this.fpsLimitLabel.Text = "{$FPS_LIMIT$}";
            this.toolTip.SetToolTip(this.fpsLimitLabel, resources.GetString("fpsLimitLabel.ToolTip"));
            // 
            // pageSizeSingleLineTextField
            // 
            this.pageSizeSingleLineTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageSizeSingleLineTextField.Depth = 0;
            this.pageSizeSingleLineTextField.Hint = "...";
            this.pageSizeSingleLineTextField.Location = new System.Drawing.Point(10, 22);
            this.pageSizeSingleLineTextField.MaxLength = 32767;
            this.pageSizeSingleLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.pageSizeSingleLineTextField.Name = "pageSizeSingleLineTextField";
            this.pageSizeSingleLineTextField.PasswordChar = '\0';
            this.pageSizeSingleLineTextField.SelectedText = "";
            this.pageSizeSingleLineTextField.SelectionLength = 0;
            this.pageSizeSingleLineTextField.SelectionStart = 0;
            this.pageSizeSingleLineTextField.Size = new System.Drawing.Size(973, 23);
            this.pageSizeSingleLineTextField.TabIndex = 16;
            this.pageSizeSingleLineTextField.TabStop = false;
            this.pageSizeSingleLineTextField.Text = "10";
            this.toolTip.SetToolTip(this.pageSizeSingleLineTextField, resources.GetString("pageSizeSingleLineTextField.ToolTip"));
            this.pageSizeSingleLineTextField.UseSystemPasswordChar = false;
            this.pageSizeSingleLineTextField.TextChanged += new System.EventHandler(this.pageSizeSingleLineTextField_TextChanged);
            // 
            // pageSizeLabel
            // 
            this.pageSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageSizeLabel.AutoSize = true;
            this.pageSizeLabel.Depth = 0;
            this.pageSizeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pageSizeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pageSizeLabel.Location = new System.Drawing.Point(3, 0);
            this.pageSizeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pageSizeLabel.Name = "pageSizeLabel";
            this.pageSizeLabel.Size = new System.Drawing.Size(111, 19);
            this.pageSizeLabel.TabIndex = 15;
            this.pageSizeLabel.Text = "{$PAGE_SIZE$}";
            this.toolTip.SetToolTip(this.pageSizeLabel, resources.GetString("pageSizeLabel.ToolTip"));
            // 
            // apiPage
            // 
            this.apiPage.Location = new System.Drawing.Point(4, 22);
            this.apiPage.Name = "apiPage";
            this.apiPage.Size = new System.Drawing.Size(992, 536);
            this.apiPage.TabIndex = 3;
            this.apiPage.Text = "{$API$}";
            this.apiPage.UseVisualStyleBackColor = true;
            // 
            // aboutPage
            // 
            this.aboutPage.Location = new System.Drawing.Point(4, 22);
            this.aboutPage.Name = "aboutPage";
            this.aboutPage.Size = new System.Drawing.Size(992, 536);
            this.aboutPage.TabIndex = 4;
            this.aboutPage.Text = "{$ABOUT$}";
            this.aboutPage.UseVisualStyleBackColor = true;
            // 
            // mainTabSelector
            // 
            this.mainTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabSelector.BaseTabControl = this.mainTabControl;
            this.mainTabSelector.Depth = 0;
            this.mainTabSelector.Location = new System.Drawing.Point(0, 64);
            this.mainTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabSelector.Name = "mainTabSelector";
            this.mainTabSelector.Size = new System.Drawing.Size(1010, 48);
            this.mainTabSelector.TabIndex = 18;
            this.mainTabSelector.Text = "materialTabSelector2";
            // 
            // serverListTimer
            // 
            this.serverListTimer.Enabled = true;
            this.serverListTimer.Interval = 500;
            this.serverListTimer.Tick += new System.EventHandler(this.serverListTimer_Tick);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // galleryFileSystemWatcher
            // 
            this.galleryFileSystemWatcher.EnableRaisingEvents = true;
            this.galleryFileSystemWatcher.Filter = "*.png";
            this.galleryFileSystemWatcher.SynchronizingObject = this;
            this.galleryFileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.galleryFileSystemWatcher_GenericChanged);
            this.galleryFileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.galleryFileSystemWatcher_GenericChanged);
            this.galleryFileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.galleryFileSystemWatcher_GenericChanged);
            this.galleryFileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.galleryFileSystemWatcher_Renamed);
            // 
            // textFileSystemWatcher
            // 
            this.textFileSystemWatcher.EnableRaisingEvents = true;
            this.textFileSystemWatcher.Filter = "*.txt";
            this.textFileSystemWatcher.SynchronizingObject = this;
            this.textFileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.textFileSystemWatcher_Changed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1010, 684);
            this.Controls.Add(this.mainTabSelector);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "{$LAUNCHER_TITLE$}";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainTabControl.ResumeLayout(false);
            this.serversPage.ResumeLayout(false);
            this.serversLayoutPanel.ResumeLayout(false);
            this.serversSplitContainer.Panel1.ResumeLayout(false);
            this.serversSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serversSplitContainer)).EndInit();
            this.serversSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serversGridView)).EndInit();
            this.serversContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataTable)).EndInit();
            this.serverInfoSplitContainer.Panel1.ResumeLayout(false);
            this.serverInfoSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverInfoSplitContainer)).EndInit();
            this.serverInfoSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            this.inputFilterLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.selectFlowLayoutPanel.ResumeLayout(false);
            this.selectFlowLayoutPanel.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.filterRadioGroupFlowLayoutPanel.ResumeLayout(false);
            this.filterRadioGroupFlowLayoutPanel.PerformLayout();
            this.footerTableLayoutPanel.ResumeLayout(false);
            this.gitHubProjectLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gitHubProjectPictureBox)).EndInit();
            this.languageLayoutPanel.ResumeLayout(false);
            this.languageLayoutPanel.PerformLayout();
            this.galleryPage.ResumeLayout(false);
            this.galleryTableLayoutPanel.ResumeLayout(false);
            this.galleryMenuLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryViewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showGalleryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDeletePictureBox)).EndInit();
            this.lastChatlogPage.ResumeLayout(false);
            this.lastChatlogPage.PerformLayout();
            this.savedPositionsPage.ResumeLayout(false);
            this.savedPositionsPage.PerformLayout();
            this.optionsPage.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsLimitTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryFileSystemWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFileSystemWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage serversPage;
        private System.Windows.Forms.TabPage optionsPage;
        private MaterialSkin.Controls.MaterialTabSelector mainTabSelector;
        private System.Windows.Forms.TabPage galleryPage;
        private System.Windows.Forms.TabPage apiPage;
        private System.Windows.Forms.TabPage aboutPage;
        private System.Windows.Forms.TableLayoutPanel serversLayoutPanel;
        private System.Windows.Forms.SplitContainer serversSplitContainer;
        private System.Windows.Forms.SplitContainer serverInfoSplitContainer;
        private System.Windows.Forms.DataGridView serversGridView;
        private System.Windows.Forms.Timer serverListTimer;
        private System.Data.DataSet serversDataSet;
        private System.Data.DataTable serversDataTable;
        private System.Data.DataColumn pingDataColumn;
        private System.Data.DataColumn hostnameDataColumn;
        private System.Data.DataColumn playersDataColumn;
        private System.Data.DataColumn maxPlayersDataColumn;
        private System.Data.DataColumn modeDataColumn;
        private System.Data.DataColumn languageDataColumn;
        private System.Data.DataColumn ipAndPortDataColumn;
        private System.Data.DataColumn groupIDDataColumn;
        private System.Data.DataTable playersDataTable;
        private System.Data.DataColumn playerDataColumn;
        private System.Data.DataColumn scoreDataColumn;
        private System.Data.DataTable rulesDataTable;
        private System.Data.DataColumn ruleDataColumn;
        private System.Data.DataColumn valueDataColumn;
        private System.Windows.Forms.BindingSource serversBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource rulesBindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel inputFilterLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPlayersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAndPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel serverCountLabel;
        private MaterialSkin.Controls.MaterialRaisedButton connectButton;
        private MaterialSkin.Controls.MaterialRaisedButton launchSingleplayerButton;
        private MaterialSkin.Controls.MaterialRaisedButton launchDebugModeButton;
        private System.Windows.Forms.TableLayoutPanel footerTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel gitHubProjectLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel languageLayoutPanel;
        private System.Windows.Forms.ComboBox languagesComboBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox gitHubProjectPictureBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField filterSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel serversFilterLabel;
        private MaterialSkin.Controls.MaterialRadioButton filterHostnameRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton filterModeRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton filterLanguageRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton filterIPAndPortRadioButton;
        private System.Windows.Forms.DataGridView playersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView rulesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel galleryTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel galleryMenuLayoutPanel;
        private System.IO.FileSystemWatcher galleryFileSystemWatcher;
        private System.Windows.Forms.PictureBox galleryViewPictureBox;
        private System.Windows.Forms.PictureBox galleryDeletePictureBox;
        private System.Windows.Forms.ImageList galleryImageList;
        private System.Windows.Forms.ListView galleryListView;
        private System.Windows.Forms.PictureBox showGalleryPictureBox;
        private MaterialSkin.Controls.MaterialCheckBox closeWhenLaunchedCheckBox;
        private System.Windows.Forms.FlowLayoutPanel filterRadioGroupFlowLayoutPanel;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.TabPage lastChatlogPage;
        private System.Windows.Forms.TextBox lastChatlogTextBox;
        private System.Windows.Forms.TabPage savedPositionsPage;
        private System.Windows.Forms.TextBox savedPositionsTextBox;
        private System.IO.FileSystemWatcher textFileSystemWatcher;
        private System.Windows.Forms.Panel optionsPanel;
        private MaterialSkin.Controls.MaterialCheckBox noNametagStatusCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox audioProxyOffCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox audioMessageOffCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox directModeCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox multiCoreCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox imeCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox timestampCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox disableHeadMoveCheckBox;
        private System.Windows.Forms.TrackBar fpsLimitTrackBar;
        private MaterialSkin.Controls.MaterialSingleLineTextField fpsLimitSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel fpsLimitLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField pageSizeSingleLineTextField;
        private MaterialSkin.Controls.MaterialLabel pageSizeLabel;
        private MaterialSkin.Controls.MaterialLabel fontFaceLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField fontFaceSingleLineTextField;
        private MaterialSkin.Controls.MaterialCheckBox fontWeightCheckBox;
        private MaterialSkin.Controls.MaterialRaisedButton saveConfigButton;
        private MaterialSkin.Controls.MaterialRaisedButton revertConfigButton;
        private MaterialSkin.Controls.MaterialContextMenuStrip serversContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showExtendedServerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addServerToFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeServerFromFavouritesToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel selectFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialRadioButton showFavouritesRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton showHostedListRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton showMasterListRadioButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectWithRCONToolStripMenuItem;
    }
}