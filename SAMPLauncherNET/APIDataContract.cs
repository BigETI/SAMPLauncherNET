using System.Runtime.Serialization;

namespace SAMPLauncherNET
{
    [DataContract]
    public class APIDataContract
    {
        [DataMember]
        public string name;

        [DataMember]
        public string type;

        [DataMember]
        public string endpoint;
    }
}
