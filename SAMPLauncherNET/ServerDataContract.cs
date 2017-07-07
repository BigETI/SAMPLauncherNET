using System.Runtime.Serialization;

namespace SAMPLauncherNET
{
    [DataContract]
    public class ServerDataContract
    {
        [DataMember(Name = "Host")]
        public string host;

        [DataMember(Name = "Hostname")]
        public string hostname;

        [DataMember(Name = "Gamemode")]
        public string gamemode;

        [DataMember(Name = "Language")]
        public string language;

        [DataMember(Name = "MaxPlayers")]
        public int maxPlayers;
    }
}
