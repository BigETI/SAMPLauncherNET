using MetroFramework.Forms;
using MetroTranslatorStyler;
using System;
using System.Windows.Forms;

namespace SAMPLauncherNET
{
    public partial class ConnectForm : MetroForm
    {

        public string Username
        {
            get
            {
                return usernameTextBox.Text.Trim();
            }
        }

        public ConnectForm()
        {
            InitializeComponent();
            TranslatorStyler.LoadTranslationStyle(this, TranslatorStyler.TranslatorStylerInterface);
            usernameTextBox.Text = Utils.Username;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (Username.Length <= 0)
                MessageBox.Show("Please type in an username.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!(tempUsernameCheckBox.Checked))
                    Utils.Username = Username;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
