using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Developert tools configuration data contract
    /// </summary>
    [DataContract]
    public class DeveloperToolsConfigDataContract
    {
        /// <summary>
        /// Gamemodes
        /// </summary>
        [DataMember(Name = "gamemodes")]
        public string[] gamemodes = new string[0];

        /// <summary>
        /// RCON password
        /// </summary>
        [DataMember(Name = "rcon_password")]
        public string rconPassword = Utils.GetRandomString(16);

        /// <summary>
        /// Announce server
        /// </summary>
        [DataMember(Name = "announce", IsRequired = false)]
        public bool announce = false;

        /// <summary>
        /// Maximal players
        /// </summary>
        [DataMember(Name = "max_players", IsRequired = false)]
        public int maximumPlayers = 50;

        /// <summary>
        /// Port
        /// </summary>
        [DataMember(Name = "port", IsRequired = false)]
        public int port = 8192;

        /// <summary>
        /// LAN mode
        /// </summary>
        [DataMember(Name = "lanmode", IsRequired = false)]
        public bool lanMode = false;

        /// <summary>
        /// Enable query mechanism
        /// </summary>
        [DataMember(Name = "query", IsRequired = false)]
        public bool query = false;

        /// <summary>
        /// Enable RCON (not recommended)
        /// </summary>
        [DataMember(Name = "rcon", IsRequired = false)]
        public bool rcon = false;

        /// <summary>
        /// Log queries
        /// </summary>
        [DataMember(Name = "logqueries", IsRequired = false)]
        public bool logQueries = false;

        /// <summary>
        /// Stream rate
        /// </summary>
        [DataMember(Name = "stream_rate", IsRequired = false)]
        public int streamRate = 1000;

        /// <summary>
        /// Stream distance
        /// </summary>
        [DataMember(Name = "stream_distance", IsRequired = false)]
        public float streamDistance = 200.0f;

        /// <summary>
        /// Sleep time in milliseconds
        /// </summary>
        [DataMember(Name = "sleep", IsRequired = false)]
        public int sleep = 5;

        /// <summary>
        /// Maximal NPCs
        /// </summary>
        [DataMember(Name = "maxnpc", IsRequired = false)]
        public int maximumNPCs = 0;

        /// <summary>
        /// On foot rate
        /// </summary>
        [DataMember(Name = "onfoot_rate", IsRequired = false)]
        public int onFootRate = 30;

        /// <summary>
        /// In car rate
        /// </summary>
        [DataMember(Name = "incar_rate", IsRequired = false)]
        public int inCarRate = 30;

        /// <summary>
        /// Weapon rate
        /// </summary>
        [DataMember(Name = "weapon_rate", IsRequired = false)]
        public int weaponRate = 30;

        /// <summary>
        /// Chat logging
        /// </summary>
        [DataMember(Name = "chatlogging", IsRequired = false)]
        public bool chatLogging = true;

        /// <summary>
        /// Time stamp
        /// </summary>
        [DataMember(Name = "timestamp", IsRequired = false)]
        public bool timestamp = true;

        /// <summary>
        /// Bind IP address
        /// </summary>
        [DataMember(Name = "bind", IsRequired = false)]
        public string bind = "";

        /// <summary>
        /// Server password
        /// </summary>
        [DataMember(Name = "password", IsRequired = false)]
        public string password = "";

        /// <summary>
        /// Hostname
        /// </summary>
        [DataMember(Name = "hostname", IsRequired = false)]
        public string hostname = "SA-MP Server";

        /// <summary>
        /// Language
        /// </summary>
        [DataMember(Name = "language", IsRequired = false)]
        public string language = "SA-MP Server";

        /// <summary>
        /// Map name
        /// </summary>
        [DataMember(Name = "mapname", IsRequired = false)]
        public string mapName = "San Andreas";

        /// <summary>
        ///  Web URL
        /// </summary>
        [DataMember(Name = "weburl", IsRequired = false)]
        public string websiteURL = "www.sa-mp.com";

        /// <summary>
        /// Gamemode text
        /// </summary>
        [DataMember(Name = "gamemodetext", IsRequired = false)]
        public string gamemodeText = "Unknown";

        /// <summary>
        /// Filterscripts
        /// </summary>
        [DataMember(Name = "filterscripts", IsRequired = false)]
        public string[] filterscripts = new string[0];

        /// <summary>
        /// Plugins
        /// </summary>
        [DataMember(Name = "plugins", IsRequired = false)]
        public string[] plugins = new string[0];

        /// <summary>
        /// No sign
        /// </summary>
        [DataMember(Name = "nosign", IsRequired = false)]
        public string noSign = "";

        /// <summary>
        /// Log time format
        /// </summary>
        [DataMember(Name = "logtimeformat", IsRequired = false)]
        public string logTimeFormat = "[%H:%M:%S]";

        /// <summary>
        /// Message hole limit
        /// </summary>
        [DataMember(Name = "messageholelimit", IsRequired = false)]
        public int messageHoleLimit = 3000;

        /// <summary>
        /// Messages limit
        /// </summary>
        [DataMember(Name = "messageslimit", IsRequired = false)]
        public int messagesLimit = 500;

        /// <summary>
        /// Acknowledges limit
        /// </summary>
        [DataMember(Name = "ackslimit", IsRequired = false)]
        public int acknowledgesLimit = 3000;

        /// <summary>
        /// Player time out time in milliseconds
        /// </summary>
        [DataMember(Name = "playertimeout", IsRequired = false)]
        public int playerTimeOut = 10000;

        /// <summary>
        /// Minimum connection time in milliseconds
        /// </summary>
        [DataMember(Name = "minconnectiontime", IsRequired = false)]
        public int minimumConnectionTime = 0;

        /// <summary>
        /// Lag compensation mode
        /// </summary>
        [DataMember(Name = "lagcompmode", IsRequired = false)]
        public int lagCompensationMode = 1;

        /// <summary>
        /// Connection seed time
        /// </summary>
        [DataMember(Name = "connseedtime", IsRequired = false)]
        public int connectionSeedTime = 300000;

        /// <summary>
        /// Database logging
        /// </summary>
        [DataMember(Name = "db_logging", IsRequired = false)]
        public bool databaseLogging = false;

        /// <summary>
        /// Database log queries
        /// </summary>
        [DataMember(Name = "db_log_queries", IsRequired = false)]
        public bool databaseLogQueries = false;

        /// <summary>
        /// Connection cookies
        /// </summary>
        [DataMember(Name = "conncookies", IsRequired = false)]
        public bool connectionCookies = true;

        /// <summary>
        /// Cookie logging
        /// </summary>
        [DataMember(Name = "cookielogging", IsRequired = false)]
        public bool cookieLogging = false;
    }
}
