using System.Threading.Tasks;

namespace SAMPLauncherNET
{
    public class FavouriteServer : Server
    {

        private string cachedHostName;

        private string serverPassword;

        private string rconPassword;

        public override string Hostname
        {
            get
            {
                Task<string> hn = HostnameAsync;
                if (hn.Wait(100))
                    cachedHostName = hn.Result;
                return cachedHostName;
            }
        }

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

        public FavouriteServer(string ipAddressAndPortString, string cachedHostName = "", string serverPassword = "", string rconPassword = "") : base(ipAddressAndPortString)
        {
            this.cachedHostName = cachedHostName;
            this.serverPassword = serverPassword;
            this.rconPassword = rconPassword;
        }
    }
}
