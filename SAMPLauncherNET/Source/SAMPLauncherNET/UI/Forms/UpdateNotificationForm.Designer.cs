namespace SAMPLauncherNET
{
    partial class UpdateNotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateNotificationForm));
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.updateNotificationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.yesButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.noButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainFlowLayoutPanel.Controls.Add(this.updateNotificationLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.yesButton);
            this.mainFlowLayoutPanel.Controls.Add(this.noButton);
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(5, 64);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(390, 119);
            this.mainFlowLayoutPanel.TabIndex = 1;
            // 
            // updateNotificationLabel
            // 
            this.updateNotificationLabel.AutoSize = true;
            this.updateNotificationLabel.Depth = 0;
            this.updateNotificationLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.updateNotificationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updateNotificationLabel.Location = new System.Drawing.Point(3, 0);
            this.updateNotificationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateNotificationLabel.Name = "updateNotificationLabel";
            this.updateNotificationLabel.Size = new System.Drawing.Size(199, 19);
            this.updateNotificationLabel.TabIndex = 13;
            this.updateNotificationLabel.Text = "{$UPDATE_NOTIFICATION$}";
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yesButton.Depth = 0;
            this.yesButton.Icon = null;
            this.yesButton.Location = new System.Drawing.Point(208, 3);
            this.yesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.yesButton.Name = "yesButton";
            this.yesButton.Primary = true;
            this.yesButton.Size = new System.Drawing.Size(70, 36);
            this.yesButton.TabIndex = 11;
            this.yesButton.Text = "{$YES$}";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noButton.Depth = 0;
            this.noButton.Icon = null;
            this.noButton.Location = new System.Drawing.Point(284, 3);
            this.noButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.noButton.Name = "noButton";
            this.noButton.Primary = true;
            this.noButton.Size = new System.Drawing.Size(65, 36);
            this.noButton.TabIndex = 12;
            this.noButton.Text = "{$NO$}";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // UpdateNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 195);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateNotificationForm";
            this.Text = "{$UPDATE_NOTIFICATION_TITLE$}";
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialRaisedButton yesButton;
        private MaterialSkin.Controls.MaterialRaisedButton noButton;
        private MaterialSkin.Controls.MaterialLabel updateNotificationLabel;
    }
}