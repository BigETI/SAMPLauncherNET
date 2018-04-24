namespace SAMPLauncherNET.UI
{
    partial class SessionUserControl
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
            this.sessionSplitContainer = new System.Windows.Forms.SplitContainer();
            this.sessionInnerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.lastChatlogTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lastChatlogRichTextBox = new System.Windows.Forms.RichTextBox();
            this.lastChatlogContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.lastChatlogCopyTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastChatlogCopyOriginalTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastChatlogCopyHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastChatlogCopyRTFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastChatlogToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.lastChatlogSaveTextAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastChatlogSaveOriginalTextAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastChatlogSaveHTMLAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastChatlogSaveRTFAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastChatlogMenuLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chatlogColorCodesCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.chatlogColoredCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.chatlogTimestampCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.galleryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.galleryMenuLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.galleryViewPictureBox = new System.Windows.Forms.PictureBox();
            this.gallerySavePictureBox = new System.Windows.Forms.PictureBox();
            this.galleryDeletePictureBox = new System.Windows.Forms.PictureBox();
            this.galleryListView = new System.Windows.Forms.ListView();
            this.galleryImageList = new System.Windows.Forms.ImageList(this.components);
            this.savedPositionsTextBox = new System.Windows.Forms.TextBox();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sessionSplitContainer)).BeginInit();
            this.sessionSplitContainer.Panel1.SuspendLayout();
            this.sessionSplitContainer.Panel2.SuspendLayout();
            this.sessionSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionInnerSplitContainer)).BeginInit();
            this.sessionInnerSplitContainer.Panel1.SuspendLayout();
            this.sessionInnerSplitContainer.Panel2.SuspendLayout();
            this.sessionInnerSplitContainer.SuspendLayout();
            this.lastChatlogTableLayoutPanel.SuspendLayout();
            this.lastChatlogContextMenuStrip.SuspendLayout();
            this.lastChatlogMenuLayoutPanel.SuspendLayout();
            this.galleryTableLayoutPanel.SuspendLayout();
            this.galleryMenuLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryViewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallerySavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDeletePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionSplitContainer
            // 
            this.sessionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.sessionSplitContainer.Name = "sessionSplitContainer";
            this.sessionSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sessionSplitContainer.Panel1
            // 
            this.sessionSplitContainer.Panel1.Controls.Add(this.sessionInnerSplitContainer);
            // 
            // sessionSplitContainer.Panel2
            // 
            this.sessionSplitContainer.Panel2.Controls.Add(this.savedPositionsTextBox);
            this.sessionSplitContainer.Size = new System.Drawing.Size(800, 600);
            this.sessionSplitContainer.SplitterDistance = 431;
            this.sessionSplitContainer.TabIndex = 2;
            // 
            // sessionInnerSplitContainer
            // 
            this.sessionInnerSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sessionInnerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sessionInnerSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.sessionInnerSplitContainer.Name = "sessionInnerSplitContainer";
            // 
            // sessionInnerSplitContainer.Panel1
            // 
            this.sessionInnerSplitContainer.Panel1.Controls.Add(this.lastChatlogTableLayoutPanel);
            // 
            // sessionInnerSplitContainer.Panel2
            // 
            this.sessionInnerSplitContainer.Panel2.Controls.Add(this.galleryTableLayoutPanel);
            this.sessionInnerSplitContainer.Size = new System.Drawing.Size(800, 431);
            this.sessionInnerSplitContainer.SplitterDistance = 500;
            this.sessionInnerSplitContainer.TabIndex = 0;
            // 
            // lastChatlogTableLayoutPanel
            // 
            this.lastChatlogTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lastChatlogTableLayoutPanel.ColumnCount = 1;
            this.lastChatlogTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lastChatlogTableLayoutPanel.Controls.Add(this.lastChatlogRichTextBox, 0, 1);
            this.lastChatlogTableLayoutPanel.Controls.Add(this.lastChatlogMenuLayoutPanel, 0, 0);
            this.lastChatlogTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastChatlogTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.lastChatlogTableLayoutPanel.Name = "lastChatlogTableLayoutPanel";
            this.lastChatlogTableLayoutPanel.RowCount = 2;
            this.lastChatlogTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.lastChatlogTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lastChatlogTableLayoutPanel.Size = new System.Drawing.Size(500, 431);
            this.lastChatlogTableLayoutPanel.TabIndex = 2;
            // 
            // lastChatlogRichTextBox
            // 
            this.lastChatlogRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lastChatlogRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastChatlogRichTextBox.BulletIndent = 1;
            this.lastChatlogRichTextBox.ContextMenuStrip = this.lastChatlogContextMenuStrip;
            this.lastChatlogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastChatlogRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lastChatlogRichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lastChatlogRichTextBox.Location = new System.Drawing.Point(3, 47);
            this.lastChatlogRichTextBox.Name = "lastChatlogRichTextBox";
            this.lastChatlogRichTextBox.ReadOnly = true;
            this.lastChatlogRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lastChatlogRichTextBox.Size = new System.Drawing.Size(494, 381);
            this.lastChatlogRichTextBox.TabIndex = 0;
            this.lastChatlogRichTextBox.Text = "";
            this.lastChatlogRichTextBox.WordWrap = false;
            // 
            // lastChatlogContextMenuStrip
            // 
            this.lastChatlogContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lastChatlogContextMenuStrip.Depth = 0;
            this.lastChatlogContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastChatlogCopyTextToolStripMenuItem,
            this.lastChatlogCopyOriginalTextToolStripMenuItem,
            this.lastChatlogCopyHTMLToolStripMenuItem,
            this.lastChatlogCopyRTFToolStripMenuItem,
            this.lastChatlogToolStripSeparator,
            this.lastChatlogSaveTextAsToolStripMenuItem,
            this.lastChatlogSaveOriginalTextAsToolStripMenuItem,
            this.lastChatlogSaveHTMLAsToolStripMenuItem,
            this.lastChatlogSaveRTFAsToolStripMenuItem});
            this.lastChatlogContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastChatlogContextMenuStrip.Name = "lastChatlogContextMenuStrip";
            this.lastChatlogContextMenuStrip.Size = new System.Drawing.Size(282, 186);
            // 
            // lastChatlogCopyTextToolStripMenuItem
            // 
            this.lastChatlogCopyTextToolStripMenuItem.Name = "lastChatlogCopyTextToolStripMenuItem";
            this.lastChatlogCopyTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.lastChatlogCopyTextToolStripMenuItem.ShowShortcutKeys = false;
            this.lastChatlogCopyTextToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.lastChatlogCopyTextToolStripMenuItem.Text = "{$CHATLOG_COPY_TEXT$}";
            this.lastChatlogCopyTextToolStripMenuItem.Click += new System.EventHandler(this.lastChatlogCopyTextToolStripMenuItem_Click);
            // 
            // lastChatlogCopyOriginalTextToolStripMenuItem
            // 
            this.lastChatlogCopyOriginalTextToolStripMenuItem.Name = "lastChatlogCopyOriginalTextToolStripMenuItem";
            this.lastChatlogCopyOriginalTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.lastChatlogCopyOriginalTextToolStripMenuItem.ShowShortcutKeys = false;
            this.lastChatlogCopyOriginalTextToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.lastChatlogCopyOriginalTextToolStripMenuItem.Text = "{$CHATLOG_COPY_ORIGINAL_TEXT$}";
            this.lastChatlogCopyOriginalTextToolStripMenuItem.Click += new System.EventHandler(this.lastChatlogCopyOriginalTextToolStripMenuItem_Click);
            // 
            // lastChatlogCopyHTMLToolStripMenuItem
            // 
            this.lastChatlogCopyHTMLToolStripMenuItem.Name = "lastChatlogCopyHTMLToolStripMenuItem";
            this.lastChatlogCopyHTMLToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.lastChatlogCopyHTMLToolStripMenuItem.Text = "{$CHATLOG_COPY_HTML$}";
            this.lastChatlogCopyHTMLToolStripMenuItem.Click += new System.EventHandler(this.lastChatlogCopyHTMLToolStripMenuItem_Click);
            // 
            // lastChatlogCopyRTFToolStripMenuItem
            // 
            this.lastChatlogCopyRTFToolStripMenuItem.Name = "lastChatlogCopyRTFToolStripMenuItem";
            this.lastChatlogCopyRTFToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.lastChatlogCopyRTFToolStripMenuItem.Text = "{$CHATLOG_COPY_RTF$}";
            this.lastChatlogCopyRTFToolStripMenuItem.Click += new System.EventHandler(this.lastChatlogCopyRTFToolStripMenuItem_Click);
            // 
            // lastChatlogToolStripSeparator
            // 
            this.lastChatlogToolStripSeparator.Name = "lastChatlogToolStripSeparator";
            this.lastChatlogToolStripSeparator.Size = new System.Drawing.Size(278, 6);
            // 
            // lastChatlogSaveTextAsToolStripMenuItem
            // 
            this.lastChatlogSaveTextAsToolStripMenuItem.Name = "lastChatlogSaveTextAsToolStripMenuItem";
            this.lastChatlogSaveTextAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lastChatlogSaveTextAsToolStripMenuItem.ShowShortcutKeys = false;
            this.lastChatlogSaveTextAsToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.lastChatlogSaveTextAsToolStripMenuItem.Text = "{$CHATLOG_SAVE_TEXT_AS$}";
            this.lastChatlogSaveTextAsToolStripMenuItem.Click += new System.EventHandler(this.lastChatlogSaveTextAsToolStripMenuItem_Click);
            // 
            // lastChatlogSaveOriginalTextAsToolStripMenuItem
            // 
            this.lastChatlogSaveOriginalTextAsToolStripMenuItem.Name = "lastChatlogSaveOriginalTextAsToolStripMenuItem";
            this.lastChatlogSaveOriginalTextAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.lastChatlogSaveOriginalTextAsToolStripMenuItem.ShowShortcutKeys = false;
            this.lastChatlogSaveOriginalTextAsToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.lastChatlogSaveOriginalTextAsToolStripMenuItem.Text = "{$CHATLOG_SAVE_ORIGINAL_TEXT_AS$}";
            this.lastChatlogSaveOriginalTextAsToolStripMenuItem.Click += new System.EventHandler(this.lastChatlogSaveOriginalTextAsToolStripMenuItem_Click);
            // 
            // lastChatlogSaveHTMLAsToolStripMenuItem
            // 
            this.lastChatlogSaveHTMLAsToolStripMenuItem.Name = "lastChatlogSaveHTMLAsToolStripMenuItem";
            this.lastChatlogSaveHTMLAsToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.lastChatlogSaveHTMLAsToolStripMenuItem.Text = "{$CHATLOG_SAVE_HTML_AS$}";
            this.lastChatlogSaveHTMLAsToolStripMenuItem.Click += new System.EventHandler(this.lastChatlogSaveHTMLAsToolStripMenuItem_Click);
            // 
            // lastChatlogSaveRTFAsToolStripMenuItem
            // 
            this.lastChatlogSaveRTFAsToolStripMenuItem.Name = "lastChatlogSaveRTFAsToolStripMenuItem";
            this.lastChatlogSaveRTFAsToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.lastChatlogSaveRTFAsToolStripMenuItem.Text = "{$CHATLOG_SAVE_RTF_AS$}";
            this.lastChatlogSaveRTFAsToolStripMenuItem.Click += new System.EventHandler(this.lastChatlogSaveRTFAsToolStripMenuItem_Click);
            // 
            // lastChatlogMenuLayoutPanel
            // 
            this.lastChatlogMenuLayoutPanel.Controls.Add(this.chatlogColorCodesCheckBox);
            this.lastChatlogMenuLayoutPanel.Controls.Add(this.chatlogColoredCheckBox);
            this.lastChatlogMenuLayoutPanel.Controls.Add(this.chatlogTimestampCheckBox);
            this.lastChatlogMenuLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastChatlogMenuLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.lastChatlogMenuLayoutPanel.Name = "lastChatlogMenuLayoutPanel";
            this.lastChatlogMenuLayoutPanel.Size = new System.Drawing.Size(494, 38);
            this.lastChatlogMenuLayoutPanel.TabIndex = 1;
            // 
            // chatlogColorCodesCheckBox
            // 
            this.chatlogColorCodesCheckBox.AutoSize = true;
            this.chatlogColorCodesCheckBox.Depth = 0;
            this.chatlogColorCodesCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.chatlogColorCodesCheckBox.Location = new System.Drawing.Point(0, 0);
            this.chatlogColorCodesCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.chatlogColorCodesCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chatlogColorCodesCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.chatlogColorCodesCheckBox.Name = "chatlogColorCodesCheckBox";
            this.chatlogColorCodesCheckBox.Ripple = true;
            this.chatlogColorCodesCheckBox.Size = new System.Drawing.Size(273, 30);
            this.chatlogColorCodesCheckBox.TabIndex = 0;
            this.chatlogColorCodesCheckBox.Text = "{$CHATLOG_OPTION_COLOR_CODES$}";
            this.chatlogColorCodesCheckBox.UseVisualStyleBackColor = true;
            this.chatlogColorCodesCheckBox.CheckedChanged += new System.EventHandler(this.chatlogGenericCheckBox_CheckedChanged);
            // 
            // chatlogColoredCheckBox
            // 
            this.chatlogColoredCheckBox.AutoSize = true;
            this.chatlogColoredCheckBox.Checked = true;
            this.chatlogColoredCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chatlogColoredCheckBox.Depth = 0;
            this.chatlogColoredCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.chatlogColoredCheckBox.Location = new System.Drawing.Point(0, 30);
            this.chatlogColoredCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.chatlogColoredCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chatlogColoredCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.chatlogColoredCheckBox.Name = "chatlogColoredCheckBox";
            this.chatlogColoredCheckBox.Ripple = true;
            this.chatlogColoredCheckBox.Size = new System.Drawing.Size(240, 30);
            this.chatlogColoredCheckBox.TabIndex = 1;
            this.chatlogColoredCheckBox.Text = "{$CHATLOG_OPTION_COLORED$}";
            this.chatlogColoredCheckBox.UseVisualStyleBackColor = true;
            this.chatlogColoredCheckBox.CheckedChanged += new System.EventHandler(this.chatlogGenericCheckBox_CheckedChanged);
            // 
            // chatlogTimestampCheckBox
            // 
            this.chatlogTimestampCheckBox.AutoSize = true;
            this.chatlogTimestampCheckBox.Depth = 0;
            this.chatlogTimestampCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.chatlogTimestampCheckBox.Location = new System.Drawing.Point(0, 60);
            this.chatlogTimestampCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.chatlogTimestampCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chatlogTimestampCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.chatlogTimestampCheckBox.Name = "chatlogTimestampCheckBox";
            this.chatlogTimestampCheckBox.Ripple = true;
            this.chatlogTimestampCheckBox.Size = new System.Drawing.Size(258, 30);
            this.chatlogTimestampCheckBox.TabIndex = 2;
            this.chatlogTimestampCheckBox.Text = "{$CHATLOG_OPTION_TIMESTAMP$}";
            this.chatlogTimestampCheckBox.UseVisualStyleBackColor = true;
            this.chatlogTimestampCheckBox.CheckedChanged += new System.EventHandler(this.chatlogGenericCheckBox_CheckedChanged);
            // 
            // galleryTableLayoutPanel
            // 
            this.galleryTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
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
            this.galleryTableLayoutPanel.Size = new System.Drawing.Size(296, 431);
            this.galleryTableLayoutPanel.TabIndex = 1;
            // 
            // galleryMenuLayoutPanel
            // 
            this.galleryMenuLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.galleryMenuLayoutPanel.Controls.Add(this.galleryViewPictureBox);
            this.galleryMenuLayoutPanel.Controls.Add(this.gallerySavePictureBox);
            this.galleryMenuLayoutPanel.Controls.Add(this.galleryDeletePictureBox);
            this.galleryMenuLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryMenuLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.galleryMenuLayoutPanel.Name = "galleryMenuLayoutPanel";
            this.galleryMenuLayoutPanel.Size = new System.Drawing.Size(290, 38);
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
            this.galleryViewPictureBox.Click += new System.EventHandler(this.galleryViewPictureBox_Click);
            this.galleryViewPictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.galleryViewPictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // gallerySavePictureBox
            // 
            this.gallerySavePictureBox.Image = global::SAMPLauncherNET.Properties.Resources.edit_icon;
            this.gallerySavePictureBox.Location = new System.Drawing.Point(41, 3);
            this.gallerySavePictureBox.Name = "gallerySavePictureBox";
            this.gallerySavePictureBox.Size = new System.Drawing.Size(32, 32);
            this.gallerySavePictureBox.TabIndex = 2;
            this.gallerySavePictureBox.TabStop = false;
            this.gallerySavePictureBox.Click += new System.EventHandler(this.gallerySavePictureBox_Click);
            this.gallerySavePictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.gallerySavePictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // galleryDeletePictureBox
            // 
            this.galleryDeletePictureBox.Image = global::SAMPLauncherNET.Properties.Resources.delete_icon;
            this.galleryDeletePictureBox.Location = new System.Drawing.Point(79, 3);
            this.galleryDeletePictureBox.Name = "galleryDeletePictureBox";
            this.galleryDeletePictureBox.Size = new System.Drawing.Size(32, 32);
            this.galleryDeletePictureBox.TabIndex = 1;
            this.galleryDeletePictureBox.TabStop = false;
            this.galleryDeletePictureBox.Click += new System.EventHandler(this.galleryDeletePictureBox_Click);
            this.galleryDeletePictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.galleryDeletePictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // galleryListView
            // 
            this.galleryListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.galleryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galleryListView.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.galleryListView.LargeImageList = this.galleryImageList;
            this.galleryListView.Location = new System.Drawing.Point(3, 47);
            this.galleryListView.Name = "galleryListView";
            this.galleryListView.Size = new System.Drawing.Size(290, 381);
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
            // savedPositionsTextBox
            // 
            this.savedPositionsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.savedPositionsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.savedPositionsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedPositionsTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.savedPositionsTextBox.Location = new System.Drawing.Point(2, 0);
            this.savedPositionsTextBox.Multiline = true;
            this.savedPositionsTextBox.Name = "savedPositionsTextBox";
            this.savedPositionsTextBox.ReadOnly = true;
            this.savedPositionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.savedPositionsTextBox.Size = new System.Drawing.Size(796, 165);
            this.savedPositionsTextBox.TabIndex = 4;
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Interval = 500;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // SessionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.sessionSplitContainer);
            this.DoubleBuffered = true;
            this.Name = "SessionUserControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.sessionSplitContainer.Panel1.ResumeLayout(false);
            this.sessionSplitContainer.Panel2.ResumeLayout(false);
            this.sessionSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionSplitContainer)).EndInit();
            this.sessionSplitContainer.ResumeLayout(false);
            this.sessionInnerSplitContainer.Panel1.ResumeLayout(false);
            this.sessionInnerSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sessionInnerSplitContainer)).EndInit();
            this.sessionInnerSplitContainer.ResumeLayout(false);
            this.lastChatlogTableLayoutPanel.ResumeLayout(false);
            this.lastChatlogContextMenuStrip.ResumeLayout(false);
            this.lastChatlogMenuLayoutPanel.ResumeLayout(false);
            this.lastChatlogMenuLayoutPanel.PerformLayout();
            this.galleryTableLayoutPanel.ResumeLayout(false);
            this.galleryMenuLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryViewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gallerySavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDeletePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sessionSplitContainer;
        private System.Windows.Forms.SplitContainer sessionInnerSplitContainer;
        private System.Windows.Forms.TableLayoutPanel lastChatlogTableLayoutPanel;
        private System.Windows.Forms.RichTextBox lastChatlogRichTextBox;
        private System.Windows.Forms.FlowLayoutPanel lastChatlogMenuLayoutPanel;
        private MaterialSkin.Controls.MaterialCheckBox chatlogColorCodesCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox chatlogColoredCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox chatlogTimestampCheckBox;
        private System.Windows.Forms.TableLayoutPanel galleryTableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel galleryMenuLayoutPanel;
        private System.Windows.Forms.PictureBox galleryViewPictureBox;
        private System.Windows.Forms.PictureBox gallerySavePictureBox;
        private System.Windows.Forms.PictureBox galleryDeletePictureBox;
        private System.Windows.Forms.ListView galleryListView;
        private System.Windows.Forms.TextBox savedPositionsTextBox;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.ImageList galleryImageList;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MaterialSkin.Controls.MaterialContextMenuStrip lastChatlogContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem lastChatlogCopyTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastChatlogCopyOriginalTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastChatlogCopyHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastChatlogCopyRTFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator lastChatlogToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem lastChatlogSaveTextAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastChatlogSaveOriginalTextAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastChatlogSaveHTMLAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastChatlogSaveRTFAsToolStripMenuItem;
    }
}
