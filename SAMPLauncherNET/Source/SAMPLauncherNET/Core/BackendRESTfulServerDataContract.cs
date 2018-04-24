using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Server data contract class
    /// </summary>
    [DataContract]
    public class BackendRESTfulServerDataContract
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
        /// Host
        /// </summary>
        public string Host
        {
            get
            {
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
    }
}
