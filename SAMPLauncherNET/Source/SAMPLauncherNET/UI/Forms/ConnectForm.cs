using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Connect form class
    /// </summary>
    public partial class ConnectForm : MaterialForm
    {
        /// <summary>
        /// Username
        /// </summary>
        public string Username
        {
            get
            {
                return usernameSingleLineTextField.Text.Trim();
            }
        }

        /// <summary>
        /// Server password
        /// </summary>
        public string ServerPassword
        {
            get
            {
                return serverPasswordSingleLineTextField.Text;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="noPasswordMode">No password mode</param>
        public ConnectForm(bool noPasswordMode)
        {
            InitializeComponent();
            Utils.Translator.TranslateControls(this);
            usernameSingleLineTextField.Text = SAMP.Username;
            if (noPasswordMode)
            {
                serverPasswordLabel.Visible = false;
                serverPasswordSingleLineTextField.Visible = false;
                Size sz = new Size(MinimumSize.Width, MinimumSize.Height - 55);
                MaximumSize = sz;
                MinimumSize = sz;
            }
        }

        /// <summary>
        /// Accept input
        /// </summary>
        private void AcceptInput()
        {
            if (Username.Length <= 0)
            {
                MessageBox.Show(Utils.Translator.GetTranslation("PLEASE_TYPE_IN_USERNAME"), Utils.Translator.GetTranslation("INPUT_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool success = true;
                if (serverPasswordSingleLineTextField.Visible && (ServerPassword.Trim().Length <= 0))
                {
                    success = (MessageBox.Show(Utils.Translator.GetTranslation("SERVER_PASSWORD_FIELD_IS_EMPTY"), Utils.Translator.GetTranslation("SERVER_PASSWORD_FIELD_IS_EMPTY_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                }
                if (success)
                {
                    if (!(tempUsernameCheckBox.Checked))
                    {
                        SAMP.Username = Username;
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        /// <summary>
        /// Connect button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void connectButton_Click(object sender, EventArgs e)
        {
            AcceptInput();
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
        /// Generic single line text field key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Key event arguments</param>
        private void genericSingleLineTextField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AcceptInput();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
