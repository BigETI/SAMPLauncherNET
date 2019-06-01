using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

/// <summary>
/// SAMP Launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Update notification form
    /// </summary>
    public partial class UpdateNotificationForm : MaterialForm
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public UpdateNotificationForm(string version)
        {
            InitializeComponent();
            Utils.Translator.TranslateControls(this);
            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            string update_notification;
            if (Utils.Translator.TryTranslate("{$UPDATE_NOTIFICATION$}", out update_notification))
            {
                updateNotificationLabel.Text = string.Format(update_notification, version);
            }
        }

        /// <summary>
        /// Yes button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void yesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        /// <summary>
        /// No button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void noButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
