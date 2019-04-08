using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLServers
{
    public static class ServerListProvider
    {

        /// <summary>
        /// Server list API path
        /// </summary>
        public static readonly string ServerListsPath = "." + Path.DirectorySeparatorChar + "resources" + Path.DirectorySeparatorChar + "server_lists.json";

        /// <summary>
        /// Favourites path
        /// </summary>
        public static readonly string FavouritesPath = "." + Path.DirectorySeparatorChar + "favourites.json";

        /// <summary>
        /// Legacy favourites path
        /// </summary>
        public static readonly string LegacyFavouritesPath = SAMPConfigPath + Path.DirectorySeparatorChar + "USERDATA.DAT";
    }
}
