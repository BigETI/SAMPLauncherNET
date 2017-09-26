using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
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
        public string ip;

        /// <summary>
        /// Country code
        /// </summary>
        [DataMember(Name = "country_code")]
        public string countryCode;

        /// <summary>
        /// Country name
        /// </summary>
        [DataMember(Name = "country_name")]
        public string countryName;

        /// <summary>
        /// Region code
        /// </summary>
        [DataMember(Name = "region_code")]
        public string regionCode;

        /// <summary>
        /// Region name
        /// </summary>
        [DataMember(Name = "region_name")]
        public string regionName;

        /// <summary>
        /// City
        /// </summary>
        [DataMember(Name = "city")]
        public string city;

        /// <summary>
        /// ZIP code
        /// </summary>
        [DataMember(Name = "zip_code")]
        public string zipCode;

        /// <summary>
        /// Time zone
        /// </summary>
        [DataMember(Name = "time_zone")]
        public string timeZone;

        /// <summary>
        /// Latitude
        /// </summary>
        [DataMember(Name = "latitude")]
        public float latitude;

        /// <summary>
        /// Longitude
        /// </summary>
        [DataMember(Name = "longitude")]
        public float longitude;

        /// <summary>
        /// Metro code
        /// </summary>
        [DataMember(Name = "metro_code")]
        public int metroCode;
    }
}
