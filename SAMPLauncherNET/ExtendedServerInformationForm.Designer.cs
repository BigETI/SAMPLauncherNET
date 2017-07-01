namespace SAMPLauncherNET
{
    partial class ExtendedServerInformationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.informationSplitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hostnameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.playersLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gamemodeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.languageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ipAndPortLabel = new MaterialSkin.Controls.MaterialLabel();
            this.pingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.serverSplitContainer = new System.Windows.Forms.SplitContainer();
            this.playersGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serversDataSet = new System.Data.DataSet();
            this.playersDataTable = new System.Data.DataTable();
            this.playerDataColumn = new System.Data.DataColumn();
            this.scoreDataColumn = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.rulesDataTable = new System.Data.DataTable();
            this.ruleDataColumn = new System.Data.DataColumn();
            this.valueDataColumn = new System.Data.DataColumn();
            this.rulesGridView = new System.Windows.Forms.DataGridView();
            this.ruleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationSplitContainer)).BeginInit();
            this.informationSplitContainer.Panel1.SuspendLayout();
            this.informationSplitContainer.Panel2.SuspendLayout();
            this.informationSplitContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverSplitContainer)).BeginInit();
            this.serverSplitContainer.Panel1.SuspendLayout();
            this.serverSplitContainer.Panel2.SuspendLayout();
            this.serverSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.pingChart, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.informationSplitContainer, 0, 0);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(12, 69);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(753, 444);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // pingChart
            // 
            this.pingChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pingChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.pingChart.ChartAreas.Add(chartArea1);
            this.pingChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.pingChart.Legends.Add(legend1);
            this.pingChart.Location = new System.Drawing.Point(3, 297);
            this.pingChart.Name = "pingChart";
            this.pingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.pingChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.MediumTurquoise};
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Ping";
            series1.YValuesPerPoint = 6;
            this.pingChart.Series.Add(series1);
            this.pingChart.Size = new System.Drawing.Size(747, 144);
            this.pingChart.TabIndex = 8;
            // 
            // informationSplitContainer
            // 
            this.informationSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informationSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.informationSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.informationSplitContainer.Name = "informationSplitContainer";
            // 
            // informationSplitContainer.Panel1
            // 
            this.informationSplitContainer.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // informationSplitContainer.Panel2
            // 
            this.informationSplitContainer.Panel2.Controls.Add(this.serverSplitContainer);
            this.informationSplitContainer.Size = new System.Drawing.Size(747, 288);
            this.informationSplitContainer.SplitterDistance = 424;
            this.informationSplitContainer.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.hostnameLabel);
            this.flowLayoutPanel1.Controls.Add(this.playersLabel);
            this.flowLayoutPanel1.Controls.Add(this.gamemodeLabel);
            this.flowLayoutPanel1.Controls.Add(this.languageLabel);
            this.flowLayoutPanel1.Controls.Add(this.ipAndPortLabel);
            this.flowLayoutPanel1.Controls.Add(this.pingLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(424, 288);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Depth = 0;
            this.hostnameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.hostnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hostnameLabel.Location = new System.Drawing.Point(3, 0);
            this.hostnameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(117, 19);
            this.hostnameLabel.TabIndex = 0;
            this.hostnameLabel.Text = "{$HOSTNAME$}";
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Depth = 0;
            this.playersLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.playersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playersLabel.Location = new System.Drawing.Point(3, 19);
            this.playersLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(98, 19);
            this.playersLabel.TabIndex = 1;
            this.playersLabel.Text = "{$PLAYERS$}";
            // 
            // gamemodeLabel
            // 
            this.gamemodeLabel.AutoSize = true;
            this.gamemodeLabel.Depth = 0;
            this.gamemodeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.gamemodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gamemodeLabel.Location = new System.Drawing.Point(3, 38);
            this.gamemodeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.gamemodeLabel.Name = "gamemodeLabel";
            this.gamemodeLabel.Size = new System.Drawing.Size(119, 19);
            this.gamemodeLabel.TabIndex = 2;
            this.gamemodeLabel.Text = "{$GAMEMODE$}";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Depth = 0;
            this.languageLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.languageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.languageLabel.Location = new System.Drawing.Point(3, 57);
            this.languageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(113, 19);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "{$LANGUAGE$}";
            // 
            // ipAndPortLabel
            // 
            this.ipAndPortLabel.AutoSize = true;
            this.ipAndPortLabel.Depth = 0;
            this.ipAndPortLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.ipAndPortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ipAndPortLabel.Location = new System.Drawing.Point(3, 76);
            this.ipAndPortLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ipAndPortLabel.Name = "ipAndPortLabel";
            this.ipAndPortLabel.Size = new System.Drawing.Size(130, 19);
            this.ipAndPortLabel.TabIndex = 4;
            this.ipAndPortLabel.Text = "{$IP_AND_PORT$}";
            // 
            // pingLabel
            // 
            this.pingLabel.AutoSize = true;
            this.pingLabel.Depth = 0;
            this.pingLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.pingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pingLabel.Location = new System.Drawing.Point(3, 95);
            this.pingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(69, 19);
            this.pingLabel.TabIndex = 5;
            this.pingLabel.Text = "{$PING$}";
            // 
            // serverSplitContainer
            // 
            this.serverSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.serverSplitContainer.Name = "serverSplitContainer";
            this.serverSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // serverSplitContainer.Panel1
            // 
            this.serverSplitContainer.Panel1.Controls.Add(this.playersGridView);
            // 
            // serverSplitContainer.Panel2
            // 
            this.serverSplitContainer.Panel2.Controls.Add(this.rulesGridView);
            this.serverSplitContainer.Size = new System.Drawing.Size(319, 288);
            this.serverSplitContainer.SplitterDistance = 175;
            this.serverSplitContainer.TabIndex = 0;
            // 
            // playersGridView
            // 
            this.playersGridView.AllowUserToAddRows = false;
            this.playersGridView.AllowUserToDeleteRows = false;
            this.playersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(155)))), ((int)(((byte)(209)))));
            this.playersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.playersGridView.AutoGenerateColumns = false;
            this.playersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.playersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.playersGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.playersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.playersGridView.ColumnHeadersHeight = 32;
            this.playersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.playersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.playerDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.pingDataGridViewTextBoxColumn});
            this.playersGridView.DataSource = this.playersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playersGridView.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.playersGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.playersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playersGridView.Size = new System.Drawing.Size(319, 175);
            this.playersGridView.TabIndex = 2;
            this.playersGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.genericGridView_DataError);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // pingDataGridViewTextBoxColumn
            // 
            this.pingDataGridViewTextBoxColumn.DataPropertyName = "Ping";
            this.pingDataGridViewTextBoxColumn.HeaderText = "Ping";
            this.pingDataGridViewTextBoxColumn.Name = "pingDataGridViewTextBoxColumn";
            this.pingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.serversDataSet;
            // 
            // serversDataSet
            // 
            this.serversDataSet.DataSetName = "serversDataSet";
            this.serversDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.playersDataTable,
            this.rulesDataTable});
            // 
            // playersDataTable
            // 
            this.playersDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.playerDataColumn,
            this.scoreDataColumn,
            this.dataColumn1,
            this.dataColumn2});
            this.playersDataTable.TableName = "Players";
            // 
            // playerDataColumn
            // 
            this.playerDataColumn.ColumnName = "ID";
            this.playerDataColumn.DataType = typeof(byte);
            this.playerDataColumn.DefaultValue = ((byte)(0));
            // 
            // scoreDataColumn
            // 
            this.scoreDataColumn.ColumnName = "Player";
            this.scoreDataColumn.DefaultValue = "";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Score";
            this.dataColumn1.DataType = typeof(int);
            this.dataColumn1.DefaultValue = 0;
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Ping";
            this.dataColumn2.DataType = typeof(uint);
            this.dataColumn2.DefaultValue = ((uint)(0u));
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
            // rulesGridView
            // 
            this.rulesGridView.AllowUserToAddRows = false;
            this.rulesGridView.AllowUserToDeleteRows = false;
            this.rulesGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(155)))), ((int)(((byte)(209)))));
            this.rulesGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.rulesGridView.AutoGenerateColumns = false;
            this.rulesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rulesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rulesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rulesGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.rulesGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.rulesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rulesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.rulesGridView.ColumnHeadersHeight = 32;
            this.rulesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rulesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruleDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.rulesGridView.DataSource = this.rulesBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(200)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rulesGridView.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.rulesGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.rulesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesGridView.Size = new System.Drawing.Size(319, 109);
            this.rulesGridView.TabIndex = 2;
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
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 500;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // ExtendedServerInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(777, 525);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "ExtendedServerInformationForm";
            this.Text = "{$EXTENDED_SERVER_INFORMATION_TITLE$}";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExtendedServerInformationForm_FormClosed);
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pingChart)).EndInit();
            this.informationSplitContainer.Panel1.ResumeLayout(false);
            this.informationSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.informationSplitContainer)).EndInit();
            this.informationSplitContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.serverSplitContainer.Panel1.ResumeLayout(false);
            this.serverSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverSplitContainer)).EndInit();
            this.serverSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serversDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart pingChart;
        private System.Windows.Forms.SplitContainer informationSplitContainer;
        private System.Windows.Forms.SplitContainer serverSplitContainer;
        private System.Windows.Forms.DataGridView playersGridView;
        private System.Windows.Forms.DataGridView rulesGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel hostnameLabel;
        private MaterialSkin.Controls.MaterialLabel playersLabel;
        private MaterialSkin.Controls.MaterialLabel gamemodeLabel;
        private MaterialSkin.Controls.MaterialLabel languageLabel;
        private MaterialSkin.Controls.MaterialLabel ipAndPortLabel;
        private MaterialSkin.Controls.MaterialLabel pingLabel;
        private System.Data.DataSet serversDataSet;
        private System.Data.DataTable playersDataTable;
        private System.Data.DataColumn playerDataColumn;
        private System.Data.DataColumn scoreDataColumn;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable rulesDataTable;
        private System.Data.DataColumn ruleDataColumn;
        private System.Data.DataColumn valueDataColumn;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Windows.Forms.BindingSource rulesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer updateTimer;
    }
}