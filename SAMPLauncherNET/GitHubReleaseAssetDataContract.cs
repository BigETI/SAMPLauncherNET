using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// GitHub release asset data contract
    /// </summary>
    [DataContract]
    public class GitHubReleaseAssetDataContract
    {
        /// <summary>
        /// URL
        /// </summary>
        [DataMember]
        private string url;

        /// <summary>
        /// ID
        /// </summary>
        [DataMember]
        private int id;

        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// Label
        /// </summary>
        [DataMember]
        private string label;

        /// <summary>
        /// Uploader
        /// </summary>
        [DataMember]
        private GitHubUserDataContract uploader;

        /// <summary>
        /// Content type
        /// </summary>
        [DataMember(Name = "content_type")]
        private string contentType;

        /// <summary>
        /// State
        /// </summary>
        [DataMember]
        private string state;

        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        private int size;

        /// <summary>
        /// Download count
        /// </summary>
        [DataMember(Name = "download_count")]
        private int downloadCount;

        /// <summary>
        /// Created at
        /// </summary>
        [DataMember(Name = "created_at")]
        private string createdAt;

        /// <summary>
        /// Updated at
        /// </summary>
        [DataMember(Name = "updated_at")]
        private string updatedAt;

        /// <summary>
        /// Browser download URL
        /// </summary>
        [DataMember(Name = "browser_download_url")]
        private string browserDownloadURL;

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
        /// Label
        /// </summary>
        public string Label
        {
            get
            {
                return label;
            }
        }

        /// <summary>
        /// Uploader
        /// </summary>
        public GitHubUserDataContract Uploader
        {
            get
            {
                return uploader;
            }
        }

        /// <summary>
        /// Content type
        /// </summary>
        public string ContentType
        {
            get
            {
                return contentType;
            }
        }

        /// <summary>
        /// State
        /// </summary>
        public string State
        {
            get
            {
                return state;
            }
        }

        /// <summary>
        /// Size
        /// </summary>
        public int Size
        {
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Download count
        /// </summary>
        public int DownloadCount
        {
            get
            {
                return downloadCount;
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
        /// Updated at
        /// </summary>
        public string UpdatedAt
        {
            get
            {
                return updatedAt;
            }
        }

        /// <summary>
        /// Browser download URL
        /// </summary>
        public string BrowserDownloadURL
        {
            get
            {
                return browserDownloadURL;
            }
        }
    }
}
