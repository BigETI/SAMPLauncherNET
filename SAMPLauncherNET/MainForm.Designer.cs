namespace SAMPLauncherNET
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.languagesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.serverListTimer = new System.Windows.Forms.Timer(this.components);
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
            this.serversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.serversPanel = new MetroFramework.Controls.MetroPanel();
            this.serversGrid = new MetroFramework.Controls.MetroGrid();
            this.pingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPlayersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPAndPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectWithRCONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.showExtendedServerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addServerToFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeServerFromFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversSplitter = new System.Windows.Forms.Splitter();
            this.serverInfoPanel = new MetroFramework.Controls.MetroPanel();
            this.playersGrid = new MetroFramework.Controls.MetroGrid();
            this.playerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serverInfoSplitter = new System.Windows.Forms.Splitter();
            this.rulesGrid = new MetroFramework.Controls.MetroGrid();
            this.ruleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputPanel = new MetroFramework.Controls.MetroPanel();
            this.selectFilterPanel = new MetroFramework.Controls.MetroPanel();
            this.filterPanel = new MetroFramework.Controls.MetroPanel();
            this.filterRadioPanel = new MetroFramework.Controls.MetroPanel();
            this.filterIPAndPortRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.filterHostnameRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.filterLanguageRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.filterModeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.filterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.selectFilterSplitter = new System.Windows.Forms.Splitter();
            this.selectPanel = new MetroFramework.Controls.MetroPanel();
            this.selectRadioPanel = new MetroFramework.Controls.MetroPanel();
            this.showFavouritesRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.showMasterListRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.showHostedListRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.selectLabel = new MetroFramework.Controls.MetroLabel();
            this.serverCountLabel = new MetroFramework.Controls.MetroLabel();
            this.showLastChatlogLink = new MetroFramework.Controls.MetroLink();
            this.needHelpForumsLink = new MetroFramework.Controls.MetroLink();
            this.showGalleryLink = new MetroFramework.Controls.MetroLink();
            this.optionsLink = new MetroFramework.Controls.MetroLink();
            this.launchSingleplayerModeButton = new MetroFramework.Controls.MetroButton();
            this.launchDebugModeButton = new MetroFramework.Controls.MetroButton();
            this.closeWhenLaunchedCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.connectButton = new MetroFramework.Controls.MetroButton();
            this.gitHubProjectLink = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.serversPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serversGrid)).BeginInit();
            this.serverContextMenu.SuspendLayout();
            this.serverInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            this.inputPanel.SuspendLayout();
            this.selectFilterPanel.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.filterRadioPanel.SuspendLayout();
            this.selectPanel.SuspendLayout();
            this.selectRadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.ItemHeight = 23;
            this.languagesComboBox.Location = new System.Drawing.Point(556, 579);
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.PromptText = "{$SELECT_LANGUAGE$}";
            this.languagesComboBox.Size = new System.Drawing.Size(200, 29);
            this.languagesComboBox.TabIndex = 2;
            this.languagesComboBox.UseSelectable = true;
            this.languagesComboBox.TextChanged += new System.EventHandler(this.languagesComboBox_TextChanged);
            // 
            // serverListTimer
            // 
            this.serverListTimer.Enabled = true;
            this.serverListTimer.Interval = 500;
            this.serverListTimer.Tick += new System.EventHandler(this.serverListTimer_Tick);
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
            this.pingDataColumn.ColumnName = "Ping";
            this.pingDataColumn.DataType = typeof(uint);
            this.pingDataColumn.DefaultValue = ((uint)(0u));
            // 
            // hostnameDataColumn
            // 
            this.hostnameDataColumn.ColumnName = "Hostname";
            this.hostnameDataColumn.DefaultValue = "";
            // 
            // playersDataColumn
            // 
            this.playersDataColumn.ColumnName = "Players";
            this.playersDataColumn.DataType = typeof(ushort);
            this.playersDataColumn.DefaultValue = ((ushort)(0));
            // 
            // maxPlayersDataColumn
            // 
            this.maxPlayersDataColumn.Caption = "Max players";
            this.maxPlayersDataColumn.ColumnName = "Max players";
            this.maxPlayersDataColumn.DataType = typeof(ushort);
            this.maxPlayersDataColumn.DefaultValue = ((ushort)(0));
            // 
            // modeDataColumn
            // 
            this.modeDataColumn.ColumnName = "Mode";
            this.modeDataColumn.DefaultValue = "";
            // 
            // languageDataColumn
            // 
            this.languageDataColumn.ColumnName = "Language";
            this.languageDataColumn.DefaultValue = "";
            // 
            // ipAndPortDataColumn
            // 
            this.ipAndPortDataColumn.Caption = "IP and port";
            this.ipAndPortDataColumn.ColumnName = "IP and port";
            this.ipAndPortDataColumn.DefaultValue = "";
            // 
            // groupIDDataColumn
            // 
            this.groupIDDataColumn.ColumnName = "GroupID";
            this.groupIDDataColumn.DataType = typeof(byte);
            this.groupIDDataColumn.DefaultValue = ((byte)(0));
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
            // serversBindingSource
            // 
            this.serversBindingSource.DataMember = "Servers";
            this.serversBindingSource.DataSource = this.serversDataSet;
            this.serversBindingSource.Filter = "GroupID=0";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.serversPanel);
            this.mainPanel.Controls.Add(this.inputPanel);
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(23, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(733, 510);
            this.mainPanel.Style = MetroFramework.MetroColorStyle.Orange;
            this.mainPanel.TabIndex = 0;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // serversPanel
            // 
            this.serversPanel.Controls.Add(this.serversGrid);
            this.serversPanel.Controls.Add(this.serversSplitter);
            this.serversPanel.Controls.Add(this.serverInfoPanel);
            this.serversPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversPanel.HorizontalScrollbarBarColor = true;
            this.serversPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.serversPanel.HorizontalScrollbarSize = 10;
            this.serversPanel.Location = new System.Drawing.Point(0, 0);
            this.serversPanel.Name = "serversPanel";
            this.serversPanel.Size = new System.Drawing.Size(733, 273);
            this.serversPanel.Style = MetroFramework.MetroColorStyle.Orange;
            this.serversPanel.TabIndex = 0;
            this.serversPanel.VerticalScrollbarBarColor = true;
            this.serversPanel.VerticalScrollbarHighlightOnWheel = false;
            this.serversPanel.VerticalScrollbarSize = 10;
            // 
            // serversGrid
            // 
            this.serversGrid.AllowUserToAddRows = false;
            this.serversGrid.AllowUserToDeleteRows = false;
            this.serversGrid.AllowUserToResizeRows = false;
            this.serversGrid.AutoGenerateColumns = false;
            this.serversGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serversGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serversGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serversGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.serversGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serversGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.serversGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serversGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pingDataGridViewTextBoxColumn,
            this.hostnameDataGridViewTextBoxColumn,
            this.playersDataGridViewTextBoxColumn,
            this.maxPlayersDataGridViewTextBoxColumn,
            this.modeDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.iPAndPortDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn});
            this.serversGrid.ContextMenuStrip = this.serverContextMenu;
            this.serversGrid.DataSource = this.serversBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serversGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.serversGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.serversGrid.EnableHeadersVisualStyles = false;
            this.serversGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.serversGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.serversGrid.Location = new System.Drawing.Point(0, 0);
            this.serversGrid.MultiSelect = false;
            this.serversGrid.Name = "serversGrid";
            this.serversGrid.ReadOnly = true;
            this.serversGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serversGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.serversGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.serversGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serversGrid.Size = new System.Drawing.Size(530, 273);
            this.serversGrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.serversGrid.TabIndex = 0;
            this.serversGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.serversGrid_RowEnter);
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
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            this.groupIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // serverContextMenu
            // 
            this.serverContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.connectWithRCONToolStripMenuItem,
            this.serverToolStripSeparator,
            this.showExtendedServerInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.addServerToFavouritesToolStripMenuItem,
            this.removeServerFromFavouritesToolStripMenuItem});
            this.serverContextMenu.Name = "serverContextMenu";
            this.serverContextMenu.Size = new System.Drawing.Size(321, 148);
            this.serverContextMenu.Style = MetroFramework.MetroColorStyle.Orange;
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
            // serverToolStripSeparator
            // 
            this.serverToolStripSeparator.Name = "serverToolStripSeparator";
            this.serverToolStripSeparator.Size = new System.Drawing.Size(317, 6);
            // 
            // showExtendedServerInformationToolStripMenuItem
            // 
            this.showExtendedServerInformationToolStripMenuItem.Name = "showExtendedServerInformationToolStripMenuItem";
            this.showExtendedServerInformationToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.showExtendedServerInformationToolStripMenuItem.Text = "{$SHOW_EXTENDED_SERVER_INFORMATION$}";
            this.showExtendedServerInformationToolStripMenuItem.Click += new System.EventHandler(this.showExtendedServerInformationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(317, 6);
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
            // serversSplitter
            // 
            this.serversSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.serversSplitter.Location = new System.Drawing.Point(530, 0);
            this.serversSplitter.Name = "serversSplitter";
            this.serversSplitter.Size = new System.Drawing.Size(3, 273);
            this.serversSplitter.TabIndex = 2;
            this.serversSplitter.TabStop = false;
            // 
            // serverInfoPanel
            // 
            this.serverInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverInfoPanel.Controls.Add(this.playersGrid);
            this.serverInfoPanel.Controls.Add(this.serverInfoSplitter);
            this.serverInfoPanel.Controls.Add(this.rulesGrid);
            this.serverInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.serverInfoPanel.HorizontalScrollbarBarColor = true;
            this.serverInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.serverInfoPanel.HorizontalScrollbarSize = 10;
            this.serverInfoPanel.Location = new System.Drawing.Point(533, 0);
            this.serverInfoPanel.Name = "serverInfoPanel";
            this.serverInfoPanel.Size = new System.Drawing.Size(200, 273);
            this.serverInfoPanel.Style = MetroFramework.MetroColorStyle.Orange;
            this.serverInfoPanel.TabIndex = 1;
            this.serverInfoPanel.VerticalScrollbarBarColor = true;
            this.serverInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.serverInfoPanel.VerticalScrollbarSize = 10;
            // 
            // playersGrid
            // 
            this.playersGrid.AllowUserToAddRows = false;
            this.playersGrid.AllowUserToDeleteRows = false;
            this.playersGrid.AllowUserToResizeRows = false;
            this.playersGrid.AutoGenerateColumns = false;
            this.playersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.playersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.playersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.playersGrid.DataSource = this.playersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playersGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.playersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.playersGrid.EnableHeadersVisualStyles = false;
            this.playersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.playersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playersGrid.Location = new System.Drawing.Point(0, 0);
            this.playersGrid.MultiSelect = false;
            this.playersGrid.Name = "playersGrid";
            this.playersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.playersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.playersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playersGrid.Size = new System.Drawing.Size(198, 126);
            this.playersGrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.playersGrid.TabIndex = 0;
            // 
            // playerDataGridViewTextBoxColumn
            // 
            this.playerDataGridViewTextBoxColumn.DataPropertyName = "Player";
            this.playerDataGridViewTextBoxColumn.HeaderText = "Player";
            this.playerDataGridViewTextBoxColumn.Name = "playerDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.serversDataSet;
            // 
            // serverInfoSplitter
            // 
            this.serverInfoSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.serverInfoSplitter.Location = new System.Drawing.Point(0, 126);
            this.serverInfoSplitter.Name = "serverInfoSplitter";
            this.serverInfoSplitter.Size = new System.Drawing.Size(198, 3);
            this.serverInfoSplitter.TabIndex = 2;
            this.serverInfoSplitter.TabStop = false;
            // 
            // rulesGrid
            // 
            this.rulesGrid.AllowUserToAddRows = false;
            this.rulesGrid.AllowUserToDeleteRows = false;
            this.rulesGrid.AllowUserToResizeRows = false;
            this.rulesGrid.AutoGenerateColumns = false;
            this.rulesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rulesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rulesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rulesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.rulesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rulesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.rulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruleDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.rulesGrid.DataSource = this.rulesBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rulesGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.rulesGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rulesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rulesGrid.EnableHeadersVisualStyles = false;
            this.rulesGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rulesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rulesGrid.Location = new System.Drawing.Point(0, 129);
            this.rulesGrid.MultiSelect = false;
            this.rulesGrid.Name = "rulesGrid";
            this.rulesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rulesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.rulesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesGrid.Size = new System.Drawing.Size(198, 142);
            this.rulesGrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.rulesGrid.TabIndex = 1;
            // 
            // ruleDataGridViewTextBoxColumn
            // 
            this.ruleDataGridViewTextBoxColumn.DataPropertyName = "Rule";
            this.ruleDataGridViewTextBoxColumn.HeaderText = "Rule";
            this.ruleDataGridViewTextBoxColumn.Name = "ruleDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // rulesBindingSource
            // 
            this.rulesBindingSource.DataMember = "Rules";
            this.rulesBindingSource.DataSource = this.serversDataSet;
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.selectFilterPanel);
            this.inputPanel.Controls.Add(this.serverCountLabel);
            this.inputPanel.Controls.Add(this.showLastChatlogLink);
            this.inputPanel.Controls.Add(this.needHelpForumsLink);
            this.inputPanel.Controls.Add(this.showGalleryLink);
            this.inputPanel.Controls.Add(this.optionsLink);
            this.inputPanel.Controls.Add(this.launchSingleplayerModeButton);
            this.inputPanel.Controls.Add(this.launchDebugModeButton);
            this.inputPanel.Controls.Add(this.closeWhenLaunchedCheckBox);
            this.inputPanel.Controls.Add(this.connectButton);
            this.inputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputPanel.HorizontalScrollbarBarColor = true;
            this.inputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.inputPanel.HorizontalScrollbarSize = 10;
            this.inputPanel.Location = new System.Drawing.Point(0, 273);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(733, 237);
            this.inputPanel.Style = MetroFramework.MetroColorStyle.Orange;
            this.inputPanel.TabIndex = 1;
            this.inputPanel.VerticalScrollbarBarColor = true;
            this.inputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.inputPanel.VerticalScrollbarSize = 10;
            // 
            // selectFilterPanel
            // 
            this.selectFilterPanel.Controls.Add(this.filterPanel);
            this.selectFilterPanel.Controls.Add(this.selectFilterSplitter);
            this.selectFilterPanel.Controls.Add(this.selectPanel);
            this.selectFilterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectFilterPanel.HorizontalScrollbarBarColor = true;
            this.selectFilterPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.selectFilterPanel.HorizontalScrollbarSize = 10;
            this.selectFilterPanel.Location = new System.Drawing.Point(0, 0);
            this.selectFilterPanel.Name = "selectFilterPanel";
            this.selectFilterPanel.Size = new System.Drawing.Size(731, 109);
            this.selectFilterPanel.TabIndex = 0;
            this.selectFilterPanel.VerticalScrollbarBarColor = true;
            this.selectFilterPanel.VerticalScrollbarHighlightOnWheel = false;
            this.selectFilterPanel.VerticalScrollbarSize = 10;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.filterRadioPanel);
            this.filterPanel.Controls.Add(this.filterTextBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.HorizontalScrollbarBarColor = true;
            this.filterPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.filterPanel.HorizontalScrollbarSize = 10;
            this.filterPanel.Location = new System.Drawing.Point(305, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(426, 109);
            this.filterPanel.TabIndex = 10;
            this.filterPanel.VerticalScrollbarBarColor = true;
            this.filterPanel.VerticalScrollbarHighlightOnWheel = false;
            this.filterPanel.VerticalScrollbarSize = 10;
            // 
            // filterRadioPanel
            // 
            this.filterRadioPanel.Controls.Add(this.filterIPAndPortRadioButton);
            this.filterRadioPanel.Controls.Add(this.filterHostnameRadioButton);
            this.filterRadioPanel.Controls.Add(this.filterLanguageRadioButton);
            this.filterRadioPanel.Controls.Add(this.filterModeRadioButton);
            this.filterRadioPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterRadioPanel.HorizontalScrollbarBarColor = true;
            this.filterRadioPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.filterRadioPanel.HorizontalScrollbarSize = 10;
            this.filterRadioPanel.Location = new System.Drawing.Point(0, 23);
            this.filterRadioPanel.Name = "filterRadioPanel";
            this.filterRadioPanel.Size = new System.Drawing.Size(426, 86);
            this.filterRadioPanel.TabIndex = 8;
            this.filterRadioPanel.VerticalScrollbarBarColor = true;
            this.filterRadioPanel.VerticalScrollbarHighlightOnWheel = false;
            this.filterRadioPanel.VerticalScrollbarSize = 10;
            // 
            // filterIPAndPortRadioButton
            // 
            this.filterIPAndPortRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterIPAndPortRadioButton.Location = new System.Drawing.Point(4, 66);
            this.filterIPAndPortRadioButton.Name = "filterIPAndPortRadioButton";
            this.filterIPAndPortRadioButton.Size = new System.Drawing.Size(420, 15);
            this.filterIPAndPortRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.filterIPAndPortRadioButton.TabIndex = 4;
            this.filterIPAndPortRadioButton.Text = "{$FILTER_IP_AND_PORT$}";
            this.filterIPAndPortRadioButton.UseSelectable = true;
            this.filterIPAndPortRadioButton.CheckedChanged += new System.EventHandler(this.filterGenericRadioButton_CheckedChanged);
            // 
            // filterHostnameRadioButton
            // 
            this.filterHostnameRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterHostnameRadioButton.Checked = true;
            this.filterHostnameRadioButton.Location = new System.Drawing.Point(3, 3);
            this.filterHostnameRadioButton.Name = "filterHostnameRadioButton";
            this.filterHostnameRadioButton.Size = new System.Drawing.Size(420, 15);
            this.filterHostnameRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.filterHostnameRadioButton.TabIndex = 1;
            this.filterHostnameRadioButton.TabStop = true;
            this.filterHostnameRadioButton.Text = "{$FILTER_HOSTNAME$}";
            this.filterHostnameRadioButton.UseSelectable = true;
            this.filterHostnameRadioButton.CheckedChanged += new System.EventHandler(this.filterGenericRadioButton_CheckedChanged);
            // 
            // filterLanguageRadioButton
            // 
            this.filterLanguageRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterLanguageRadioButton.Location = new System.Drawing.Point(3, 45);
            this.filterLanguageRadioButton.Name = "filterLanguageRadioButton";
            this.filterLanguageRadioButton.Size = new System.Drawing.Size(420, 15);
            this.filterLanguageRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.filterLanguageRadioButton.TabIndex = 3;
            this.filterLanguageRadioButton.Text = "{$FILTER_LANGUAGE$}";
            this.filterLanguageRadioButton.UseSelectable = true;
            this.filterLanguageRadioButton.CheckedChanged += new System.EventHandler(this.filterGenericRadioButton_CheckedChanged);
            // 
            // filterModeRadioButton
            // 
            this.filterModeRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterModeRadioButton.Location = new System.Drawing.Point(3, 24);
            this.filterModeRadioButton.Name = "filterModeRadioButton";
            this.filterModeRadioButton.Size = new System.Drawing.Size(420, 15);
            this.filterModeRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.filterModeRadioButton.TabIndex = 2;
            this.filterModeRadioButton.Text = "{$FILTER_MODE$}";
            this.filterModeRadioButton.UseSelectable = true;
            this.filterModeRadioButton.CheckedChanged += new System.EventHandler(this.filterGenericRadioButton_CheckedChanged);
            // 
            // filterTextBox
            // 
            // 
            // 
            // 
            this.filterTextBox.CustomButton.Image = null;
            this.filterTextBox.CustomButton.Location = new System.Drawing.Point(404, 1);
            this.filterTextBox.CustomButton.Name = "";
            this.filterTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.filterTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filterTextBox.CustomButton.TabIndex = 1;
            this.filterTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filterTextBox.CustomButton.UseSelectable = true;
            this.filterTextBox.CustomButton.Visible = false;
            this.filterTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterTextBox.Lines = new string[0];
            this.filterTextBox.Location = new System.Drawing.Point(0, 0);
            this.filterTextBox.MaxLength = 32767;
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.PasswordChar = '\0';
            this.filterTextBox.PromptText = "{$INSERT_FILTER_HERE$}";
            this.filterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filterTextBox.SelectedText = "";
            this.filterTextBox.SelectionLength = 0;
            this.filterTextBox.SelectionStart = 0;
            this.filterTextBox.ShortcutsEnabled = true;
            this.filterTextBox.Size = new System.Drawing.Size(426, 23);
            this.filterTextBox.TabIndex = 5;
            this.filterTextBox.UseSelectable = true;
            this.filterTextBox.WaterMark = "{$INSERT_FILTER_HERE$}";
            this.filterTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filterTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // selectFilterSplitter
            // 
            this.selectFilterSplitter.Location = new System.Drawing.Point(302, 0);
            this.selectFilterSplitter.Name = "selectFilterSplitter";
            this.selectFilterSplitter.Size = new System.Drawing.Size(3, 109);
            this.selectFilterSplitter.TabIndex = 9;
            this.selectFilterSplitter.TabStop = false;
            // 
            // selectPanel
            // 
            this.selectPanel.Controls.Add(this.selectRadioPanel);
            this.selectPanel.Controls.Add(this.selectLabel);
            this.selectPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectPanel.HorizontalScrollbarBarColor = true;
            this.selectPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.selectPanel.HorizontalScrollbarSize = 10;
            this.selectPanel.Location = new System.Drawing.Point(0, 0);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(302, 109);
            this.selectPanel.TabIndex = 8;
            this.selectPanel.VerticalScrollbarBarColor = true;
            this.selectPanel.VerticalScrollbarHighlightOnWheel = false;
            this.selectPanel.VerticalScrollbarSize = 10;
            // 
            // selectRadioPanel
            // 
            this.selectRadioPanel.Controls.Add(this.showFavouritesRadioButton);
            this.selectRadioPanel.Controls.Add(this.showMasterListRadioButton);
            this.selectRadioPanel.Controls.Add(this.showHostedListRadioButton);
            this.selectRadioPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectRadioPanel.HorizontalScrollbarBarColor = true;
            this.selectRadioPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.selectRadioPanel.HorizontalScrollbarSize = 10;
            this.selectRadioPanel.Location = new System.Drawing.Point(0, 23);
            this.selectRadioPanel.Name = "selectRadioPanel";
            this.selectRadioPanel.Size = new System.Drawing.Size(302, 65);
            this.selectRadioPanel.TabIndex = 7;
            this.selectRadioPanel.VerticalScrollbarBarColor = true;
            this.selectRadioPanel.VerticalScrollbarHighlightOnWheel = false;
            this.selectRadioPanel.VerticalScrollbarSize = 10;
            // 
            // showFavouritesRadioButton
            // 
            this.showFavouritesRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showFavouritesRadioButton.Checked = true;
            this.showFavouritesRadioButton.Location = new System.Drawing.Point(3, 3);
            this.showFavouritesRadioButton.Name = "showFavouritesRadioButton";
            this.showFavouritesRadioButton.Size = new System.Drawing.Size(296, 15);
            this.showFavouritesRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.showFavouritesRadioButton.TabIndex = 1;
            this.showFavouritesRadioButton.TabStop = true;
            this.showFavouritesRadioButton.Text = "{$SHOW_FAVOURITES$}";
            this.showFavouritesRadioButton.UseSelectable = true;
            this.showFavouritesRadioButton.CheckedChanged += new System.EventHandler(this.selectGenericListRadioButton_CheckedChanged);
            // 
            // showMasterListRadioButton
            // 
            this.showMasterListRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showMasterListRadioButton.Location = new System.Drawing.Point(3, 45);
            this.showMasterListRadioButton.Name = "showMasterListRadioButton";
            this.showMasterListRadioButton.Size = new System.Drawing.Size(296, 15);
            this.showMasterListRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.showMasterListRadioButton.TabIndex = 3;
            this.showMasterListRadioButton.Text = "{$SHOW_MASTER_LIST$}";
            this.showMasterListRadioButton.UseSelectable = true;
            this.showMasterListRadioButton.CheckedChanged += new System.EventHandler(this.selectGenericListRadioButton_CheckedChanged);
            // 
            // showHostedListRadioButton
            // 
            this.showHostedListRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showHostedListRadioButton.Location = new System.Drawing.Point(3, 24);
            this.showHostedListRadioButton.Name = "showHostedListRadioButton";
            this.showHostedListRadioButton.Size = new System.Drawing.Size(296, 15);
            this.showHostedListRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.showHostedListRadioButton.TabIndex = 2;
            this.showHostedListRadioButton.Text = "{$SHOW_HOSTED_LIST$}";
            this.showHostedListRadioButton.UseSelectable = true;
            this.showHostedListRadioButton.CheckedChanged += new System.EventHandler(this.selectGenericListRadioButton_CheckedChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectLabel.Location = new System.Drawing.Point(0, 0);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(302, 23);
            this.selectLabel.TabIndex = 6;
            this.selectLabel.Text = "{$SELECT_SERVER_LIST$}";
            // 
            // serverCountLabel
            // 
            this.serverCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverCountLabel.Location = new System.Drawing.Point(159, 180);
            this.serverCountLabel.Name = "serverCountLabel";
            this.serverCountLabel.Size = new System.Drawing.Size(363, 23);
            this.serverCountLabel.TabIndex = 8;
            this.serverCountLabel.Text = "{$SERVERS$}";
            // 
            // showLastChatlogLink
            // 
            this.showLastChatlogLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showLastChatlogLink.Location = new System.Drawing.Point(3, 157);
            this.showLastChatlogLink.Name = "showLastChatlogLink";
            this.showLastChatlogLink.Size = new System.Drawing.Size(522, 15);
            this.showLastChatlogLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.showLastChatlogLink.TabIndex = 4;
            this.showLastChatlogLink.Text = "{$SHOW_LAST_CHATLOG$}";
            this.showLastChatlogLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showLastChatlogLink.UseSelectable = true;
            this.showLastChatlogLink.Click += new System.EventHandler(this.showLastChatLogLink_Click);
            // 
            // needHelpForumsLink
            // 
            this.needHelpForumsLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.needHelpForumsLink.Location = new System.Drawing.Point(159, 217);
            this.needHelpForumsLink.Name = "needHelpForumsLink";
            this.needHelpForumsLink.Size = new System.Drawing.Size(363, 15);
            this.needHelpForumsLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.needHelpForumsLink.TabIndex = 9;
            this.needHelpForumsLink.Text = "{$NEED_HELP_FORUMS$}";
            this.needHelpForumsLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.needHelpForumsLink.UseSelectable = true;
            this.needHelpForumsLink.Click += new System.EventHandler(this.needHelpForumsLink_Click);
            // 
            // showGalleryLink
            // 
            this.showGalleryLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showGalleryLink.Location = new System.Drawing.Point(3, 136);
            this.showGalleryLink.Name = "showGalleryLink";
            this.showGalleryLink.Size = new System.Drawing.Size(725, 15);
            this.showGalleryLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.showGalleryLink.TabIndex = 3;
            this.showGalleryLink.Text = "{$SHOW_GALLERY$}";
            this.showGalleryLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showGalleryLink.UseSelectable = true;
            this.showGalleryLink.Click += new System.EventHandler(this.showGalleryLink_Click);
            // 
            // optionsLink
            // 
            this.optionsLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsLink.Location = new System.Drawing.Point(3, 115);
            this.optionsLink.Name = "optionsLink";
            this.optionsLink.Size = new System.Drawing.Size(725, 15);
            this.optionsLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.optionsLink.TabIndex = 2;
            this.optionsLink.Text = "{$OPTIONS$}";
            this.optionsLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.optionsLink.UseSelectable = true;
            this.optionsLink.Click += new System.EventHandler(this.optionsLink_Click);
            // 
            // launchSingleplayerModeButton
            // 
            this.launchSingleplayerModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.launchSingleplayerModeButton.Location = new System.Drawing.Point(528, 180);
            this.launchSingleplayerModeButton.Name = "launchSingleplayerModeButton";
            this.launchSingleplayerModeButton.Size = new System.Drawing.Size(200, 23);
            this.launchSingleplayerModeButton.TabIndex = 6;
            this.launchSingleplayerModeButton.Text = "{$LAUNCH_SINGLEPLAYER_MODE$}";
            this.launchSingleplayerModeButton.UseSelectable = true;
            this.launchSingleplayerModeButton.Click += new System.EventHandler(this.launchSingleplayerModeButton_Click);
            // 
            // launchDebugModeButton
            // 
            this.launchDebugModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.launchDebugModeButton.Location = new System.Drawing.Point(528, 209);
            this.launchDebugModeButton.Name = "launchDebugModeButton";
            this.launchDebugModeButton.Size = new System.Drawing.Size(200, 23);
            this.launchDebugModeButton.TabIndex = 7;
            this.launchDebugModeButton.Text = "{$LAUNCH_DEBUG_MODE$}";
            this.launchDebugModeButton.UseSelectable = true;
            this.launchDebugModeButton.Click += new System.EventHandler(this.launchDebugModeButton_Click);
            // 
            // closeWhenLaunchedCheckBox
            // 
            this.closeWhenLaunchedCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeWhenLaunchedCheckBox.AutoSize = true;
            this.closeWhenLaunchedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeWhenLaunchedCheckBox.Checked = true;
            this.closeWhenLaunchedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.closeWhenLaunchedCheckBox.Location = new System.Drawing.Point(543, 157);
            this.closeWhenLaunchedCheckBox.Name = "closeWhenLaunchedCheckBox";
            this.closeWhenLaunchedCheckBox.Size = new System.Drawing.Size(185, 15);
            this.closeWhenLaunchedCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.closeWhenLaunchedCheckBox.TabIndex = 5;
            this.closeWhenLaunchedCheckBox.Text = "{$CLOSE_WHEN_LAUNCHED$}";
            this.closeWhenLaunchedCheckBox.UseSelectable = true;
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.connectButton.Location = new System.Drawing.Point(3, 180);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(150, 52);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "{$CONNECT$}";
            this.connectButton.UseSelectable = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // gitHubProjectLink
            // 
            this.gitHubProjectLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gitHubProjectLink.Location = new System.Drawing.Point(23, 579);
            this.gitHubProjectLink.Name = "gitHubProjectLink";
            this.gitHubProjectLink.Size = new System.Drawing.Size(527, 15);
            this.gitHubProjectLink.Style = MetroFramework.MetroColorStyle.Orange;
            this.gitHubProjectLink.TabIndex = 1;
            this.gitHubProjectLink.Text = "{$GITHUB_PROJECT$}";
            this.gitHubProjectLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gitHubProjectLink.UseSelectable = true;
            this.gitHubProjectLink.Click += new System.EventHandler(this.gitHubProjectLink_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 631);
            this.Controls.Add(this.gitHubProjectLink);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.languagesComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "{$LAUNCHER_TITLE$}";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.serversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversBindingSource)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.serversPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serversGrid)).EndInit();
            this.serverContextMenu.ResumeLayout(false);
            this.serverInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.selectFilterPanel.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterRadioPanel.ResumeLayout(false);
            this.selectPanel.ResumeLayout(false);
            this.selectRadioPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox languagesComboBox;
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
        private System.Windows.Forms.BindingSource serversBindingSource;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroPanel inputPanel;
        private MetroFramework.Controls.MetroButton connectButton;
        private System.Data.DataColumn groupIDDataColumn;
        private System.Data.DataTable playersDataTable;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Data.DataColumn playerDataColumn;
        private System.Data.DataColumn scoreDataColumn;
        private System.Data.DataTable rulesDataTable;
        private System.Data.DataColumn ruleDataColumn;
        private System.Data.DataColumn valueDataColumn;
        private System.Windows.Forms.BindingSource rulesBindingSource;
        private MetroFramework.Controls.MetroPanel serversPanel;
        private MetroFramework.Controls.MetroGrid serversGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPlayersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPAndPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Splitter serversSplitter;
        private MetroFramework.Controls.MetroPanel serverInfoPanel;
        private System.Windows.Forms.Splitter serverInfoSplitter;
        private MetroFramework.Controls.MetroGrid rulesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroGrid playersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroCheckBox closeWhenLaunchedCheckBox;
        private MetroFramework.Controls.MetroButton launchDebugModeButton;
        private MetroFramework.Controls.MetroButton launchSingleplayerModeButton;
        private MetroFramework.Controls.MetroLink needHelpForumsLink;
        private MetroFramework.Controls.MetroLink showGalleryLink;
        private MetroFramework.Controls.MetroLink optionsLink;
        private MetroFramework.Controls.MetroLink gitHubProjectLink;
        private MetroFramework.Controls.MetroLink showLastChatlogLink;
        private MetroFramework.Controls.MetroLabel serverCountLabel;
        private MetroFramework.Controls.MetroContextMenu serverContextMenu;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectWithRCONToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator serverToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem showExtendedServerInformationToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel selectFilterPanel;
        private MetroFramework.Controls.MetroTextBox filterTextBox;
        private MetroFramework.Controls.MetroLabel selectLabel;
        private MetroFramework.Controls.MetroPanel selectPanel;
        private MetroFramework.Controls.MetroPanel selectRadioPanel;
        private MetroFramework.Controls.MetroRadioButton showFavouritesRadioButton;
        private MetroFramework.Controls.MetroRadioButton showMasterListRadioButton;
        private MetroFramework.Controls.MetroRadioButton showHostedListRadioButton;
        private MetroFramework.Controls.MetroPanel filterPanel;
        private MetroFramework.Controls.MetroPanel filterRadioPanel;
        private MetroFramework.Controls.MetroRadioButton filterIPAndPortRadioButton;
        private MetroFramework.Controls.MetroRadioButton filterHostnameRadioButton;
        private MetroFramework.Controls.MetroRadioButton filterLanguageRadioButton;
        private MetroFramework.Controls.MetroRadioButton filterModeRadioButton;
        private System.Windows.Forms.Splitter selectFilterSplitter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addServerToFavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeServerFromFavouritesToolStripMenuItem;
    }
}

