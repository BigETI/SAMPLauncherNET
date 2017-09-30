using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using UpdaterNET;
using System.Diagnostics;

/// <summary>
/// SA:MP launcher .NET updater namespace
/// </summary>
namespace SAMPLauncherNETUpdater
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Animation state
        /// </summary>
        private uint animationState = 0U;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            TaskbarProgress.SetState(this, TaskbarProgress.TaskbarStates.Normal);
        }

        /// <summary>
        /// Close application
        /// </summary>
        private void CloseApp()
        {
            Process.Start("SAMPLauncherNET.exe");
            Application.Exit();
        }

        /// <summary>
        /// Main form load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTask update = new UpdateTask("https://raw.githubusercontent.com/BigETI/SAMPLauncherNET/master/update.json", Directory.GetCurrentDirectory() + "\\SAMPLauncherNET.exe");
            update.DownloadProgressChanged += OnDownloadProgressChanged;
            update.UpdateTaskFinished += OnUpdateTaskFinished;
            if (update.IsUpdateAvailable)
                update.InstallUpdates();
            else
                CloseApp();
        }

        /// <summary>
        /// On download progress changed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Download progress changed event arguments</param>
        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgressBar.Maximum = (int)(e.TotalBytesToReceive);
            downloadProgressBar.Value = (int)(e.BytesReceived);
            TaskbarProgress.SetValue(this, e.BytesReceived, e.TotalBytesToReceive);
        }

        /// <summary>
        /// On updates installed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Update task finished event arguments</param>
        private void OnUpdateTaskFinished(object sender, UpdateTaskFinishedEventArgs e)
        {
            if (e.IsError)
                MessageBox.Show(e.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CloseApp();
        }

        /// <summary>
        /// Animation timer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationState++;
            if (animationState > 3U)
                animationState = 0U;
            progressLabel.Text = "Updating" + new string('.', (int)animationState);
        }

        /// <summary>
        /// Main form form closing event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Form closing event arguments</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool cancel = false;
            if (e.CloseReason == CloseReason.UserClosing)
                cancel = (MessageBox.Show("Do you really want to cancel the update?", "Cancel update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
            e.Cancel = cancel;
        }
    }
}
