using System.Runtime.Serialization;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Free geo IP data contract class
    /// </summary>
    [DataContract]
    public class FreeGeoIPDataContract
    {
        /// <summary>
        /// IP
        /// </summary>
        [DataMember(Name = "ip")]
        private string ip = null;

        /// <summary>
        /// Country code
        /// </summary>
        [DataMember(Name = "country_code")]
        private string countryCode = null;

        /// <summary>
        /// Country name
        /// </summary>
        [DataMember(Name = "country_name")]
        private string countryName = null;

        /// <summary>
        /// Region code
        /// </summary>
        [DataMember(Name = "region_code")]
        private string regionCode = null;

        /// <summary>
        /// Region name
        /// </summary>
        [DataMember(Name = "region_name")]
        private string regionName = null;

        /// <summary>
        /// City
        /// </summary>
        [DataMember(Name = "city")]
        private string city = null;

        /// <summary>
        /// ZIP code
        /// </summary>
        [DataMember(Name = "zip_code")]
        private string zipCode = null;

        /// <summary>
        /// Time zone
        /// </summary>
        [DataMember(Name = "time_zone")]
        private string timeZone = null;

        /// <summary>
        /// Latitude
        /// </summary>
        [DataMember(Name = "latitude")]
        private float latitude = 0.0f;

        /// <summary>
        /// Longitude
        /// </summary>
        [DataMember(Name = "longitude")]
        private float longitude = 0.0f;

        /// <summary>
        /// Metro code
        /// </summary>
        [DataMember(Name = "metro_code")]
        private int metroCode = 0;

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
    }
}
