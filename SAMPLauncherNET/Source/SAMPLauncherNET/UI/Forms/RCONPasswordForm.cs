using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// RCON password form class
    /// </summary>
    public partial class RCONPasswordForm : MaterialForm
    {
        /// <summary>
        /// RCON password
        /// </summary>
        public string RCONPassword
        {
            get
            {
                return rconPasswordTextBox.Text;
            }
        }

        /// <summary>
        /// Deefault constructor
        /// </summary>
        public RCONPasswordForm()
        {
            InitializeComponent();
            Utils.Translator.TranslateControls(this);
        }

        /// <summary>
        /// Connect button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void connectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Cancel button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// RCON password text box key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Key event arguments</param>
        private void rconPasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
