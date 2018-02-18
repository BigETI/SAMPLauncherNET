using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// GitHub latest release data contreact class
    /// </summary>
    [DataContract]
    public class GitHubLatestReleaseDataContract
    {
        /// <summary>
        /// URL
        /// </summary>
        [DataMember]
        private string url;

        /// <summary>
        /// Assets URL
        /// </summary>
        [DataMember(Name = "assets_url")]
        private string assetsURL;

        /// <summary>
        /// Upload URL
        /// </summary>
        [DataMember(Name = "upload_url")]
        private string uploadURL;

        /// <summary>
        /// HTML URL
        /// </summary>
        [DataMember(Name = "html_url")]
        private string htmlURL;

        /// <summary>
        /// ID
        /// </summary>
        [DataMember]
        private int id;

        /// <summary>
        /// Tag name
        /// </summary>
        [DataMember(Name = "tag_name")]
        private string tagName;

        /// <summary>
        /// Target commitish
        /// </summary>
        [DataMember(Name = "target_commitish")]
        private string targetCommitish;

        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// Draft
        /// </summary>
        [DataMember]
        private bool draft;

        /// <summary>
        /// Author
        /// </summary>
        [DataMember]
        private GitHubUserDataContract author;

        /// <summary>
        /// Pre-release
        /// </summary>
        [DataMember]
        private bool prerelease;

        /// <summary>
        /// Created at
        /// </summary>
        [DataMember(Name = "created_at")]
        private string createdAt;

        /// <summary>
        /// Published at
        /// </summary>
        [DataMember(Name = "published_at")]
        private string publishedAt;

        /// <summary>
        /// Assets
        /// </summary>
        [DataMember]
        private GitHubReleaseAssetDataContract[] assets;

        /// <summary>
        /// Tarball URL
        /// </summary>
        [DataMember(Name = "tarball_url")]
        private string tarballURL;

        /// <summary>
        /// Zipball URL
        /// </summary>
        [DataMember(Name = "zipball_url")]
        private string zipballURL;

        /// <summary>
        /// Body
        /// </summary>
        [DataMember]
        private string body;

        /// <summary>
        /// URL
        /// </summary>
        public string URL
        {
            get
            {
                return url;
            }
        }

        /// <summary>
        /// Assets URL
        /// </summary>
        public string AssetsURL
        {
            get
            {
                return assetsURL;
            }
        }

        /// <summary>
        /// Upload URL
        /// </summary>
        public string UploadURL
        {
            get
            {
                return uploadURL;
            }
        }

        /// <summary>
        /// HTML URL
        /// </summary>
        public string HTMLURL
        {
            get
            {
                return htmlURL;
            }
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Tag name
        /// </summary>
        public string TagName
        {
            get
            {
                return tagName;
            }
        }

        /// <summary>
        /// Target commitish
        /// </summary>
        public string TargetCommitish
        {
            get
            {
                return targetCommitish;
            }
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Draft
        /// </summary>
        public bool Draft
        {
            get
            {
                return draft;
            }
        }

        /// <summary>
        /// Author
        /// </summary>
        public GitHubUserDataContract Author
        {
            get
            {
                return author;
            }
        }

        /// <summary>
        /// Pre-release
        /// </summary>
        public bool Prerelease
        {
            get
            {
                return prerelease;
            }
        }

        /// <summary>
        /// Created at
        /// </summary>
        public string CreatedAt
        {
            get
            {
                return createdAt;
            }
        }

        /// <summary>
        /// Published at
        /// </summary>
        public string PublishedAt
        {
            get
            {
                return publishedAt;
            }
        }

        /// <summary>
        /// Assets
        /// </summary>
        public GitHubReleaseAssetDataContract[] Assets
        {
            get
            {
                return assets;
            }
        }

        /// <summary>
        /// Tarball URL
        /// </summary>
        public string TarballURL
        {
            get
            {
                return tarballURL;
            }
        }

        /// <summary>
        /// Zipball URL
        /// </summary>
        public string ZipballURL
        {
            get
            {
                return zipballURL;
            }
        }

        /// <summary>
        /// Body
        /// </summary>
        public string Body
        {
            get
            {
                return body;
            }
        }
    }
}
