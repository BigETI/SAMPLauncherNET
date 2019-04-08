using CSLPI;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Favourite San Andreas Multiplayer server
    /// </summary>
    public class FavouriteSAMPServer : SAMPServer, IFavouriteSAMPServer
    {
        /// <summary>
        /// Server password
        /// </summary>
        private string serverPassword;

        /// <summary>
        /// RCON password
        /// </summary>
        private string rconPassword;

        /// <summary>
        /// Server password
        /// </summary>
        public string ServerPassword
        {
            get
            {
                if (serverPassword == null)
                {
                    serverPassword = "";
                }
                return serverPassword;
            }
        }

        /// <summary>
        /// RCON password
        /// </summary>
        public string RCONPassword
        {
            get
            {
                if (rconPassword == null)
                {
                    rconPassword = "";
                }
                return rconPassword;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ipAddressAndPortString">IP address and port string</param>
        /// <param name="cachedHostname">Cached hostname</param>
        /// <param name="cachedGamemode">Cached gamemode</param>
        /// <param name="serverPassword">Server password</param>
        /// <param name="rconPassword">RCON password</param>
        public FavouriteSAMPServer(string ipAddressAndPortString, string cachedHostname, string cachedGamemode, string serverPassword, string rconPassword) : base(ipAddressAndPortString, false)
        {
            if (cachedHostname != null)
            {
                if (cachedHostname.Trim().Length > 0)
                {
                    hostname = cachedHostname;
                }
            }
            gamemode = cachedGamemode;
            this.serverPassword = serverPassword;
            this.rconPassword = rconPassword;
            FetchDataAsync(ERequestResponseType.Ping);
            FetchDataAsync(ERequestResponseType.Information);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fdc">Favorite data contract</param>
        public FavouriteSAMPServer(FavouriteDataContract fdc) : base(fdc.Host, false)
        {
            if (fdc.Hostname.Trim().Length > 0)
            {
                hostname = fdc.Hostname;
            }
            serverPassword = "";
            rconPassword = "";
            FetchDataAsync(ERequestResponseType.Ping);
            FetchDataAsync(ERequestResponseType.Information);
        }
    }
}
