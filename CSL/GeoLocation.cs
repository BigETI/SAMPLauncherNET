using CSLPI;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Geo location data
    /// </summary>
    public class GeoLocation : IGeoLocation
    {
        /// <summary>
        /// IP
        /// </summary>
        private string ip;

        /// <summary>
        /// Country code
        /// </summary>
        private string countryCode;

        /// <summary>
        /// Country name
        /// </summary>
        private string countryName;

        /// <summary>
        /// Region name
        /// </summary>
        private string regionName;

        /// <summary>
        /// Region code
        /// </summary>
        private string regionCode;

        /// <summary>
        /// City
        /// </summary>
        private string city;

        /// <summary>
        /// ZIP code
        /// </summary>
        private string zipCode;

        /// <summary>
        /// Time zone
        /// </summary>
        private string timeZone;

        /// <summary>
        /// Is valid
        /// </summary>
        public bool IsValid { get; private set; }

        /// <summary>
        /// IP
        /// </summary>
        public string IP
        {
            get
            {
                if (ip == null)
                {
                    ip = "";
                }
                return ip;
            }
        }

        /// <summary>
        /// Country code
        /// </summary>
        public string CountryCode
        {
            get
            {
                if (countryCode == null)
                {
                    countryCode = "";
                }
                return countryCode;
            }
        }

        /// <summary>
        /// Country name
        /// </summary>
        public string CountryName
        {
            get
            {
                if (countryName == null)
                {
                    countryName = "";
                }
                return countryName;
            }
        }

        /// <summary>
        /// Region name
        /// </summary>
        public string RegionName
        {
            get
            {
                if (regionName == null)
                {
                    regionName = "";
                }
                return regionName;
            }
        }

        /// <summary>
        /// Region code
        /// </summary>
        public string RegionCode
        {
            get
            {
                if (regionCode == null)
                {
                    regionCode = "";
                }
                return regionCode;
            }
        }

        /// <summary>
        /// City
        /// </summary>
        public string City
        {
            get
            {
                if (city == null)
                {
                    city = "";
                }
                return city;
            }
        }

        /// <summary>
        /// ZIP code
        /// </summary>
        public string ZIPCode
        {
            get
            {
                if (zipCode == null)
                {
                    zipCode = "";
                }
                return zipCode;
            }
        }

        /// <summary>
        /// Time zone
        /// </summary>
        public string TimeZone
        {
            get
            {
                if (timeZone == null)
                {
                    timeZone = "";
                }
                return timeZone;
            }
        }

        /// <summary>
        /// Latitude
        /// </summary>
        public float Latitude { get; private set; }

        /// <summary>
        /// Longitude
        /// </summary>
        public float Longitude { get; private set; }

        /// <summary>
        /// Metro code
        /// </summary>
        public int MetroCode { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="result">Result</param>
        public GeoLocation(object result)
        {
            if (result != null)
            {
                if (result is FreeGeoIPDataContract)
                {
                    FreeGeoIPDataContract freeGeoIPData = (FreeGeoIPDataContract)result;
                    IsValid = true;
                    ip = Utils.NAString(freeGeoIPData.IP);
                    countryCode = Utils.NAString(freeGeoIPData.CountryCode);
                    countryName = Utils.NAString(freeGeoIPData.CountryName);
                    regionName = Utils.NAString(freeGeoIPData.RegionName);
                    regionCode = Utils.NAString(freeGeoIPData.RegionCode);
                    city = Utils.NAString(freeGeoIPData.City);
                    zipCode = Utils.NAString(freeGeoIPData.ZIPCode);
                    timeZone = Utils.NAString(freeGeoIPData.TimeZone);
                    Latitude = freeGeoIPData.Latitude;
                    Longitude = freeGeoIPData.Longitude;
                    MetroCode = freeGeoIPData.MetroCode;
                }
            }
        }
    }
}
