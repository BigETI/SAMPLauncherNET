using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// SA:MP API server data contract class
    /// </summary>
    [DataContract]
    public class SAMPAPIServerDataContract
    {
        /// <summary>
        /// Host
        /// </summary>
        [DataMember(Name = "ip")]
        private string host = "";

        /// <summary>
        /// Hostname
        /// </summary>
        [DataMember(Name = "hn")]
        private string hostname = "";

        /// <summary>
        /// Player count
        /// </summary>
        [DataMember(Name = "pc")]
        private ushort playerCount = 0;

        /// <summary>
        /// Maximal players
        /// </summary>
        [DataMember(Name = "pm")]
        private ushort maxPlayers = 0;

        /// <summary>
        /// Gamemode
        /// </summary>
        [DataMember(Name = "gm")]
        private string gamemode = "";

        /// <summary>
        /// Language
        /// </summary>
        [DataMember(Name = "la")]
        private string language = "";

        /// <summary>
        /// Has password
        /// </summary>
        [DataMember(Name = "pa")]
        private bool hasPassword = false;

        /// <summary>
        /// Version
        /// </summary>
        [DataMember(Name = "vn")]
        private string version = "";

        /// <summary>
        /// Host
        /// </summary>
        public string Host
        {
            get
            {
                if (host == null)
                {
                    host = "";
                }
                return host;
            }
        }

        /// <summary>
        /// Hostname
        /// </summary>
        public string Hostname
        {
            get
            {
                if (hostname == null)
                {
                    hostname = "";
                }
                return hostname;
            }
        }

        /// <summary>
        /// Player count
        /// </summary>
        public ushort PlayerCount
        {
            get
            {
                return playerCount;
            }
        }

        /// <summary>
        /// Maximal players
        /// </summary>
        public ushort MaxPlayers
        {
            get
            {
                return maxPlayers;
            }
        }

        /// <summary>
        /// Gamemode
        /// </summary>
        public string Gamemode
        {
            get
            {
                if (gamemode == null)
                {
                    gamemode = "";
                }
                return gamemode;
            }
        }

        /// <summary>
        /// Language
        /// </summary>
        public string Language
        {
            get
            {
                if (language == null)
                {
                    language = "";
                }
                return language;
            }
        }

        /// <summary>
        /// Has password
        /// </summary>
        public bool HasPassword
        {
            get
            {
                return hasPassword;
            }
        }

        /// <summary>
        /// Version
        /// </summary>
        public string Version
        {
            get
            {
                if (version == null)
                {
                    version = "";
                }
                return version;
            }
        }
    }
}
