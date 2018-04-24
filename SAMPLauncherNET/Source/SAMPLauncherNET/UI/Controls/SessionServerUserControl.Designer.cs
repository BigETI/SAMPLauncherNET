namespace SAMPLauncherNET.UI
{
    partial class SessionServerUserControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textLabel = new MaterialSkin.Controls.MaterialLabel();
            this.connectButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.mainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Controls.Add(this.textLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.connectButton);
            this.mainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(800, 600);
            this.mainFlowLayoutPanel.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Depth = 0;
            this.textLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.textLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textLabel.Location = new System.Drawing.Point(3, 0);
            this.textLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(21, 19);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "...";
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
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "{$CONNECT$}";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Interval = 500;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // SessionServerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Name = "SessionServerUserControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel textLabel;
        private MaterialSkin.Controls.MaterialRaisedButton connectButton;
        private System.Windows.Forms.Timer tickTimer;
    }
}
