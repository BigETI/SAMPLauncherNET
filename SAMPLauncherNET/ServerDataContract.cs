using System.Runtime.Serialization;

namespace SAMPLauncherNET
{
    [DataContract]
    public class ServerDataContract
    {
        [DataMember(Name = "ip")]
        public string host;

        [DataMember(Name = "hn")]
        public string hostname;

        [DataMember(Name = "pc")]
        public ushort playerCount;

        [DataMember(Name = "pm")]
        public ushort maxPlayers;

        [DataMember(Name = "gm")]
        public string gamemode;

        [DataMember(Name = "la")]
        public string language;

        [DataMember(Name = "pa")]
        public bool hasPassword;
    }
}
