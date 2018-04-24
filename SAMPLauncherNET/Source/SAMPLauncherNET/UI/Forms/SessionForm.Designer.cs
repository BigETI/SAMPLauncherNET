namespace SAMPLauncherNET
{
    partial class SessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionForm));
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.okButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainTableLayoutPanel.SuspendLayout();
            this.buttonsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.buttonsFlowLayoutPanel, 0, 1);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(12, 64);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(976, 674);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // buttonsFlowLayoutPanel
            // 
            this.buttonsFlowLayoutPanel.Controls.Add(this.deleteButton);
            this.buttonsFlowLayoutPanel.Controls.Add(this.okButton);
            this.buttonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.buttonsFlowLayoutPanel.Location = new System.Drawing.Point(3, 633);
            this.buttonsFlowLayoutPanel.Name = "buttonsFlowLayoutPanel";
            this.buttonsFlowLayoutPanel.Size = new System.Drawing.Size(970, 38);
            this.buttonsFlowLayoutPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.Depth = 0;
            this.deleteButton.Icon = null;
            this.deleteButton.Location = new System.Drawing.Point(873, 3);
            this.deleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Primary = true;
            this.deleteButton.Size = new System.Drawing.Size(94, 36);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "{$DELETE$}";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Depth = 0;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(803, 3);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.Primary = true;
            this.okButton.Size = new System.Drawing.Size(64, 36);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "{$OK$}";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 750);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SessionForm";
            this.Text = "{$SESSION$}";
            this.TopMost = true;
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.buttonsFlowLayoutPanel.ResumeLayout(false);
            this.buttonsFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialRaisedButton okButton;
        private MaterialSkin.Controls.MaterialRaisedButton deleteButton;
    }
}