using System;
using System.IO;

/// <summary>
/// Community San Andreas Multiplayer media namespace
/// </summary>
namespace CSLMedia
{
    /// <summary>
    /// Media class
    /// </summary>
    public static class Media
    {
        /// <summary>
        /// San Andreas Multiplayer configuration path
        /// </summary>
        public static readonly string SAMPConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + Path.DirectorySeparatorChar + "GTA San Andreas User Files" + Path.DirectorySeparatorChar + "SAMP";

        /// <summary>
        /// Gallery path
        /// </summary>
        public static readonly string GalleryPath = SAMPConfigPath + Path.DirectorySeparatorChar + "screens";

        /// <summary>
        /// Chatlog path
        /// </summary>
        public static readonly string ChatlogPath = SAMPConfigPath + Path.DirectorySeparatorChar + "chatlog.txt";

        /// <summary>
        /// Saved positions path
        /// </summary>
        public static readonly string SavedPositionsPath = SAMPConfigPath + Path.DirectorySeparatorChar + "savedpositions.txt";
    }
}
