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
        private bool isValid = false;

        /// <summary>
        /// IP
        /// </summary>
        private string ip = "";

        /// <summary>
        /// Country code
        /// </summary>
        private string countryCode = "";

        /// <summary>
        /// Country name
        /// </summary>
        private string countryName = "";

        /// <summary>
        /// Region name
        /// </summary>
        private string regionName = "";

        /// <summary>
        /// Region code
        /// </summary>
        private string regionCode = "";

        /// <summary>
        /// City
        /// </summary>
        private string city = "";

        /// <summary>
        /// ZIP code
        /// </summary>
        private string zipCode = "";

        /// <summary>
        /// Time zone
        /// </summary>
        private string timeZone = "";

        /// <summary>
        /// Latitude
        /// </summary>
        private float latitude = 0.0f;

        /// <summary>
        /// Longitude
        /// </summary>
        private float longitude = 0.0f;

        /// <summary>
        /// Metro code
        /// </summary>
        private int metroCode = 0;

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
        public GeoLocationData(object result = null)
        {
            if (result != null)
            {
                if (result is FreeGeoIPDataContract)
                {
                    FreeGeoIPDataContract freeGeoIPData = (FreeGeoIPDataContract)result;
                    isValid = true;
                    ip = Utils.NAString(freeGeoIPData.ip);
                    countryCode = Utils.NAString(freeGeoIPData.countryCode);
                    countryName = Utils.NAString(freeGeoIPData.countryName);
                    regionName = Utils.NAString(freeGeoIPData.regionName);
                    regionCode = Utils.NAString(freeGeoIPData.regionCode);
                    city = Utils.NAString(freeGeoIPData.city);
                    zipCode = Utils.NAString(freeGeoIPData.zipCode);
                    timeZone = Utils.NAString(freeGeoIPData.timeZone);
                    latitude = freeGeoIPData.latitude;
                    longitude = freeGeoIPData.longitude;
                    metroCode = freeGeoIPData.metroCode;
                }
            }
        }
    }
}
