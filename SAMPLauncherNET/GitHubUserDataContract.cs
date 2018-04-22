using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// GitHub user data contract
    /// </summary>
    [DataContract]
    public class GitHubUserDataContract
    {
        /// <summary>
        /// Login
        /// </summary>
        [DataMember]
        private string login;

        /// <summary>
        /// ID
        /// </summary>
        [DataMember]
        private int id;

        /// <summary>
        /// Avatar URL
        /// </summary>
        [DataMember(Name = "avatar_url")]
        private string avatarURL;

        /// <summary>
        /// Gravar URL
        /// </summary>
        [DataMember(Name = "gravatar_id")]
        private string gravatarURL;

        /// <summary>
        /// URL
        /// </summary>
        [DataMember]
        private string url;

        /// <summary>
        /// HTML URL
        /// </summary>
        [DataMember(Name = "html_url")]
        private string htmlURL;

        /// <summary>
        /// Followers URL
        /// </summary>
        [DataMember(Name = "followers_url")]
        private string followersURL;

        /// <summary>
        /// Following URL
        /// </summary>
        [DataMember(Name = "following_url")]
        private string followingURL;

        /// <summary>
        /// Gists URL
        /// </summary>
        [DataMember(Name = "gists_url")]
        private string gistsURL;

        /// <summary>
        /// Starred URL
        /// </summary>
        [DataMember(Name = "starred_url")]
        private string starredURL;

        /// <summary>
        /// Subscriptions URL
        /// </summary>
        [DataMember(Name = "subscriptions_url")]
        private string subscriptionsURL;

        /// <summary>
        /// Organizations URL
        /// </summary>
        [DataMember(Name = "organizations_url")]
        private string organizationsURL;

        /// <summary>
        /// Repos URL
        /// </summary>
        [DataMember(Name = "repos_url")]
        private string reposURL;

        /// <summary>
        /// Events URL
        /// </summary>
        [DataMember(Name = "events_url")]
        private string eventsURL;

        /// <summary>
        /// Received events URL
        /// </summary>
        [DataMember(Name = "received_events_url")]
        private string receivedEventsURL;

        /// <summary>
        /// Type
        /// </summary>
        [DataMember]
        private string type;

        /// <summary>
        /// Site admin
        /// </summary>
        [DataMember(Name = "site_admin")]
        private string siteAdmin;

        /// <summary>
        /// Login
        /// </summary>
        public string Login
        {
            get => login;
        }

        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            get => id;
        }

        /// <summary>
        /// Avatar URL
        /// </summary>
        public string AvatarURL
        {
            get => avatarURL;
        }

        /// <summary>
        /// Gravar URL
        /// </summary>
        public string GravatarURL
        {
            get => gravatarURL;
        }

        /// <summary>
        /// URL
        /// </summary>
        public string URL
        {
            get => url;
        }

        /// <summary>
        /// HTML URL
        /// </summary>
        public string HTMLURL
        {
            get => htmlURL;
        }

        /// <summary>
        /// Followers URL
        /// </summary>
        public string FollowersURL
        {
            get => followersURL;
        }

        /// <summary>
        /// Following URL
        /// </summary>
        public string FollowingURL
        {
            get => followingURL;
        }

        /// <summary>
        /// Gists URL
        /// </summary>
        public string GistsURL
        {
            get => gistsURL;
        }

        /// <summary>
        /// Starred URL
        /// </summary>
        public string StarredURL
        {
            get => starredURL;
        }

        /// <summary>
        /// Subscriptions URL
        /// </summary>
        public string SubscriptionsURL
        {
            get => subscriptionsURL;
        }

        /// <summary>
        /// Organizations URL
        /// </summary>
        public string OrganizationsURL
        {
            get => organizationsURL;
        }

        /// <summary>
        /// Repos URL
        /// </summary>
        public string ReposURL
        {
            get => reposURL;
        }

        /// <summary>
        /// Events URL
        /// </summary>
        public string EventsURL
        {
            get => eventsURL;
        }

        /// <summary>
        /// Received events URL
        /// </summary>
        public string ReceivedEventsURL
        {
            get => receivedEventsURL;
        }

        /// <summary>
        /// Type
        /// </summary>
        public string Type
        {
            get => type;
        }

        /// <summary>
        /// Site admin
        /// </summary>
        public string SiteAdmin
        {
            get => siteAdmin;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="login">Login</param>
        /// <param name="id">ID</param>
        /// <param name="avatarURL">Avatar URL</param>
        /// <param name="gravatarURL">Gravatr URL</param>
        /// <param name="url">URL</param>
        /// <param name="htmlURL">HTML URL</param>
        /// <param name="followersURL">Follower URL</param>
        /// <param name="followingURL">Following URL</param>
        /// <param name="gistsURL">Gists URL</param>
        /// <param name="starredURL">Starred URL</param>
        /// <param name="subscriptionsURL">Subscriptional URL</param>
        /// <param name="organizationsURL">Organization URL</param>
        /// <param name="reposURL">Repos URL</param>
        /// <param name="eventsURL">Event URL</param>
        /// <param name="receivedEventsURL">Recieved events URL</param>
        /// <param name="type">Type</param>
        /// <param name="siteAdmin">Site admin</param>
        public GitHubUserDataContract(string login, int id, string avatarURL, string gravatarURL, string url, string htmlURL, string followersURL, string followingURL, string gistsURL, string starredURL, string subscriptionsURL, string organizationsURL, string reposURL, string eventsURL, string receivedEventsURL, string type, string siteAdmin)
        {
            this.login = login;
            this.id = id;
            this.avatarURL = avatarURL;
            this.gravatarURL = gravatarURL;
            this.url = url;
            this.htmlURL = htmlURL;
            this.followersURL = followersURL;
            this.followingURL = followingURL;
            this.gistsURL = gistsURL;
            this.starredURL = starredURL;
            this.subscriptionsURL = subscriptionsURL;
            this.organizationsURL = organizationsURL;
            this.reposURL = reposURL;
            this.eventsURL = eventsURL;
            this.receivedEventsURL = receivedEventsURL;
            this.type = type;
            this.siteAdmin = siteAdmin;
        }
    }
}
