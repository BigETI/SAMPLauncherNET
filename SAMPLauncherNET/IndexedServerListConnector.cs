namespace SAMPLauncherNET
{
    public class IndexedServerListConnector
    {

        private ServerListConnector serverListConnector;

        private int index;

        public ServerListConnector ServerListConnector
        {
            get
            {
                return serverListConnector;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
        }

        public IndexedServerListConnector(ServerListConnector serverListConnector, int index)
        {
            this.serverListConnector = serverListConnector;
            this.index = index;
        }

        public override string ToString()
        {
            return serverListConnector.ToString();
        }
    }
}
