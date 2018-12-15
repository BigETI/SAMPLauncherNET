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
                    Console.Error.WriteLine(e);
                }
                return ret;
            }
        }

        /// <summary>
        /// Launch latest SA:MP installer
        /// </summary>
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
                Console.Error.WriteLine(e);
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Console.Error.WriteLine(e.Error.Message);
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
                    Console.Error.WriteLine(ex);
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
#if !DEBUG
            GitHubUpdateTask update = new GitHubUpdateTask("BigETI", "SAMPLauncherNET");
            if (update.IsUpdateAvailable)
            {
                if (Utils.ExportResource("SAMPLauncherNET.PreBuilds.SAMPLauncherNETUpdater.exe", Path.Combine(Environment.CurrentDirectory, "SAMPLauncherNETUpdater.exe")))
                {
                    try
                    {
                        Process.Start("SAMPLauncherNETUpdater.exe");
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                        MessageBox.Show(e.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
#endif
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
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                MessageBox.Show("A fatal error has occured:\r\n\r\n" + e.Message, "Fatal error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
#if !DEBUG
            }
            if (installerPath != null)
            {
                while (isDownloading)
                {
                    Thread.Sleep(200);
                }
            }
#endif
            Application.Exit();
        }
    }
}
