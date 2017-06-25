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
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.playersLabel = new MetroFramework.Controls.MetroLabel();
            this.hostnameLabel = new MetroFramework.Controls.MetroLabel();
            this.mainSplitter = new System.Windows.Forms.Splitter();
            this.pingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gamemodeLabel = new MetroFramework.Controls.MetroLabel();
            this.languageLabel = new MetroFramework.Controls.MetroLabel();
            this.ipAndPortLabel = new MetroFramework.Controls.MetroLabel();
            this.mainPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingChart)).BeginInit();
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
            this.mainPanel.Controls.Add(this.metroPanel1);
            this.mainPanel.Controls.Add(this.mainSplitter);
            this.mainPanel.Controls.Add(this.pingChart);
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(23, 63);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(686, 398);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ipAndPortLabel);
            this.metroPanel1.Controls.Add(this.languageLabel);
            this.metroPanel1.Controls.Add(this.gamemodeLabel);
            this.metroPanel1.Controls.Add(this.playersLabel);
            this.metroPanel1.Controls.Add(this.hostnameLabel);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(686, 245);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // playersLabel
            // 
            this.playersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playersLabel.Location = new System.Drawing.Point(3, 19);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(680, 19);
            this.playersLabel.TabIndex = 3;
            this.playersLabel.Text = "{$PLAYERS$}";
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostnameLabel.Location = new System.Drawing.Point(3, 0);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(680, 19);
            this.hostnameLabel.TabIndex = 2;
            this.hostnameLabel.Text = "{$HOSTNAME$}";
            // 
            // mainSplitter
            // 
            this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainSplitter.Location = new System.Drawing.Point(0, 245);
            this.mainSplitter.Name = "mainSplitter";
            this.mainSplitter.Size = new System.Drawing.Size(686, 3);
            this.mainSplitter.TabIndex = 3;
            this.mainSplitter.TabStop = false;
            // 
            // pingChart
            // 
            chartArea1.Name = "ChartArea1";
            this.pingChart.ChartAreas.Add(chartArea1);
            this.pingChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.pingChart.Legends.Add(legend1);
            this.pingChart.Location = new System.Drawing.Point(0, 248);
            this.pingChart.Name = "pingChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.pingChart.Series.Add(series1);
            this.pingChart.Size = new System.Drawing.Size(686, 150);
            this.pingChart.TabIndex = 2;
            // 
            // gamemodeLabel
            // 
            this.gamemodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gamemodeLabel.Location = new System.Drawing.Point(3, 38);
            this.gamemodeLabel.Name = "gamemodeLabel";
            this.gamemodeLabel.Size = new System.Drawing.Size(680, 19);
            this.gamemodeLabel.TabIndex = 4;
            this.gamemodeLabel.Text = "{$GAMEMODE$}";
            // 
            // languageLabel
            // 
            this.languageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.languageLabel.Location = new System.Drawing.Point(3, 57);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(680, 19);
            this.languageLabel.TabIndex = 5;
            this.languageLabel.Text = "{$LANGUAGE$}";
            // 
            // ipAndPortLabel
            // 
            this.ipAndPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAndPortLabel.Location = new System.Drawing.Point(3, 76);
            this.ipAndPortLabel.Name = "ipAndPortLabel";
            this.ipAndPortLabel.Size = new System.Drawing.Size(680, 19);
            this.ipAndPortLabel.TabIndex = 6;
            this.ipAndPortLabel.Text = "{$IP_AND_PORT$}";
            // 
            // ExtendedServerInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 484);
            this.Controls.Add(this.mainPanel);
            this.Name = "ExtendedServerInformationForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "{$EXTENDED_SERVER_INFORMATION_TITLE$}";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExtendedServerInformationForm_FormClosed);
            this.mainPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer updateTimer;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Splitter mainSplitter;
        private System.Windows.Forms.DataVisualization.Charting.Chart pingChart;
        private MetroFramework.Controls.MetroLabel hostnameLabel;
        private MetroFramework.Controls.MetroLabel playersLabel;
        private MetroFramework.Controls.MetroLabel languageLabel;
        private MetroFramework.Controls.MetroLabel gamemodeLabel;
        private MetroFramework.Controls.MetroLabel ipAndPortLabel;
    }
}