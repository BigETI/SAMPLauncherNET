using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSLPI
{
    /// <summary>
    /// Favourite San Andreas Multiplayer server
    /// </summary>
    public interface IFavouriteSAMPServer : ISAMPServer
    {
        /// <summary>
        /// Server password
        /// </summary>
        string ServerPassword { get; }

        /// <summary>
        /// RCON password
        /// </summary>
        string RCONPassword { get; }
    }
}
