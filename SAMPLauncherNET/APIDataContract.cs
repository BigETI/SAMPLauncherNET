using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// API data contract
    /// </summary>
    [DataContract]
    public class APIDataContract
    {
        /// <summary>
        /// API name
        /// </summary>
        [DataMember]
        public string name;

        /// <summary>
        /// API type
        /// </summary>
        [DataMember]
        public string type;

        /// <summary>
        /// API endpoint
        /// </summary>
        [DataMember]
        public string endpoint;
    }
}
