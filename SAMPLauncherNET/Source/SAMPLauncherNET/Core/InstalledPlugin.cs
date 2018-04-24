using UpdaterNET;
/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Installed plugin class
    /// </summary>
    public class InstalledPlugin
    {
        /// <summary>
        /// Path
        /// </summary>
        private string path = "";

        /// <summary>
        /// Last release information
        /// </summary>
        private GitHubLatestReleaseDataContract lastReleaseInfo;

        /// <summary>
        /// Latest release information
        /// </summary>
        private GitHubLatestReleaseDataContract latestReleaseInfo;

        /// <summary>
        /// Path
        /// </summary>
        public string Path
        {
            get
            {
                return path;
            }
        }

        /// <summary>
        /// Last release information
        /// </summary>
        public GitHubLatestReleaseDataContract LastReleaseInfo
        {
            get
            {
                return lastReleaseInfo;
            }
        }

        /// <summary>
        /// Latest release information
        /// </summary>
        public GitHubLatestReleaseDataContract LatestReleaseInfo
        {
            get
            {
                return latestReleaseInfo;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path">Path</param>
        public InstalledPlugin(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path">Path</param>
        /// <param name="lastReleaseInfo">Last release information</param>
        /// <param name="latestReleaseInfo">Latest release information</param>
        public InstalledPlugin(string path, GitHubLatestReleaseDataContract lastReleaseInfo, GitHubLatestReleaseDataContract latestReleaseInfo)
        {
            this.path = path;
            this.lastReleaseInfo = lastReleaseInfo;
            this.latestReleaseInfo = latestReleaseInfo;
        }
    }
}
