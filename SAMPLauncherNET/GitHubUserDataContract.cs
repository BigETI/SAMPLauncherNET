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
            get
            {
                return login;
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
        /// Avatar URL
        /// </summary>
        public string AvatarURL
        {
            get
            {
                return avatarURL;
            }
        }

        /// <summary>
        /// Gravar URL
        /// </summary>
        public string GravatarURL
        {
            get
            {
                return gravatarURL;
            }
        }

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
        /// Followers URL
        /// </summary>
        public string FollowersURL
        {
            get
            {
                return followersURL;
            }
        }

        /// <summary>
        /// Following URL
        /// </summary>
        public string FollowingURL
        {
            get
            {
                return followingURL;
            }
        }

        /// <summary>
        /// Gists URL
        /// </summary>
        public string GistsURL
        {
            get
            {
                return gistsURL;
            }
        }

        /// <summary>
        /// Starred URL
        /// </summary>
        public string StarredURL
        {
            get
            {
                return starredURL;
            }
        }

        /// <summary>
        /// Subscriptions URL
        /// </summary>
        public string SubscriptionsURL
        {
            get
            {
                return subscriptionsURL;
            }
        }

        /// <summary>
        /// Organizations URL
        /// </summary>
        public string OrganizationsURL
        {
            get
            {
                return organizationsURL;
            }
        }

        /// <summary>
        /// Repos URL
        /// </summary>
        public string ReposURL
        {
            get
            {
                return reposURL;
            }
        }

        /// <summary>
        /// Events URL
        /// </summary>
        public string EventsURL
        {
            get
            {
                return eventsURL;
            }
        }

        /// <summary>
        /// Received events URL
        /// </summary>
        public string ReceivedEventsURL
        {
            get
            {
                return receivedEventsURL;
            }
        }

        /// <summary>
        /// Type
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// Site admin
        /// </summary>
        public string SiteAdmin
        {
            get
            {
                return siteAdmin;
            }
        }
    }
}
