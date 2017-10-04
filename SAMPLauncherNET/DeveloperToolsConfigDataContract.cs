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
        private string[] gamemodes = new string[0];

        /// <summary>
        /// RCON password
        /// </summary>
        [DataMember(Name = "rcon_password")]
        private string rconPassword = Utils.GetRandomString(16);

        /// <summary>
        /// Announce server
        /// </summary>
        [DataMember(Name = "announce", IsRequired = false)]
        private bool announce;

        /// <summary>
        /// Maximal players
        /// </summary>
        [DataMember(Name = "max_players", IsRequired = false)]
        private int maximumPlayers = 50;

        /// <summary>
        /// Port
        /// </summary>
        [DataMember(Name = "port", IsRequired = false)]
        private int port = 8192;

        /// <summary>
        /// LAN mode
        /// </summary>
        [DataMember(Name = "lanmode", IsRequired = false)]
        private bool lanMode;

        /// <summary>
        /// Enable query mechanism
        /// </summary>
        [DataMember(Name = "query", IsRequired = false)]
        private bool query;

        /// <summary>
        /// Enable RCON (not recommended)
        /// </summary>
        [DataMember(Name = "rcon", IsRequired = false)]
        private bool rcon;

        /// <summary>
        /// Log queries
        /// </summary>
        [DataMember(Name = "logqueries", IsRequired = false)]
        private bool logQueries;

        /// <summary>
        /// Stream rate
        /// </summary>
        [DataMember(Name = "stream_rate", IsRequired = false)]
        private int streamRate = 1000;

        /// <summary>
        /// Stream distance
        /// </summary>
        [DataMember(Name = "stream_distance", IsRequired = false)]
        private float streamDistance = 200.0f;

        /// <summary>
        /// Sleep time in milliseconds
        /// </summary>
        [DataMember(Name = "sleep", IsRequired = false)]
        private int sleep = 5;

        /// <summary>
        /// Maximal NPCs
        /// </summary>
        [DataMember(Name = "maxnpc", IsRequired = false)]
        private int maximumNPCs;

        /// <summary>
        /// On foot rate
        /// </summary>
        [DataMember(Name = "onfoot_rate", IsRequired = false)]
        private int onFootRate = 30;

        /// <summary>
        /// In car rate
        /// </summary>
        [DataMember(Name = "incar_rate", IsRequired = false)]
        private int inCarRate = 30;

        /// <summary>
        /// Weapon rate
        /// </summary>
        [DataMember(Name = "weapon_rate", IsRequired = false)]
        private int weaponRate = 30;

        /// <summary>
        /// Chat logging
        /// </summary>
        [DataMember(Name = "chatlogging", IsRequired = false)]
        private bool chatLogging = true;

        /// <summary>
        /// Time stamp
        /// </summary>
        [DataMember(Name = "timestamp", IsRequired = false)]
        private bool timestamp = true;

        /// <summary>
        /// Bind IP address
        /// </summary>
        [DataMember(Name = "bind", IsRequired = false)]
        private string bind = "";

        /// <summary>
        /// Server password
        /// </summary>
        [DataMember(Name = "password", IsRequired = false)]
        private string password = "";

        /// <summary>
        /// Hostname
        /// </summary>
        [DataMember(Name = "hostname", IsRequired = false)]
        private string hostname = "SA-MP Server";

        /// <summary>
        /// Language
        /// </summary>
        [DataMember(Name = "language", IsRequired = false)]
        private string language = "SA-MP Server";

        /// <summary>
        /// Map name
        /// </summary>
        [DataMember(Name = "mapname", IsRequired = false)]
        private string mapName = "San Andreas";

        /// <summary>
        ///  Web URL
        /// </summary>
        [DataMember(Name = "weburl", IsRequired = false)]
        private string websiteURL = "www.sa-mp.com";

        /// <summary>
        /// Gamemode text
        /// </summary>
        [DataMember(Name = "gamemodetext", IsRequired = false)]
        private string gamemodeText = "Unknown";

        /// <summary>
        /// Filterscripts
        /// </summary>
        [DataMember(Name = "filterscripts", IsRequired = false)]
        private string[] filterscripts = new string[0];

        /// <summary>
        /// Plugins
        /// </summary>
        [DataMember(Name = "plugins", IsRequired = false)]
        private string[] plugins = new string[0];

        /// <summary>
        /// No sign
        /// </summary>
        [DataMember(Name = "nosign", IsRequired = false)]
        private string noSign = "";

        /// <summary>
        /// Log time format
        /// </summary>
        [DataMember(Name = "logtimeformat", IsRequired = false)]
        private string logTimeFormat = "[%H:%M:%S]";

        /// <summary>
        /// Message hole limit
        /// </summary>
        [DataMember(Name = "messageholelimit", IsRequired = false)]
        private int messageHoleLimit = 3000;

        /// <summary>
        /// Messages limit
        /// </summary>
        [DataMember(Name = "messageslimit", IsRequired = false)]
        private int messagesLimit = 500;

        /// <summary>
        /// Acknowledges limit
        /// </summary>
        [DataMember(Name = "ackslimit", IsRequired = false)]
        private int acknowledgesLimit = 3000;

        /// <summary>
        /// Player time out time in milliseconds
        /// </summary>
        [DataMember(Name = "playertimeout", IsRequired = false)]
        private int playerTimeOut = 10000;

        /// <summary>
        /// Minimum connection time in milliseconds
        /// </summary>
        [DataMember(Name = "minconnectiontime", IsRequired = false)]
        private int minimumConnectionTime;

        /// <summary>
        /// Lag compensation mode
        /// </summary>
        [DataMember(Name = "lagcompmode", IsRequired = false)]
        private int lagCompensationMode = 1;

        /// <summary>
        /// Connection seed time
        /// </summary>
        [DataMember(Name = "connseedtime", IsRequired = false)]
        private int connectionSeedTime = 300000;

        /// <summary>
        /// Database logging
        /// </summary>
        [DataMember(Name = "db_logging", IsRequired = false)]
        private bool databaseLogging;

        /// <summary>
        /// Database log queries
        /// </summary>
        [DataMember(Name = "db_log_queries", IsRequired = false)]
        private bool databaseLogQueries;

        /// <summary>
        /// Connection cookies
        /// </summary>
        [DataMember(Name = "conncookies", IsRequired = false)]
        private bool connectionCookies = true;

        /// <summary>
        /// Cookie logging
        /// </summary>
        [DataMember(Name = "cookielogging", IsRequired = false)]
        private bool cookieLogging;

        /// <summary>
        /// Gamemodes
        /// </summary>
        public string[] Gamemodes
        {
            get
            {
                return gamemodes;
            }
            set
            {
                if (value != null)
                {
                    gamemodes = value;
                }            }
        }

        /// <summary>
        /// RCON password
        /// </summary>
        public string RCONPassword
        {
            get
            {
                return rconPassword;
            }
            set
            {
                if (value != null)
                {
                    rconPassword = value;
                }
            }
        }

        /// <summary>
        /// Announce server
        /// </summary>
        public bool Announce
        {
            get
            {
                return announce;
            }
        }

        /// <summary>
        /// Maximal players
        /// </summary>
        public int MaximumPlayers
        {
            get
            {
                return maximumPlayers;
            }
        }

        /// <summary>
        /// Port
        /// </summary>
        public int Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
                if (port > 65535)
                {
                    port = 65535;
                }
                else if (port < 0)
                {
                    port = 0;
                }
            }
        }

        /// <summary>
        /// LAN mode
        /// </summary>
        public bool LANMode
        {
            get
            {
                return lanMode;
            }
        }

        /// <summary>
        /// Enable query mechanism
        /// </summary>
        public bool Query
        {
            get
            {
                return query;
            }
        }

        /// <summary>
        /// Enable RCON (not recommended)
        /// </summary>
        public bool RCON
        {
            get
            {
                return rcon;
            }
        }

        /// <summary>
        /// Log queries
        /// </summary>
        public bool LogQueries
        {
            get
            {
                return logQueries;
            }
        }

        /// <summary>
        /// Stream rate
        /// </summary>
        public int StreamRate
        {
            get
            {
                return streamRate;
            }
        }

        /// <summary>
        /// Stream distance
        /// </summary>
        public float StreamDistance
        {
            get
            {
                return streamDistance;
            }
        }

        /// <summary>
        /// Sleep time in milliseconds
        /// </summary>
        public int Sleep
        {
            get
            {
                return sleep;
            }
        }

        /// <summary>
        /// Maximal NPCs
        /// </summary>
        public int MaximumNPCs
        {
            get
            {
                return maximumNPCs;
            }
        }

        /// <summary>
        /// On foot rate
        /// </summary>
        public int OnFootRate
        {
            get
            {
                return onFootRate;
            }
        }

        /// <summary>
        /// In car rate
        /// </summary>
        public int InCarRate
        {
            get
            {
                return inCarRate;
            }
        }

        /// <summary>
        /// Weapon rate
        /// </summary>
        public int WeaponRate
        {
            get
            {
                return weaponRate;
            }
        }

        /// <summary>
        /// Chat logging
        /// </summary>
        public bool ChatLogging
        {
            get
            {
                return chatLogging;
            }
        }

        /// <summary>
        /// Time stamp
        /// </summary>
        public bool Timestamp
        {
            get
            {
                return timestamp;
            }
        }

        /// <summary>
        /// Bind IP address
        /// </summary>
        public string Bind
        {
            get
            {
                return bind;
            }
        }

        /// <summary>
        /// Server password
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value != null)
                {
                    password = value;
                }
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
            set
            {
                if (value != null)
                {
                    hostname = value;
                }
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
        /// Map name
        /// </summary>
        public string MapName
        {
            get
            {
                return mapName;
            }
        }

        /// <summary>
        ///  Web URL
        /// </summary>
        public string WebsiteURL
        {
            get
            {
                return websiteURL;
            }
        }

        /// <summary>
        /// Gamemode text
        /// </summary>
        public string GamemodeText
        {
            get
            {
                return gamemodeText;
            }
        }

        /// <summary>
        /// Filterscripts
        /// </summary>
        public string[] Filterscripts
        {
            get
            {
                return filterscripts;
            }
            set
            {
                if (value != null)
                {
                    filterscripts = value;
                }
            }
        }

        /// <summary>
        /// Plugins
        /// </summary>
        public string[] Plugins
        {
            get
            {
                return plugins;
            }
            set
            {
                if (value != null)
                {
                    plugins = value;
                }
            }
        }

        /// <summary>
        /// No sign
        /// </summary>
        public string NoSign
        {
            get
            {
                return noSign;
            }
        }

        /// <summary>
        /// Log time format
        /// </summary>
        public string LogTimeFormat
        {
            get
            {
                return logTimeFormat;
            }
        }

        /// <summary>
        /// Message hole limit
        /// </summary>
        public int MessageHoleLimit
        {
            get
            {
                return messageHoleLimit;
            }
        }

        /// <summary>
        /// Messages limit
        /// </summary>
        public int MessagesLimit
        {
            get
            {
                return messagesLimit;
            }
        }

        /// <summary>
        /// Acknowledges limit
        /// </summary>
        public int AcknowledgesLimit
        {
            get
            {
                return acknowledgesLimit;
            }
        }

        /// <summary>
        /// Player time out time in milliseconds
        /// </summary>
        public int PlayerTimeOut
        {
            get
            {
                return playerTimeOut;
            }
        }

        /// <summary>
        /// Minimum connection time in milliseconds
        /// </summary>
        public int MinimumConnectionTime
        {
            get
            {
                return minimumConnectionTime;
            }
        }

        /// <summary>
        /// Lag compensation mode
        /// </summary>
        public int LagCompensationMode
        {
            get
            {
                return lagCompensationMode;
            }
        }

        /// <summary>
        /// Connection seed time
        /// </summary>
        public int ConnectionSeedTime
        {
            get
            {
                return connectionSeedTime;
            }
        }

        /// <summary>
        /// Database logging
        /// </summary>
        public bool DatabaseLogging
        {
            get
            {
                return databaseLogging;
            }
        }

        /// <summary>
        /// Database log queries
        /// </summary>
        public bool DatabaseLogQueries
        {
            get
            {
                return databaseLogQueries;
            }
        }

        /// <summary>
        /// Connection cookies
        /// </summary>
        public bool ConnectionCookies
        {
            get
            {
                return connectionCookies;
            }
        }

        /// <summary>
        /// Cookie logging
        /// </summary>
        public bool CookieLogging
        {
            get
            {
                return cookieLogging;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeveloperToolsConfigDataContract()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="acknowledgesLimit">Acknowledges limit</param>
        /// <param name="announce">Announce</param>
        /// <param name="bind">Bind</param>
        /// <param name="chatLogging">Chat logging</param>
        /// <param name="connectionCookies">Connection cookies</param>
        /// <param name="connectionSeedTime">Connection seed time</param>
        /// <param name="cookieLogging">Cookie logging</param>
        /// <param name="databaseLogQueries">Database log queries</param>
        /// <param name="databaseLogging">Database logging</param>
        /// <param name="hostname">Hostname</param>
        /// <param name="inCarRate">In car rate</param>
        /// <param name="lagCompensationMode">Lag compensation mode</param>
        /// <param name="language">Language</param>
        /// <param name="lanMode">LAN mode</param>
        /// <param name="logQueries">Log queries</param>
        /// <param name="logTimeFormat">Log time format</param>
        /// <param name="mapName">Map name</param>
        /// <param name="maximumPlayers">Maximum players</param>
        /// <param name="maximumNPCs">Maximum NPCs</param>
        /// <param name="messageHoleLimit">Message hole limit</param>
        /// <param name="messagesLimit">Messages limit</param>
        /// <param name="minimumConnectionTime">Minimum connection time</param>
        /// <param name="noSign">No sign</param>
        /// <param name="onFootRate">On foot rate</param>
        /// <param name="password">Password</param>
        /// <param name="playerTimeOut">Player time out</param>
        /// <param name="port">Port</param>
        /// <param name="query">Query</param>
        /// <param name="rcon">RCON</param>
        /// <param name="rconPassword">RCON password</param>
        /// <param name="sleep">Sleep</param>
        /// <param name="streamDistance">Stream distance</param>
        /// <param name="streamRate">Stream rate</param>
        /// <param name="timestamp">Timestamp</param>
        /// <param name="weaponRate">Weapon rate</param>
        /// <param name="websiteURL">Website URL</param>
        public DeveloperToolsConfigDataContract(int acknowledgesLimit, bool announce, string bind, bool chatLogging, bool connectionCookies, int connectionSeedTime, bool cookieLogging, bool databaseLogQueries, bool databaseLogging, string hostname, int inCarRate, int lagCompensationMode, string language, bool lanMode, bool logQueries, string logTimeFormat, string mapName, int maximumPlayers, int maximumNPCs, int messageHoleLimit, int messagesLimit, int minimumConnectionTime, string noSign, int onFootRate, string password, int playerTimeOut, int port, bool query, bool rcon, string rconPassword, int sleep, float streamDistance, int streamRate, bool timestamp, int weaponRate, string websiteURL)
        {
            this.acknowledgesLimit = acknowledgesLimit;
            this.announce = announce;
            this.bind = bind;
            this.chatLogging = chatLogging;
            this.connectionCookies = connectionCookies;
            this.connectionSeedTime = connectionSeedTime;
            this.cookieLogging = cookieLogging;
            this.databaseLogQueries = databaseLogQueries;
            this.databaseLogging = databaseLogging;
            this.hostname = hostname;
            this.inCarRate = inCarRate;
            this.lagCompensationMode = lagCompensationMode;
            this.language = language;
            this.lanMode = lanMode;
            this.logQueries = logQueries;
            this.logTimeFormat = logTimeFormat;
            this.mapName = mapName;
            this.maximumPlayers = maximumPlayers;
            this.maximumNPCs = maximumNPCs;
            this.messageHoleLimit = messageHoleLimit;
            this.messagesLimit = messagesLimit;
            this.minimumConnectionTime = minimumConnectionTime;
            this.noSign = noSign;
            this.onFootRate = onFootRate;
            this.password = password;
            this.playerTimeOut = playerTimeOut;
            this.port = port;
            this.query = query;
            this.rcon = rcon;
            this.rconPassword = rconPassword;
            this.sleep = sleep;
            this.streamDistance = streamDistance;
            this.streamRate = streamRate;
            this.timestamp = timestamp;
            this.weaponRate = weaponRate;
            this.websiteURL = websiteURL;
        }
    }
}
