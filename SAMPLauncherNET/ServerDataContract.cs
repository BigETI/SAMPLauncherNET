using System.Runtime.Serialization;

namespace SAMPLauncherNET
{
    [DataContract]
    public class ServerDataContract
    {
        public string Host;

        public string Hostname;

        public string Gamemode;

        public string Language;

        public int MaxPlayers;
    }
}
