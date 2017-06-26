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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtendedServerInformationForm));
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.serverInfoAndPlayersPanel = new MetroFramework.Controls.MetroPanel();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersRulesDataSet = new System.Data.DataSet();
            this.playersDataTable = new System.Data.DataTable();
            this.idDataColumn = new System.Data.DataColumn();
            this.nameDataColumn = new System.Data.DataColumn();
            this.scoreDataColumn = new System.Data.DataColumn();
            this.pingDataColumn = new System.Data.DataColumn();
            this.mainSplitter = new System.Windows.Forms.Splitter();
            this.pingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.playersRulesPanel = new MetroFramework.Controls.MetroPanel();
            this.playersGrid = new MetroFramework.Controls.MetroGrid();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rulesGrid = new MetroFramework.Controls.MetroGrid();
            this.serverInfoAndPingSplitter = new System.Windows.Forms.Splitter();
            this.serverInfoPanel = new MetroFramework.Controls.MetroPanel();
            this.pingLabel = new MetroFramework.Controls.MetroLabel();
            this.ipAndPortLabel = new MetroFramework.Controls.MetroLabel();
            this.languageLabel = new MetroFramework.Controls.MetroLabel();
            this.gamemodeLabel = new MetroFramework.Controls.MetroLabel();
            this.playersLabel = new MetroFramework.Controls.MetroLabel();
            this.hostnameLabel = new MetroFramework.Controls.MetroLabel();
            this.rulesDataTable = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.rulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.serverInfoAndPlayersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersRulesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingChart)).BeginInit();
            this.playersRulesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).BeginInit();
            this.serverInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 500;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.serverInfoAndPlayersPanel);
            this.mainPanel.Controls.Add(this.mainSplitter);
            this.mainPanel.Controls.Add(this.pingChart);
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(23, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(754, 514);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // serverInfoAndPlayersPanel
            // 
            this.serverInfoAndPlayersPanel.Controls.Add(this.serverInfoPanel);
            this.serverInfoAndPlayersPanel.Controls.Add(this.serverInfoAndPingSplitter);
            this.serverInfoAndPlayersPanel.Controls.Add(this.playersRulesPanel);
            this.serverInfoAndPlayersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverInfoAndPlayersPanel.HorizontalScrollbarBarColor = true;
            this.serverInfoAndPlayersPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.serverInfoAndPlayersPanel.HorizontalScrollbarSize = 10;
            this.serverInfoAndPlayersPanel.Location = new System.Drawing.Point(0, 0);
            this.serverInfoAndPlayersPanel.Name = "serverInfoAndPlayersPanel";
            this.serverInfoAndPlayersPanel.Size = new System.Drawing.Size(754, 361);
            this.serverInfoAndPlayersPanel.TabIndex = 6;
            this.serverInfoAndPlayersPanel.VerticalScrollbarBarColor = true;
            this.serverInfoAndPlayersPanel.VerticalScrollbarHighlightOnWheel = false;
            this.serverInfoAndPlayersPanel.VerticalScrollbarSize = 10;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.playersRulesDataSet;
            this.playersBindingSource.Sort = "ID";
            // 
            // playersRulesDataSet
            // 
            this.playersRulesDataSet.DataSetName = "PlayersRulesDataSet";
            this.playersRulesDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.playersDataTable,
            this.rulesDataTable});
            // 
            // playersDataTable
            // 
            this.playersDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.idDataColumn,
            this.nameDataColumn,
            this.scoreDataColumn,
            this.pingDataColumn});
            this.playersDataTable.TableName = "Players";
            // 
            // idDataColumn
            // 
            this.idDataColumn.ColumnName = "ID";
            this.idDataColumn.DataType = typeof(byte);
            this.idDataColumn.DefaultValue = ((byte)(0));
            // 
            // nameDataColumn
            // 
            this.nameDataColumn.ColumnName = "Name";
            this.nameDataColumn.DefaultValue = "";
            // 
            // scoreDataColumn
            // 
            this.scoreDataColumn.ColumnName = "Score";
            this.scoreDataColumn.DataType = typeof(int);
            this.scoreDataColumn.DefaultValue = 0;
            // 
            // pingDataColumn
            // 
            this.pingDataColumn.ColumnName = "Ping";
            this.pingDataColumn.DataType = typeof(uint);
            this.pingDataColumn.DefaultValue = ((uint)(0u));
            // 
            // mainSplitter
            // 
            this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainSplitter.Location = new System.Drawing.Point(0, 361);
            this.mainSplitter.Name = "mainSplitter";
            this.mainSplitter.Size = new System.Drawing.Size(754, 3);
            this.mainSplitter.TabIndex = 5;
            this.mainSplitter.TabStop = false;
            // 
            // pingChart
            // 
            this.pingChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pingChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.pingChart.ChartAreas.Add(chartArea1);
            this.pingChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.pingChart.Legends.Add(legend1);
            this.pingChart.Location = new System.Drawing.Point(0, 364);
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
            this.pingChart.Size = new System.Drawing.Size(754, 150);
            this.pingChart.TabIndex = 4;
            // 
            // playersRulesPanel
            // 
            this.playersRulesPanel.Controls.Add(this.playersGrid);
            this.playersRulesPanel.Controls.Add(this.splitter1);
            this.playersRulesPanel.Controls.Add(this.rulesGrid);
            this.playersRulesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.playersRulesPanel.HorizontalScrollbarBarColor = true;
            this.playersRulesPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.playersRulesPanel.HorizontalScrollbarSize = 10;
            this.playersRulesPanel.Location = new System.Drawing.Point(454, 0);
            this.playersRulesPanel.Name = "playersRulesPanel";
            this.playersRulesPanel.Size = new System.Drawing.Size(300, 361);
            this.playersRulesPanel.TabIndex = 8;
            this.playersRulesPanel.VerticalScrollbarBarColor = true;
            this.playersRulesPanel.VerticalScrollbarHighlightOnWheel = false;
            this.playersRulesPanel.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.playersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.pingDataGridViewTextBoxColumn});
            this.playersGrid.DataSource = this.playersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.playersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.playersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.playersGrid.EnableHeadersVisualStyles = false;
            this.playersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.playersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.playersGrid.Location = new System.Drawing.Point(0, 0);
            this.playersGrid.MultiSelect = false;
            this.playersGrid.Name = "playersGrid";
            this.playersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.playersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.playersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.playersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playersGrid.Size = new System.Drawing.Size(300, 158);
            this.playersGrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.playersGrid.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // pingDataGridViewTextBoxColumn
            // 
            this.pingDataGridViewTextBoxColumn.DataPropertyName = "Ping";
            this.pingDataGridViewTextBoxColumn.HeaderText = "Ping";
            this.pingDataGridViewTextBoxColumn.Name = "pingDataGridViewTextBoxColumn";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 158);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(300, 3);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rulesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.rulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ruleDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.rulesGrid.DataSource = this.rulesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rulesGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.rulesGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rulesGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rulesGrid.EnableHeadersVisualStyles = false;
            this.rulesGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rulesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rulesGrid.Location = new System.Drawing.Point(0, 161);
            this.rulesGrid.MultiSelect = false;
            this.rulesGrid.Name = "rulesGrid";
            this.rulesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rulesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.rulesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rulesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesGrid.Size = new System.Drawing.Size(300, 200);
            this.rulesGrid.Style = MetroFramework.MetroColorStyle.Orange;
            this.rulesGrid.TabIndex = 9;
            // 
            // serverInfoAndPingSplitter
            // 
            this.serverInfoAndPingSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.serverInfoAndPingSplitter.Location = new System.Drawing.Point(451, 0);
            this.serverInfoAndPingSplitter.Name = "serverInfoAndPingSplitter";
            this.serverInfoAndPingSplitter.Size = new System.Drawing.Size(3, 361);
            this.serverInfoAndPingSplitter.TabIndex = 10;
            this.serverInfoAndPingSplitter.TabStop = false;
            // 
            // serverInfoPanel
            // 
            this.serverInfoPanel.Controls.Add(this.pingLabel);
            this.serverInfoPanel.Controls.Add(this.ipAndPortLabel);
            this.serverInfoPanel.Controls.Add(this.languageLabel);
            this.serverInfoPanel.Controls.Add(this.gamemodeLabel);
            this.serverInfoPanel.Controls.Add(this.playersLabel);
            this.serverInfoPanel.Controls.Add(this.hostnameLabel);
            this.serverInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverInfoPanel.HorizontalScrollbarBarColor = true;
            this.serverInfoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.serverInfoPanel.HorizontalScrollbarSize = 10;
            this.serverInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.serverInfoPanel.Name = "serverInfoPanel";
            this.serverInfoPanel.Size = new System.Drawing.Size(451, 361);
            this.serverInfoPanel.Style = MetroFramework.MetroColorStyle.Orange;
            this.serverInfoPanel.TabIndex = 11;
            this.serverInfoPanel.VerticalScrollbarBarColor = true;
            this.serverInfoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.serverInfoPanel.VerticalScrollbarSize = 10;
            // 
            // pingLabel
            // 
            this.pingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pingLabel.Location = new System.Drawing.Point(3, 95);
            this.pingLabel.Name = "pingLabel";
            this.pingLabel.Size = new System.Drawing.Size(445, 19);
            this.pingLabel.TabIndex = 5;
            this.pingLabel.Text = "{$PING$}";
            // 
            // ipAndPortLabel
            // 
            this.ipAndPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAndPortLabel.Location = new System.Drawing.Point(3, 76);
            this.ipAndPortLabel.Name = "ipAndPortLabel";
            this.ipAndPortLabel.Size = new System.Drawing.Size(445, 19);
            this.ipAndPortLabel.TabIndex = 4;
            this.ipAndPortLabel.Text = "{$IP_AND_PORT$}";
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageLabel.Location = new System.Drawing.Point(3, 57);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(445, 19);
            this.languageLabel.TabIndex = 3;
            this.languageLabel.Text = "{$LANGUAGE$}";
            // 
            // gamemodeLabel
            // 
            this.gamemodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamemodeLabel.Location = new System.Drawing.Point(3, 38);
            this.gamemodeLabel.Name = "gamemodeLabel";
            this.gamemodeLabel.Size = new System.Drawing.Size(445, 19);
            this.gamemodeLabel.TabIndex = 2;
            this.gamemodeLabel.Text = "{$GAMEMODE$}";
            // 
            // playersLabel
            // 
            this.playersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersLabel.Location = new System.Drawing.Point(3, 19);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(445, 19);
            this.playersLabel.TabIndex = 1;
            this.playersLabel.Text = "{$PLAYERS$}";
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostnameLabel.Location = new System.Drawing.Point(3, 0);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(445, 19);
            this.hostnameLabel.TabIndex = 0;
            this.hostnameLabel.Text = "{$HOSTNAME$}";
            // 
            // rulesDataTable
            // 
            this.rulesDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.rulesDataTable.TableName = "Rules";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Rule";
            this.dataColumn1.DefaultValue = "";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Value";
            this.dataColumn2.DefaultValue = "";
            // 
            // rulesBindingSource
            // 
            this.rulesBindingSource.DataMember = "Rules";
            this.rulesBindingSource.DataSource = this.playersRulesDataSet;
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
            // ExtendedServerInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtendedServerInformationForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "{$EXTENDED_SERVER_INFORMATION_TITLE$}";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExtendedServerInformationForm_FormClosed);
            this.mainPanel.ResumeLayout(false);
            this.serverInfoAndPlayersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersRulesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingChart)).EndInit();
            this.playersRulesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesGrid)).EndInit();
            this.serverInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rulesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer updateTimer;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private System.Data.DataSet playersRulesDataSet;
        private System.Data.DataTable playersDataTable;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private System.Data.DataColumn idDataColumn;
        private System.Data.DataColumn nameDataColumn;
        private System.Data.DataColumn scoreDataColumn;
        private System.Data.DataColumn pingDataColumn;
        private MetroFramework.Controls.MetroPanel serverInfoAndPlayersPanel;
        private System.Windows.Forms.Splitter mainSplitter;
        private System.Windows.Forms.DataVisualization.Charting.Chart pingChart;
        private MetroFramework.Controls.MetroPanel serverInfoPanel;
        private MetroFramework.Controls.MetroLabel pingLabel;
        private MetroFramework.Controls.MetroLabel ipAndPortLabel;
        private MetroFramework.Controls.MetroLabel languageLabel;
        private MetroFramework.Controls.MetroLabel gamemodeLabel;
        private MetroFramework.Controls.MetroLabel playersLabel;
        private MetroFramework.Controls.MetroLabel hostnameLabel;
        private System.Windows.Forms.Splitter serverInfoAndPingSplitter;
        private MetroFramework.Controls.MetroPanel playersRulesPanel;
        private MetroFramework.Controls.MetroGrid playersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingDataGridViewTextBoxColumn;
        private System.Windows.Forms.Splitter splitter1;
        private MetroFramework.Controls.MetroGrid rulesGrid;
        private System.Data.DataTable rulesDataTable;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rulesBindingSource;
    }
}