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
            get => url;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get => id;
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get => name;
        }

        /// <summary>
        /// Label
        /// </summary>
        public string Label
        {
            get => label;
        }

        /// <summary>
        /// Uploader
        /// </summary>
        public GitHubUserDataContract Uploader
        {
            get => uploader;
        }

        /// <summary>
        /// Content type
        /// </summary>
        public string ContentType
        {
            get => contentType;
        }

        /// <summary>
        /// State
        /// </summary>
        public string State
        {
            get => state;
        }

        /// <summary>
        /// Size
        /// </summary>
        public int Size
        {
            get => size;
        }

        /// <summary>
        /// Download count
        /// </summary>
        public int DownloadCount
        {
            get => downloadCount;
        }

        /// <summary>
        /// Created at
        /// </summary>
        public string CreatedAt
        {
            get => createdAt;
        }

        /// <summary>
        /// Updated at
        /// </summary>
        public string UpdatedAt
        {
            get => updatedAt;
        }

        /// <summary>
        /// Browser download URL
        /// </summary>
        public string BrowserDownloadURL
        {
            get => browserDownloadURL;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="id">ID</param>
        /// <param name="name">Name</param>
        /// <param name="label">Label</param>
        /// <param name="uploader">Uploader</param>
        /// <param name="contentType">Content type</param>
        /// <param name="state">State</param>
        /// <param name="size">Size</param>
        /// <param name="downloadCount">Download count</param>
        /// <param name="createdAt">Created at</param>
        /// <param name="updatedAt">Updated at</param>
        /// <param name="browserDownloadURL">Browser download URL</param>
        public GitHubReleaseAssetDataContract(string url, int id, string name, string label, GitHubUserDataContract uploader, string contentType, string state, int size, int downloadCount, string createdAt, string updatedAt, string browserDownloadURL)
        {
            this.url = url;
            this.id = id;
            this.name = name;
            this.label = label;
            this.uploader = uploader;
            this.contentType = contentType;
            this.state = state;
            this.size = size;
            this.downloadCount = downloadCount;
            this.createdAt = createdAt;
            this.updatedAt = updatedAt;
            this.browserDownloadURL = browserDownloadURL;
        }
    }
}
