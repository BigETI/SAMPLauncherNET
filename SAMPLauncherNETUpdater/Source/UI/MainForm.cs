using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Net;
using UpdaterNET;
using System.Diagnostics;
using System.Text.RegularExpressions;

/// <summary>
/// SA:MP launcher .NET updater UI namespace
/// </summary>
namespace SAMPLauncherNETUpdater.UI
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Animation state
        /// </summary>
        private uint animationState;

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
        /// <param name="launchExe">Launch executable</param>
        private static void CloseApp(bool launchExe)
        {
            if (launchExe)
            {
                Process.Start("SAMPLauncherNET.exe");
            }
            Application.Exit();
        }

        /// <summary>
        /// Close application
        /// </summary>
        private static void CloseApp()
        {
            CloseApp(true);
        }

        /// <summary>
        /// Main form load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                GitHubUpdateTask update = new GitHubUpdateTask("BigETI", "SAMPLauncherNET", @".*\.exe", RegexOptions.IgnoreCase);
                update.DownloadProgressChanged += OnDownloadProgressChanged;
                update.UpdateTaskFinished += OnUpdateTaskFinished;
                if (update.IsUpdateAvailable)
                {
                    update.InstallUpdates();
                }
                else
                {
                    CloseApp();
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseApp(false);
            }
        }

        /// <summary>
        /// On download progress changed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Download progress changed event arguments</param>
        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                downloadProgressBar.Maximum = (int)(e.TotalBytesToReceive);
                downloadProgressBar.Value = (int)(e.BytesReceived);
                TaskbarProgress.SetValue(this, e.BytesReceived, e.TotalBytesToReceive);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseApp(false);
            }
        }

        /// <summary>
        /// On updates installed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Update task finished event arguments</param>
        private void OnUpdateTaskFinished(object sender, UpdateTaskFinishedEventArgs e)
        {
            try
            {
                bool launch_exe = true;
                if (e.IsError)
                {
                    launch_exe = false;
                    MessageBox.Show(e.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (e.IsCanceled)
                {
                    launch_exe = false;
                    MessageBox.Show("Update has been canceled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CloseApp(launch_exe);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseApp(false);
            }
        }

        /// <summary>
        /// Animation timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                animationState++;
                if (animationState > 3U)
                {
                    animationState = 0U;
                }
                progressLabel.Text = "Updating" + new string('.', (int)animationState);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseApp(false);
            }
        }

        /// <summary>
        /// Main form form closing event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Form closing event arguments</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                bool cancel = false;
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    cancel = (MessageBox.Show("Do you really want to cancel the update?", "Cancel update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
                }
                e.Cancel = cancel;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseApp(false);
            }
        }
    }
}
