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
            get => url;
        }

        /// <summary>
        /// Assets URL
        /// </summary>
        public string AssetsURL
        {
            get => assetsURL;
        }

        /// <summary>
        /// Upload URL
        /// </summary>
        public string UploadURL
        {
            get => uploadURL;
        }

        /// <summary>
        /// HTML URL
        /// </summary>
        public string HTMLURL
        {
            get => htmlURL;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get => id;
        }

        /// <summary>
        /// Tag name
        /// </summary>
        public string TagName
        {
            get => tagName;
        }

        /// <summary>
        /// Target commitish
        /// </summary>
        public string TargetCommitish
        {
            get => targetCommitish;
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get => name;
        }

        /// <summary>
        /// Draft
        /// </summary>
        public bool Draft
        {
            get => draft;
        }

        /// <summary>
        /// Author
        /// </summary>
        public GitHubUserDataContract Author
        {
            get => author;
        }

        /// <summary>
        /// Pre-release
        /// </summary>
        public bool Prerelease
        {
            get => prerelease;
        }

        /// <summary>
        /// Created at
        /// </summary>
        public string CreatedAt
        {
            get => createdAt;
        }

        /// <summary>
        /// Published at
        /// </summary>
        public string PublishedAt
        {
            get => publishedAt;
        }

        /// <summary>
        /// Assets
        /// </summary>
        public GitHubReleaseAssetDataContract[] Assets
        {
            get => assets;
        }

        /// <summary>
        /// Tarball URL
        /// </summary>
        public string TarballURL
        {
            get => tarballURL;
        }

        /// <summary>
        /// Zipball URL
        /// </summary>
        public string ZipballURL
        {
            get => zipballURL;
        }

        /// <summary>
        /// Body
        /// </summary>
        public string Body
        {
            get => body;
        }

        /// <summary>
        /// Constrcutor
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="assetsURL">Assets URL</param>
        /// <param name="uploadURL">Upload URL</param>
        /// <param name="htmlURL">HTML URL</param>
        /// <param name="id">ID</param>
        /// <param name="tagName">Tag name</param>
        /// <param name="targetCommitish">Target commitish</param>
        /// <param name="name">Name</param>
        /// <param name="draft">Draft</param>
        /// <param name="author">Author</param>
        /// <param name="prerelease">Pre-release</param>
        /// <param name="createdAt">Created at</param>
        /// <param name="publishedAt">Published at</param>
        /// <param name="assets">Assets</param>
        /// <param name="tarballURL">Tarball URL</param>
        /// <param name="zipballURL">ZIPball URL</param>
        /// <param name="body">Body</param>
        public GitHubLatestReleaseDataContract(string url, string assetsURL, string uploadURL, string htmlURL, int id, string tagName, string targetCommitish, string name, bool draft, GitHubUserDataContract author, bool prerelease, string createdAt, string publishedAt, GitHubReleaseAssetDataContract[] assets, string tarballURL, string zipballURL, string body)
        {
            this.url = url;
            this.assetsURL = assetsURL;
            this.uploadURL = uploadURL;
            this.htmlURL = htmlURL;
            this.id = id;
            this.tagName = tagName;
            this.targetCommitish = targetCommitish;
            this.name = name;
            this.draft = draft;
            this.author = author;
            this.prerelease = prerelease;
            this.createdAt = createdAt;
            this.publishedAt = publishedAt;
            this.assets = assets;
            this.tarballURL = tarballURL;
            this.zipballURL = zipballURL;
            this.body = body;
        }
    }
}
