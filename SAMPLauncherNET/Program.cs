using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Threading;
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
        /// Installer path
        /// </summary>
        private static string installerPath;

        /// <summary>
        /// Is downloading
        /// </summary>
        private static bool isDownloading;

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
                    ret = (Registry.GetValue(RegistryKey, "gta_sa_exe", null) != null) && Directory.Exists(ConfigPath);
                    if (ret && (Registry.GetValue(RegistryKey, "PlayerName", null) == null))
                    {
                        Registry.SetValue(RegistryKey, "PlayerName", "", RegistryValueKind.String);
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
                return ret;
            }
        }

        private static void LaunchLatestSAMPInstaller()
        {
            try
            {
                string uri = null;
                using (WebClient wc = new WebClientEx(5000))
                {
                    wc.Headers.Set(HttpRequestHeader.ContentType, "text/html");
                    wc.Headers.Set(HttpRequestHeader.Accept, "text/html, */*");
                    wc.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/3.0 (compatible; SA:MP launcher .NET)");
                    using (MemoryStream stream = new MemoryStream(wc.DownloadData("https://raw.githubusercontent.com/BigETI/SAMPLauncherNET/master/versions.json")))
                    {
                        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<SAMPVersionDataContract>));
                        List<SAMPVersionDataContract> samp_versions = serializer.ReadObject(stream) as List<SAMPVersionDataContract>;
                        if (samp_versions != null)
                        {
                            if (samp_versions.Count > 0)
                            {
                                samp_versions.Sort();
                                uri = samp_versions[0].InstallationURI;
                            }
                        }
                    }
                }
                if (uri != null)
                {
                    WebClient wc = new WebClient();
                    wc.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/3.0 (compatible; SA:MP launcher .NET)");
                    wc.DownloadFileCompleted += OnDownloadFileCompleted;
                    installerPath = Path.GetFullPath("./downloads/installer.exe");
                    string directory = Path.GetFullPath("./downloads");
                    if (File.Exists(installerPath))
                    {
                        File.Delete(installerPath);
                    }
                    else if (!(Directory.Exists(directory)))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    isDownloading = true;
                    wc.DownloadFileAsync(new Uri(uri), installerPath);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// On download file completed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Asynchronous completed event arguments</param>
        private static void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //MessageBox.Show(e.Error.Message, Translator.GetTranslation("DOWNLOAD_FAILED_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(e.Cancelled))
            {
                try
                {
                    if (File.Exists(installerPath))
                    {
                        Process.Start(installerPath);
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
            isDownloading = false;
        }

        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*try
            {
                DataContractJsonSerializer s = new DataContractJsonSerializer(typeof(List<SAMPVersion>));
                using (FileStream stream = File.Open("./versions.json", FileMode.Create))
                {
                    s.WriteObject(stream, SAMPProvider.Versions);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }*/
            UpdateTask update = new UpdateTask("https://raw.githubusercontent.com/BigETI/SAMPLauncherNET/master/update.json", Application.ExecutablePath);
            bool start_update = false;
            if (update.IsUpdateAvailable)
            {
                start_update = (MessageBox.Show("A new update for SA:MP Launcher .NET is available.\r\nVersion: " + update.Version + "\r\n\r\nDo you want to install it now?", "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
            }
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
                        {
                            Directory.CreateDirectory(ConfigPath + "\\screens");
                        }
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new MainForm());
                    }
                    else
                    {
                        LaunchLatestSAMPInstaller();
                        //MessageBox.Show("San Andreas Multiplayer is not installed.\r\nTo use this application, you have to install GTA San Andreas and San Andreas Multiplayer first.", "San Andreas Multiplayer is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("A fatal error has occured:\r\n\r\n" + e.Message, "Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (installerPath != null)
            {
                while (isDownloading)
                {
                    Thread.Sleep(200);
                }
            }
            Application.Exit();
        }
    }
}
