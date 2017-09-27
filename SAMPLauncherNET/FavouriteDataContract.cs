using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Favourite data contract class
    /// </summary>
    [DataContract]
    public class FavouriteDataContract
    {
        /// <summary>
        /// Host
        /// </summary>
        [DataMember]
        public string host;

        /// <summary>
        /// Hostname
        /// </summary>
        [DataMember]
        public string hostname;

        /// <summary>
        /// Mode
        /// </summary>
        [DataMember]
        public string mode;
    }
}
