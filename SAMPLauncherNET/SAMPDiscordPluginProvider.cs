using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// SA:MP Discord Rich Presence plugin provider class
    /// </summary>
    public static class SAMPDiscordPluginProvider
    {
        /// <summary>
        /// SA:MP Discord Rich Presence plugin file name
        /// </summary>
        public static readonly string SAMPDiscordPluginFileName = "samp-discord-plugin.asi";

        /// <summary>
        /// SA:MP Discord Rich Presence plugin path
        /// </summary>
        public static readonly string SAMPDiscordPluginPath = "./" + SAMPDiscordPluginFileName;

        /// <summary>
        /// SA:MP Discord Rich Presence plugin download path
        /// </summary>
        public static readonly string SAMPDiscordPluginDownloadPath = "./downloads/" + SAMPDiscordPluginFileName;

        /// <summary>
        /// SA:MP Discord Rich Presence plugin info path
        /// </summary>
        private static readonly string SAMPDiscordPluginInfoPath = "./samp-discord-plugin-info.json";

        /// <summary>
        /// GitHub API URI
        /// </summary>
        private static readonly string GitHubAPIURI = "https://api.github.com/repos/Hual/samp-discord-plugin/releases/latest";

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
                if (File.Exists(SAMPDiscordPluginPath))
                {
                    try
                    {
                        using (FileStream stream = File.Open(SAMPDiscordPluginInfoPath, FileMode.Open))
                        {
                            lastReleaseInfo = serializer.ReadObject(stream) as GitHubLatestReleaseDataContract;
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, Translator.GetTranslation("SAMP_DISCORD_PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show(e.Message, Translator.GetTranslation("SAMP_DISCORD_PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (latestReleaseInfo != null)
            {
                bool download_file = ((lastReleaseInfo == null) ? true : ((lastReleaseInfo.TagName == latestReleaseInfo.TagName) ? (!(File.Exists(SAMPDiscordPluginDownloadPath))) : true));
                if (download_file)
                {
                    GitHubReleaseAssetDataContract asset = null;
                    foreach (GitHubReleaseAssetDataContract a in latestReleaseInfo.Assets)
                    {
                        if (a.Name.Contains(SAMPDiscordPluginFileName))
                        {
                            asset = a;
                            break;
                        }
                    }
                    if (asset == null)
                    {
                        MessageBox.Show(Translator.GetTranslation("SAMP_DISCORD_PLUGIN_MISSING_ASSET"), Translator.GetTranslation("SAMP_DISCORD_PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DownloadProgressForm dpf = new DownloadProgressForm(asset.BrowserDownloadURL, SAMPDiscordPluginFileName);
                        ret = (dpf.ShowDialog() == DialogResult.OK);
                    }
                }
                else
                {
                    ret = true;
                }
                if (ret && (download_file ? true : (!(File.Exists(SAMPDiscordPluginPath)))))
                {
                    try
                    {
                        if (File.Exists(SAMPDiscordPluginDownloadPath))
                        {
                            File.Copy(SAMPDiscordPluginDownloadPath, SAMPDiscordPluginPath);
                        }
                        else
                        {
                            ret = false;
                        }
                        if (!ret)
                        {
                            MessageBox.Show(Translator.GetTranslation("SAMP_DISCORD_PLUGIN_COPY_ERROR"), Translator.GetTranslation("SAMP_DISCORD_PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, Translator.GetTranslation("SAMP_DISCORD_PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (ret)
                    {
                        try
                        {
                            if (File.Exists(SAMPDiscordPluginInfoPath))
                            {
                                File.Delete(SAMPDiscordPluginInfoPath);
                            }
                            using (FileStream stream = File.Open(SAMPDiscordPluginInfoPath, FileMode.Create))
                            {
                                serializer.WriteObject(stream, latestReleaseInfo);
                            }
                        }
                        catch (Exception e)
                        {
                            ret = false;
                            MessageBox.Show(e.Message, Translator.GetTranslation("SAMP_DISCORD_PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
