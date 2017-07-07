namespace SAMPLauncherNET
{
    partial class FavouriteListsForm
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
            this.mainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectFavouritesListLabel = new MaterialSkin.Controls.MaterialLabel();
            this.favouritesListComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFlowLayoutPanel
            // 
            this.mainFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainFlowLayoutPanel.Controls.Add(this.selectFavouritesListLabel);
            this.mainFlowLayoutPanel.Controls.Add(this.favouritesListComboBox);
            this.mainFlowLayoutPanel.Controls.Add(this.okButton);
            this.mainFlowLayoutPanel.Controls.Add(this.cancelButton);
            this.mainFlowLayoutPanel.Location = new System.Drawing.Point(5, 64);
            this.mainFlowLayoutPanel.Name = "mainFlowLayoutPanel";
            this.mainFlowLayoutPanel.Size = new System.Drawing.Size(406, 96);
            this.mainFlowLayoutPanel.TabIndex = 0;
            // 
            // selectFavouritesListLabel
            // 
            this.selectFavouritesListLabel.AutoSize = true;
            this.selectFavouritesListLabel.Depth = 0;
            this.selectFavouritesListLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.selectFavouritesListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.selectFavouritesListLabel.Location = new System.Drawing.Point(3, 0);
            this.selectFavouritesListLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectFavouritesListLabel.Name = "selectFavouritesListLabel";
            this.selectFavouritesListLabel.Size = new System.Drawing.Size(221, 19);
            this.selectFavouritesListLabel.TabIndex = 0;
            this.selectFavouritesListLabel.Text = "{$SELECT_FAVOURITES_LIST$}";
            // 
            // favouritesListComboBox
            // 
            this.favouritesListComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.favouritesListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.favouritesListComboBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouritesListComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.favouritesListComboBox.FormattingEnabled = true;
            this.favouritesListComboBox.Location = new System.Drawing.Point(3, 22);
            this.favouritesListComboBox.Name = "favouritesListComboBox";
            this.favouritesListComboBox.Size = new System.Drawing.Size(400, 28);
            this.favouritesListComboBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Depth = 0;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(3, 56);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.Primary = true;
            this.okButton.Size = new System.Drawing.Size(64, 36);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "{$OK$}";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(73, 56);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = true;
            this.cancelButton.Size = new System.Drawing.Size(98, 36);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FavouriteListsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 172);
            this.Controls.Add(this.mainFlowLayoutPanel);
            this.MaximumSize = new System.Drawing.Size(416, 276);
            this.MinimumSize = new System.Drawing.Size(416, 0);
            this.Name = "FavouriteListsForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "{$SELECT_FAVOURITE_LIST_TITLE$}";
            this.TopMost = true;
            this.mainFlowLayoutPanel.ResumeLayout(false);
            this.mainFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowLayoutPanel;
        private MaterialSkin.Controls.MaterialLabel selectFavouritesListLabel;
        private System.Windows.Forms.ComboBox favouritesListComboBox;
        private MaterialSkin.Controls.MaterialRaisedButton okButton;
        private MaterialSkin.Controls.MaterialRaisedButton cancelButton;
    }
}