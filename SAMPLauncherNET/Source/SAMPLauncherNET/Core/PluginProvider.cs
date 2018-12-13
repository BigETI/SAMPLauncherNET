using System;
using System.Collections.Generic;
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
    /// Plugin provider class
    /// </summary>
    public static class PluginProvider
    {
        /// <summary>
        /// Serializer
        /// </summary>
        private static readonly DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(GitHubLatestReleaseDataContract));

        /// <summary>
        /// Installed plugins
        /// </summary>
        private static Dictionary<PluginDataContract, InstalledPlugin> installedPlugins = new Dictionary<PluginDataContract, InstalledPlugin>();

        /// <summary>
        /// Get download URL
        /// </summary>
        /// <param name="infoPath">Info path</param>
        /// <param name="githubAPIURL">GitHub API URL</param>
        /// <param name="lastReleaseInfo">Last release information</param>
        /// <param name="latestReleaseInfo">Latest release information</param>
        /// <returns>Download URL if successful, otherwise "null"</returns>
        private static string GetDownloadURL(string infoPath, string githubAPIURL, ref GitHubLatestReleaseDataContract lastReleaseInfo, ref GitHubLatestReleaseDataContract latestReleaseInfo)
        {
            string ret = null;
            if (lastReleaseInfo == null)
            {
                if (File.Exists(infoPath))
                {
                    try
                    {
                        using (FileStream stream = File.Open(infoPath, FileMode.Open))
                        {
                            lastReleaseInfo = serializer.ReadObject(stream) as GitHubLatestReleaseDataContract;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                        MessageBox.Show(e.Message, Translator.GetTranslation("PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        using (MemoryStream stream = new MemoryStream(wc.DownloadData(githubAPIURL)))
                        {
                            latestReleaseInfo = serializer.ReadObject(stream) as GitHubLatestReleaseDataContract;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                        MessageBox.Show(e.Message, Translator.GetTranslation("PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (latestReleaseInfo != null)
            {
                if (latestReleaseInfo.Assets != null)
                {
                    foreach (GitHubReleaseAssetDataContract asset in latestReleaseInfo.Assets)
                    {
                        if (asset != null)
                        {
                            if (asset.Name.ToLower().EndsWith(".asi"))
                            {
                                ret = asset.BrowserDownloadURL;
                                break;
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Update plugin
        /// </summary>
        /// <param name="plugin">Plugin</param>
        /// <returns>Installed plugin information if plugin is up to date, otherwise "null"</returns>
        public static InstalledPlugin Update(PluginDataContract plugin)
        {
            InstalledPlugin ret = null;
            if (plugin != null)
            {
                string download_path = null;
                string download_url = null;
                GitHubLatestReleaseDataContract last_release_info = null;
                GitHubLatestReleaseDataContract latest_release_info = null;
                if (plugin.Enabled)
                {
                    try
                    {
                        InstalledPlugin installed_plugin = null;
                        Uri uri = new Uri(plugin.URI);
                        if (!(Directory.Exists("./plugins")))
                        {
                            Directory.CreateDirectory("./plugins");
                        }
                        if (installedPlugins.ContainsKey(plugin))
                        {
                            installed_plugin = installedPlugins[plugin];
                        }
                        switch (plugin.Provider)
                        {
                            case EPluginProvider.URI:
                                if (uri.IsFile)
                                {
                                    if (!(File.Exists(plugin.URI)))
                                    {
                                        ret = new InstalledPlugin(plugin.URI);
                                    }
                                }
                                else
                                {
                                    download_path = Path.Combine(Path.GetFullPath("./plugins/"), uri.LocalPath);
                                    switch (plugin.UpdateFrequency)
                                    {
                                        case EUpdateFrequency.IfMissing:
                                        case EUpdateFrequency.WhenNewer:
                                            if (File.Exists(download_path))
                                            {
                                                ret = new InstalledPlugin(download_path);
                                                installedPlugins.Add(plugin, ret);
                                            }
                                            else
                                            {
                                                if (File.Exists(download_path))
                                                {
                                                    File.Delete(download_path);
                                                }
                                                download_url = plugin.URI;
                                            }
                                            break;
                                        case EUpdateFrequency.Always:
                                            download_url = plugin.URI;
                                            break;
                                    }
                                }
                                break;
                            case EPluginProvider.GitHub:
                                string github_user_repo = uri.AbsolutePath.Trim('/');
                                string github_api_url = "https://api.github.com/repos/" + github_user_repo + "/releases/latest";
                                download_path = Path.GetFullPath("./plugins/" + github_user_repo.Replace('/', '$') + ".asi");
                                string info_path = download_path + ".json";
                                if (installed_plugin != null)
                                {
                                    last_release_info = installed_plugin.LastReleaseInfo;
                                    latest_release_info = installed_plugin.LatestReleaseInfo;
                                }
                                switch (plugin.UpdateFrequency)
                                {
                                    case EUpdateFrequency.IfMissing:
                                        if (File.Exists(download_path))
                                        {
                                            ret = new InstalledPlugin(download_path);
                                        }
                                        else
                                        {
                                            download_url = GetDownloadURL(info_path, github_api_url, ref last_release_info, ref latest_release_info);
                                        }
                                        break;
                                    case EUpdateFrequency.WhenNewer:
                                        string dl_url = GetDownloadURL(info_path, github_api_url, ref last_release_info, ref latest_release_info);
                                        if (latest_release_info != null)
                                        {
                                            if (last_release_info != null)
                                            {
                                                if (last_release_info.TagName != latest_release_info.TagName)
                                                {
                                                    download_url = dl_url;
                                                }
                                                else
                                                {
                                                    ret = new InstalledPlugin(download_path);
                                                }
                                            }
                                            else
                                            {
                                                download_url = dl_url;
                                            }
                                        }
                                        break;
                                    case EUpdateFrequency.Always:
                                        download_url = GetDownloadURL(info_path, github_api_url, ref last_release_info, ref latest_release_info);
                                        break;
                                }
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e);
                        MessageBox.Show(e.Message, Translator.GetTranslation("PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if ((download_path != null) && (download_url != null))
                {
                    if (File.Exists(download_path))
                    {
                        File.Delete(download_path);
                    }
                    DownloadProgressForm dpf = new DownloadProgressForm(download_url, download_path);
                    if (latest_release_info != null)
                    {
                        last_release_info = latest_release_info;
                    }
                    if (dpf.ShowDialog() == DialogResult.OK)
                    {
                        ret = new InstalledPlugin(download_path, last_release_info, latest_release_info);
                        if (plugin.Provider == EPluginProvider.GitHub)
                        {
                            try
                            {
                                string info_path = download_path + ".json";
                                if (File.Exists(info_path))
                                {
                                    File.Delete(info_path);
                                }
                                using (FileStream stream = File.Open(info_path, FileMode.Create))
                                {
                                    serializer.WriteObject(stream, latest_release_info);
                                }
                            }
                            catch (Exception e)
                            {
                                Console.Error.WriteLine(e);
                                MessageBox.Show(e.Message, Translator.GetTranslation("PLUGIN_ERROR_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                if (ret != null)
                {
                    if (installedPlugins.ContainsKey(plugin))
                    {
                        installedPlugins[plugin] = ret;
                    }
                    else
                    {
                        installedPlugins.Add(plugin, ret);
                    }
                }
            }
            return ret;
        }
    }
}
