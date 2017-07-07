using System.Runtime.Serialization;

namespace SAMPLauncherNET
{
    [DataContract]
    public class FavouriteDataContract
    {
        [DataMember]
        public string host;

        [DataMember]
        public string hostname;

        [DataMember]
        public string mode;
    }
}
