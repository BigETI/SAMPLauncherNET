namespace SAMPLauncherNET
{
    public class FavouriteServer : Server
    {

        private string serverPassword;

        private string rconPassword;

        public string ServerPassword
        {
            get
            {
                return serverPassword;
            }
        }

        public string RCONPassword
        {
            get
            {
                return rconPassword;
            }
        }

        public FavouriteServer(string ipAddressAndPortString, string cachedHostname = "", string cachedGamemode = "", string serverPassword = "", string rconPassword = "") : base(ipAddressAndPortString, false)
        {
            requestsRequired[ERequestType.Information] = false;
            hostname = cachedHostname;
            gamemode = cachedGamemode;
            this.serverPassword = serverPassword;
            this.rconPassword = rconPassword;
        }
        
        public FavouriteServer(FavouriteDataContract fdc) : base(fdc.host, false)
        {
            requestsRequired[ERequestType.Information] = false;
            hostname = fdc.hostname;
            serverPassword = "";
            rconPassword = "";
        }
    }
}
