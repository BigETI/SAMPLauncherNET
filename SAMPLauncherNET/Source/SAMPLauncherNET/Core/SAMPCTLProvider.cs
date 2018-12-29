using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using UpdaterNET;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// sampctl provider class
    /// </summary>
    public static class SAMPCTLProvider
    {
        /// <summary>
        /// sampctl file name
        /// </summary>
        public static readonly string SAMPCTLFileName = "sampctl.exe";

        /// <summary>
        /// sampctl path
        /// </summary>
        public static readonly string SAMPCTLPath = "./" + SAMPCTLFileName;

        /// <summary>
        /// sampctl archive file name
        /// </summary>
        public static readonly string SAMPCTLArchiveFileName = "sampctl.tar.gz";

        /// <summary>
        /// sampctl download path
        /// </summary>
        public static readonly string SAMPCTLDownloadPath = "./downloads/" + SAMPCTLArchiveFileName;

        /// <summary>
        /// sampctl URI
        /// </summary>
        public static readonly string SAMPCTLURI = "http://sampctl.com/";

        /// <summary>
        /// sampctl info path
        /// </summary>
        private static readonly string SAMPCTLInfoPath = "./sampctl-info.json";

        /// <summary>
        /// GitHub API URI
        /// </summary>
        private static readonly string GitHubAPIURI = "https://api.github.com/repos/Southclaws/sampctl/releases/latest";

        /// <summary>
        /// Serializer
        /// </summary>
        private static readonly DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GitHubLatestReleaseDataContract));

        /// <summary>
        /// Last release information
        /// </summary>
        private static GitHubLatestReleaseDataContract lastReleaseInfo;

        /// <summary>
        /// Latest release information
        /// </summary>
        private static GitHubLatestReleaseDataContract latestReleaseInfo;

        /// <summary>
        /// Update sampctl
        /// </summary>
        /// <returns>"true" if sampctl is up to date, otherwise "false"</returns>
        public static bool Update()
        {
            bool ret = false;
            if (lastReleaseInfo == null)
            {
                if (File.Exists(SAMPCTLInfoPath))
                {
                    try
                    {
                        using (FileStream stream = File.Open(SAMPCTLInfoPath, FileMode.Open, FileAccess.Read))
                        {
                            lastReleaseInfo = serializer.ReadObject(stream) as GitHubLatestReleaseDataContract;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                        MessageBox.Show(e.Message, Translator.GetTranslation("SAMPCTL_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (latestReleaseInfo == null)
            {
                using (WebClientEx wc = new WebClientEx(3000))
                {
                    wc.Headers.Set(HttpRequestHeader.Accept, "application/json");
                    wc.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/3.0 (compatible; SA:MP launcher .NET)");
                    try
                    {
                        using (MemoryStream stream = new MemoryStream(wc.DownloadData(GitHubAPIURI)))
                        {
                            latestReleaseInfo = serializer.ReadObject(stream) as GitHubLatestReleaseDataContract;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                        MessageBox.Show(e.Message, Translator.GetTranslation("SAMPCTL_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (latestReleaseInfo != null)
            {
                bool download_file = ((lastReleaseInfo == null) ? true : ((lastReleaseInfo.TagName == latestReleaseInfo.TagName) ? (!(File.Exists(SAMPCTLDownloadPath))) : true));
                if (download_file)
                {
                    GitHubReleaseAssetDataContract asset = null;
                    string sub_name = (Environment.Is64BitOperatingSystem ? "windows_amd64" : "windows_386");
                    foreach (GitHubReleaseAssetDataContract a in latestReleaseInfo.Assets)
                    {
                        if (a.Name.Contains(sub_name))
                        {
                            asset = a;
                            break;
                        }
                    }
                    if (asset == null)
                    {
                        MessageBox.Show(Translator.GetTranslation("SAMPCTL_MISSING_ASSET"), Translator.GetTranslation("SAMPCTL_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DownloadProgressForm dpf = new DownloadProgressForm(asset.BrowserDownloadURL, Path.GetFullPath(SAMPCTLDownloadPath));
                        ret = (dpf.ShowDialog() == DialogResult.OK);
                    }
                }
                else
                {
                    ret = true;
                }
                if (ret && (download_file ? true : (!(File.Exists(SAMPCTLPath)))))
                {
                    try
                    {
                        if (File.Exists(SAMPCTLDownloadPath))
                        {
                            using (FileStream archive_file_stream = File.Open(SAMPCTLDownloadPath, FileMode.Open, FileAccess.Read))
                            {
                                using (GZipInputStream gzip_stream = new GZipInputStream(archive_file_stream))
                                {
                                    using (TarInputStream tar_stream = new TarInputStream(gzip_stream))
                                    {
                                        TarEntry tar_entry;
                                        while ((tar_entry = tar_stream.GetNextEntry()) != null)
                                        {
                                            if (!(tar_entry.IsDirectory))
                                            {
                                                if (tar_entry.Name == SAMPCTLFileName)
                                                {
                                                    if (File.Exists(SAMPCTLPath))
                                                    {
                                                        File.Delete(SAMPCTLPath);
                                                    }
                                                    using (FileStream file_stream = File.Open(SAMPCTLPath, FileMode.Create))
                                                    {
                                                        tar_stream.CopyEntryContents(file_stream);
                                                        ret = true;
                                                    }
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            ret = false;
                        }
                        if (!ret)
                        {
                            MessageBox.Show(Translator.GetTranslation("SAMPCTL_UNZIP_ERROR"), Translator.GetTranslation("SAMPCTL_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                        MessageBox.Show(e.Message, Translator.GetTranslation("SAMPCTL_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (ret)
                    {
                        try
                        {
                            if (File.Exists(SAMPCTLInfoPath))
                            {
                                File.Delete(SAMPCTLInfoPath);
                            }
                            using (FileStream stream = File.Open(SAMPCTLInfoPath, FileMode.Create))
                            {
                                serializer.WriteObject(stream, latestReleaseInfo);
                            }
                        }
                        catch (Exception e)
                        {
                            ret = false;
                            Console.Error.WriteLine(e);
                            MessageBox.Show(e.Message, Translator.GetTranslation("SAMPCTL_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                ret = true;
            }
            return ret;
        }
    }
}
