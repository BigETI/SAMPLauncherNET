using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Session form class
    /// </summary>
    public partial class SessionForm : MaterialForm
    {
        /// <summary>
        /// Session
        /// </summary>
        private Session session;

        /// <summary>
        /// Gallery
        /// </summary>
        private Dictionary<string, Image> loadedGallery = new Dictionary<string, Image>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">Session</param>
        public SessionForm(Session session)
        {
            this.session = session;
            InitializeComponent();
            Translator.LoadTranslation(this);
            SessionUserControl suc = new SessionUserControl(session);
            mainTableLayoutPanel.Controls.Add(suc, 0, 0);
            suc.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// OK button click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Delete button click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(Translator.GetTranslation("SESSION_DELETE"), Translator.GetTranslation("SESSION_DELETE_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            DialogResult = DialogResult.None;
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.No;
                Close();
            }
        }
    }
}
