using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Geo locator class
    /// </summary>
    public static class GeoLocator
    {
        /// <summary>
        /// Cache
        /// </summary>
        private static Dictionary<string, GeoLocation> cache = new Dictionary<string, GeoLocation>();

        /// <summary>
        /// Providers
        /// </summary>
        private static readonly GeoLocationProvider[] providers = new[] { new GeoLocationProvider("http://freegeoip.net/json/", typeof(FreeGeoIPDataContract)) };

        /// <summary>
        /// Locate
        /// </summary>
        /// <param name="host">Host</param>
        /// <returns>Geo location data</returns>
        public static GeoLocation Locate(string host)
        {
            GeoLocation ret = null;
            string h = host.Trim();
            if (cache.ContainsKey(h))
            {
                ret = cache[h];
            }
            else
            {
                foreach (GeoLocationProvider provider in providers)
                {
                    ret = provider.RequestData(h);
                    if (ret != null)
                    {
                        break;
                    }
                }
            }
            if (ret == null)
            {
                ret = new GeoLocation(null);
            }
            return ret;
        }

        /// <summary>
        /// Locate asynchronous
        /// </summary>
        /// <param name="host">Host</param>
        /// <returns>Geo location data</returns>
        public static Task<GeoLocation> LocateAsync(string host)
        {
            return Task.Factory.StartNew(() => Locate(host));
        }
    }
}
