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
    /// Connect host form class
    /// </summary>
    public partial class ConnectHostForm : MaterialForm
    {
        /// <summary>
        /// Address
        /// </summary>
        public string HostAndPort
        {
            get
            {
                return hostAndPortSingleLineTextField.Text;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ConnectHostForm(Server server)
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
            if (server != null)
                hostAndPortSingleLineTextField.Text = server.IPPortString;
        }

        /// <summary>
        /// Connect to address click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void connectToAddressButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
