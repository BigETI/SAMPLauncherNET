using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using UpdaterNET;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Programm class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Registry key (dirty approach, can't access SAMP.RegistryKey)
        /// </summary>
        private const string RegistryKey = "HKEY_CURRENT_USER\\SOFTWARE\\SAMP";

        /// <summary>
        /// Configuration path (dirty approach, can't access SAMP.ConfigPath)
        /// </summary>
        private static readonly string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\GTA San Andreas User Files\\SAMP";

        /// <summary>
        /// Is SA:MP installed
        /// </summary>
        public static bool IsSAMPInstalled
        {
            get
            {
                bool ret = false;
                try
                {
                    ret = (Registry.GetValue(RegistryKey, "gta_sa_exe", null) != null) && (Registry.GetValue(RegistryKey, "PlayerName", null) != null) && Directory.Exists(ConfigPath);
                }
                catch
                {
                    //
                }
                return ret;
            }
        }

        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            Update update = new Update("https://raw.githubusercontent.com/BigETI/SAMPLauncherNET/master/update.json", Application.ExecutablePath);
            bool start_update = false;
            if (update.IsUpdateAvailable)
                start_update = (MessageBox.Show("A new update for SA:MP Launcher .NET is available.\r\nVersion: " + update.Version + "\r\n\r\nDo you want to install it now?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
            if (start_update)
            {
                try
                {
                    Process.Start("SAMPLauncherNETUpdater.exe");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Translator.TranslatorInterface = new TranslatorInterface();
                    if (IsSAMPInstalled)
                    {
                        if (!Directory.Exists(ConfigPath + "\\screens"))
                            Directory.CreateDirectory(ConfigPath + "\\screens");
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new MainForm());
                    }
                    else
                        MessageBox.Show("San Andreas Multiplayer is not installed.\r\nTo use this application, you have to install GTA San Andreas and San Andreas Multiplayer first.", "San Andreas Multiplayer is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception e)
                {
                    MessageBox.Show("A fatal error has occured:\r\n\r\n" + e.Message, "Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }
    }
}
