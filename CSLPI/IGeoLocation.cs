/// <summary>
/// Community San Andreas Multiplayer Launcher programming interface namespace
/// </summary>
namespace CSLPI
{
    /// <summary>
    /// Geo location interface
    /// </summary>
    public interface IGeoLocation
    {
        /// <summary>
        /// Is valid
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// IP
        /// </summary>
        string IP { get; }

        /// <summary>
        /// Country code
        /// </summary>
        string CountryCode { get; }

        /// <summary>
        /// Country name
        /// </summary>
        string CountryName { get; }

        /// <summary>
        /// Region name
        /// </summary>
        string RegionName { get; }

        /// <summary>
        /// Region code
        /// </summary>
        string RegionCode { get; }

        /// <summary>
        /// City
        /// </summary>
        string City { get; }

        /// <summary>
        /// ZIP code
        /// </summary>
        string ZIPCode { get; }

        /// <summary>
        /// Time zone
        /// </summary>
        string TimeZone { get; }

        /// <summary>
        /// Latitude
        /// </summary>
        float Latitude { get; }

        /// <summary>
        /// Longitude
        /// </summary>
        float Longitude { get; }

        /// <summary>
        /// Metro code
        /// </summary>
        int MetroCode { get; }
    }
}
