/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Geo location data
    /// </summary>
    public class GeoLocationData
    {
        /// <summary>
        /// Is valid
        /// </summary>
        private readonly bool isValid;

        /// <summary>
        /// IP
        /// </summary>
        private readonly string ip = "";

        /// <summary>
        /// Country code
        /// </summary>
        private readonly string countryCode = "";

        /// <summary>
        /// Country name
        /// </summary>
        private readonly string countryName = "";

        /// <summary>
        /// Region name
        /// </summary>
        private readonly string regionName = "";

        /// <summary>
        /// Region code
        /// </summary>
        private readonly string regionCode = "";

        /// <summary>
        /// City
        /// </summary>
        private readonly string city = "";

        /// <summary>
        /// ZIP code
        /// </summary>
        private readonly string zipCode = "";

        /// <summary>
        /// Time zone
        /// </summary>
        private readonly string timeZone = "";

        /// <summary>
        /// Latitude
        /// </summary>
        private readonly float latitude;

        /// <summary>
        /// Longitude
        /// </summary>
        private readonly float longitude;

        /// <summary>
        /// Metro code
        /// </summary>
        private readonly int metroCode;

        /// <summary>
        /// Is valid
        /// </summary>
        public bool IsValid
        {
            get
            {
                return isValid;
            }
        }

        /// <summary>
        /// IP
        /// </summary>
        public string IP
        {
            get
            {
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
                return timeZone;
            }
        }

        /// <summary>
        /// Latitude
        /// </summary>
        public float Latitude
        {
            get
            {
                return latitude;
            }
        }

        /// <summary>
        /// Longitude
        /// </summary>
        public float Longitude
        {
            get
            {
                return longitude;
            }
        }

        /// <summary>
        /// Metro code
        /// </summary>
        public int MetroCode
        {
            get
            {
                return metroCode;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="result">Result</param>
        public GeoLocationData(object result)
        {
            if (result != null)
            {
                if (result is FreeGeoIPDataContract)
                {
                    FreeGeoIPDataContract freeGeoIPData = (FreeGeoIPDataContract)result;
                    isValid = true;
                    ip = Utils.NAString(freeGeoIPData.IP);
                    countryCode = Utils.NAString(freeGeoIPData.CountryCode);
                    countryName = Utils.NAString(freeGeoIPData.CountryName);
                    regionName = Utils.NAString(freeGeoIPData.RegionName);
                    regionCode = Utils.NAString(freeGeoIPData.RegionCode);
                    city = Utils.NAString(freeGeoIPData.City);
                    zipCode = Utils.NAString(freeGeoIPData.ZIPCode);
                    timeZone = Utils.NAString(freeGeoIPData.TimeZone);
                    latitude = freeGeoIPData.Latitude;
                    longitude = freeGeoIPData.Longitude;
                    metroCode = freeGeoIPData.MetroCode;
                }
            }
        }
    }
}
