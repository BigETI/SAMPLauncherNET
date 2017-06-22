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
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Favourites", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Hosted list", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Master list", System.Windows.Forms.HorizontalAlignment.Left);
            this.serverListView = new MetroFramework.Controls.MetroListView();
            this.pingColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hostNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerCountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxPlayersColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.languageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ipAndPortColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.languagesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.showFavouritesCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.showHostedListCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.showMasterListCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.serversDataSet = new System.Data.DataSet();
            this.serversTable = new System.Data.DataTable();
            this.favouritesPingColumn = new System.Data.DataColumn();
            this.favouritesHostnameColumn = new System.Data.DataColumn();
            this.favouritesPlayersColumn = new System.Data.DataColumn();
            this.favouritesMaxPlayersColumn = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.testConnectButton = new MetroFramework.Controls.MetroButton();
            this.serverListTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.serversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversTable)).BeginInit();
            this.SuspendLayout();
            // 
            // serverListView
            // 
            this.serverListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.serverListView.AllowSorting = true;
            this.serverListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverListView.BackColor = System.Drawing.SystemColors.Window;
            this.serverListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pingColumnHeader,
            this.hostNameColumnHeader,
            this.playerCountColumnHeader,
            this.maxPlayersColumnHeader,
            this.modeColumnHeader,
            this.languageColumnHeader,
            this.ipAndPortColumnHeader});
            this.serverListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.serverListView.FullRowSelect = true;
            listViewGroup13.Header = "Favourites";
            listViewGroup13.Name = "favouritesListViewGroup";
            listViewGroup14.Header = "Hosted list";
            listViewGroup14.Name = "hostedListListViewGroup";
            listViewGroup15.Header = "Master list";
            listViewGroup15.Name = "masterListListViewGroup";
            this.serverListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15});
            this.serverListView.Location = new System.Drawing.Point(23, 63);
            this.serverListView.Name = "serverListView";
            this.serverListView.OwnerDraw = true;
            this.serverListView.Size = new System.Drawing.Size(733, 400);
            this.serverListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.serverListView.Style = MetroFramework.MetroColorStyle.Orange;
            this.serverListView.TabIndex = 0;
            this.serverListView.UseCompatibleStateImageBehavior = false;
            this.serverListView.UseCustomBackColor = true;
            this.serverListView.UseCustomForeColor = true;
            this.serverListView.UseSelectable = true;
            this.serverListView.UseStyleColors = true;
            this.serverListView.View = System.Windows.Forms.View.Details;
            this.serverListView.Click += new System.EventHandler(this.serverListView_Click);
            // 
            // pingColumnHeader
            // 
            this.pingColumnHeader.Text = "Ping";
            this.pingColumnHeader.Width = 87;
            // 
            // hostNameColumnHeader
            // 
            this.hostNameColumnHeader.Text = "Hostname";
            this.hostNameColumnHeader.Width = 93;
            // 
            // playerCountColumnHeader
            // 
            this.playerCountColumnHeader.Text = "Players";
            this.playerCountColumnHeader.Width = 87;
            // 
            // maxPlayersColumnHeader
            // 
            this.maxPlayersColumnHeader.Text = "Max players";
            this.maxPlayersColumnHeader.Width = 128;
            // 
            // modeColumnHeader
            // 
            this.modeColumnHeader.Text = "Mode";
            this.modeColumnHeader.Width = 86;
            // 
            // languageColumnHeader
            // 
            this.languageColumnHeader.Text = "Language";
            this.languageColumnHeader.Width = 95;
            // 
            // ipAndPortColumnHeader
            // 
            this.ipAndPortColumnHeader.Text = "IP and port";
            this.ipAndPortColumnHeader.Width = 117;
            // 
            // languagesComboBox
            // 
            this.languagesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languagesComboBox.FormattingEnabled = true;
            this.languagesComboBox.ItemHeight = 23;
            this.languagesComboBox.Location = new System.Drawing.Point(635, 579);
            this.languagesComboBox.Name = "languagesComboBox";
            this.languagesComboBox.Size = new System.Drawing.Size(121, 29);
            this.languagesComboBox.TabIndex = 4;
            this.languagesComboBox.UseSelectable = true;
            // 
            // showFavouritesCheckBox
            // 
            this.showFavouritesCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showFavouritesCheckBox.AutoSize = true;
            this.showFavouritesCheckBox.Checked = true;
            this.showFavouritesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showFavouritesCheckBox.Location = new System.Drawing.Point(23, 469);
            this.showFavouritesCheckBox.Name = "showFavouritesCheckBox";
            this.showFavouritesCheckBox.Size = new System.Drawing.Size(148, 15);
            this.showFavouritesCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.showFavouritesCheckBox.TabIndex = 5;
            this.showFavouritesCheckBox.Text = "{$SHOW_FAVOURITES$}";
            this.showFavouritesCheckBox.UseSelectable = true;
            this.showFavouritesCheckBox.CheckedChanged += new System.EventHandler(this.showFavouritesCheckBox_CheckedChanged);
            // 
            // showHostedListCheckBox
            // 
            this.showHostedListCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showHostedListCheckBox.AutoSize = true;
            this.showHostedListCheckBox.Checked = true;
            this.showHostedListCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHostedListCheckBox.Location = new System.Drawing.Point(23, 490);
            this.showHostedListCheckBox.Name = "showHostedListCheckBox";
            this.showHostedListCheckBox.Size = new System.Drawing.Size(155, 15);
            this.showHostedListCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.showHostedListCheckBox.TabIndex = 6;
            this.showHostedListCheckBox.Text = "{$SHOW_HOSTED_LIST$}";
            this.showHostedListCheckBox.UseSelectable = true;
            // 
            // showMasterListCheckBox
            // 
            this.showMasterListCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showMasterListCheckBox.AutoSize = true;
            this.showMasterListCheckBox.Checked = true;
            this.showMasterListCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMasterListCheckBox.Location = new System.Drawing.Point(23, 511);
            this.showMasterListCheckBox.Name = "showMasterListCheckBox";
            this.showMasterListCheckBox.Size = new System.Drawing.Size(155, 15);
            this.showMasterListCheckBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.showMasterListCheckBox.TabIndex = 7;
            this.showMasterListCheckBox.Text = "{$SHOW_MASTER_LIST$}";
            this.showMasterListCheckBox.UseSelectable = true;
            // 
            // serversDataSet
            // 
            this.serversDataSet.DataSetName = "ServersDataSet";
            this.serversDataSet.Locale = new System.Globalization.CultureInfo("");
            this.serversDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.serversTable});
            // 
            // serversTable
            // 
            this.serversTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.favouritesPingColumn,
            this.favouritesHostnameColumn,
            this.favouritesPlayersColumn,
            this.favouritesMaxPlayersColumn,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn1});
            this.serversTable.TableName = "Servers";
            // 
            // favouritesPingColumn
            // 
            this.favouritesPingColumn.ColumnName = "Ping";
            this.favouritesPingColumn.DataType = typeof(uint);
            this.favouritesPingColumn.DefaultValue = ((uint)(0u));
            // 
            // favouritesHostnameColumn
            // 
            this.favouritesHostnameColumn.Caption = "Hostname";
            this.favouritesHostnameColumn.ColumnName = "Hostname";
            this.favouritesHostnameColumn.DefaultValue = "-";
            // 
            // favouritesPlayersColumn
            // 
            this.favouritesPlayersColumn.Caption = "Players";
            this.favouritesPlayersColumn.ColumnName = "Players";
            this.favouritesPlayersColumn.DataType = typeof(uint);
            this.favouritesPlayersColumn.DefaultValue = ((uint)(0u));
            // 
            // favouritesMaxPlayersColumn
            // 
            this.favouritesMaxPlayersColumn.ColumnName = "Max Players";
            this.favouritesMaxPlayersColumn.DataType = typeof(uint);
            this.favouritesMaxPlayersColumn.DefaultValue = ((uint)(0u));
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Column4";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Column5";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Column6";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Group ID";
            this.dataColumn1.DataType = typeof(byte);
            this.dataColumn1.DefaultValue = ((byte)(0));
            // 
            // testConnectButton
            // 
            this.testConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.testConnectButton.Location = new System.Drawing.Point(23, 532);
            this.testConnectButton.Name = "testConnectButton";
            this.testConnectButton.Size = new System.Drawing.Size(75, 23);
            this.testConnectButton.TabIndex = 8;
            this.testConnectButton.Text = "Test connect";
            this.testConnectButton.UseSelectable = true;
            this.testConnectButton.Click += new System.EventHandler(this.testConnectButton_Click);
            // 
            // serverListTimer
            // 
            this.serverListTimer.Enabled = true;
            this.serverListTimer.Interval = 2000;
            this.serverListTimer.Tick += new System.EventHandler(this.serverListTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 631);
            this.Controls.Add(this.testConnectButton);
            this.Controls.Add(this.showMasterListCheckBox);
            this.Controls.Add(this.showHostedListCheckBox);
            this.Controls.Add(this.showFavouritesCheckBox);
            this.Controls.Add(this.languagesComboBox);
            this.Controls.Add(this.serverListView);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "San Andreas Multiplayer Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.serversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView serverListView;
        private System.Windows.Forms.ColumnHeader pingColumnHeader;
        private System.Windows.Forms.ColumnHeader hostNameColumnHeader;
        private System.Windows.Forms.ColumnHeader playerCountColumnHeader;
        private System.Windows.Forms.ColumnHeader maxPlayersColumnHeader;
        private System.Windows.Forms.ColumnHeader modeColumnHeader;
        private System.Windows.Forms.ColumnHeader languageColumnHeader;
        private System.Windows.Forms.ColumnHeader ipAndPortColumnHeader;
        private MetroFramework.Controls.MetroComboBox languagesComboBox;
        private MetroFramework.Controls.MetroCheckBox showFavouritesCheckBox;
        private MetroFramework.Controls.MetroCheckBox showHostedListCheckBox;
        private MetroFramework.Controls.MetroCheckBox showMasterListCheckBox;
        private System.Data.DataSet serversDataSet;
        private System.Data.DataTable serversTable;
        private System.Data.DataColumn favouritesPingColumn;
        private System.Data.DataColumn favouritesHostnameColumn;
        private System.Data.DataColumn favouritesPlayersColumn;
        private System.Data.DataColumn favouritesMaxPlayersColumn;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn1;
        private MetroFramework.Controls.MetroButton testConnectButton;
        private System.Windows.Forms.Timer serverListTimer;
    }
}

