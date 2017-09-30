using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Server data contract class
    /// </summary>
    [DataContract]
    public class BackendRESTfulServerDataContract
    {
        /// <summary>
        /// IP
        /// </summary>
        [DataMember(Name = "ip")]
        public string host;

        /// <summary>
        /// Hostname
        /// </summary>
        [DataMember(Name = "hn")]
        public string hostname;

        /// <summary>
        /// Player count
        /// </summary>
        [DataMember(Name = "pc")]
        public ushort playerCount;

        /// <summary>
        /// Maximal players
        /// </summary>
        [DataMember(Name = "pm")]
        public ushort maxPlayers;

        /// <summary>
        /// Gamemode
        /// </summary>
        [DataMember(Name = "gm")]
        public string gamemode;

        /// <summary>
        /// Language
        /// </summary>
        [DataMember(Name = "la")]
        public string language;

        /// <summary>
        /// Has password
        /// </summary>
        [DataMember(Name = "pa")]
        public bool hasPassword;
    }
}
