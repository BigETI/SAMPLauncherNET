using System.IO;
using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Launcher config data contract class
    /// </summary>
    [DataContract]
    public class LauncherConfigDataContract
    {
        /// <summary>
        /// Last selected server list API
        /// </summary>
        [DataMember]
        public int lastSelectedServerListAPI = 0;

        /// <summary>
        /// Development directory
        /// </summary>
        [DataMember]
        public string developmentDirectory = Directory.GetCurrentDirectory() + "\\development";
    }
}
