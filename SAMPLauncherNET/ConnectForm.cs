using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    public partial class ConnectForm : MaterialForm
    {

        public string Username
        {
            get
            {
                return usernameSingleLineTextField.Text.Trim();
            }
        }

        public string ServerPassword
        {
            get
            {
                return serverPasswordSingleLineTextField.Text;
            }
        }

        public ConnectForm(bool noPasswordMode)
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
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

        private void AcceptInput()
        {
            if (Username.Length <= 0)
                MessageBox.Show(Translator.GetTranslation("PLEASE_TYPE_IN_USERNAME"), Translator.GetTranslation("INPUT_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                bool success = true;
                if (serverPasswordSingleLineTextField.Visible && (ServerPassword.Trim().Length <= 0))
                    success = (MessageBox.Show(Translator.GetTranslation("SERVER_PASSWORD_FIELD_IS_EMPTY"), Translator.GetTranslation("SERVER_PASSWORD_FIELD_IS_EMPTY_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                if (success)
                {
                    if (!(tempUsernameCheckBox.Checked))
                        SAMP.Username = Username;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            AcceptInput();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void genericSingleLineTextField_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    AcceptInput();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}
