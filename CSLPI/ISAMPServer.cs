using System;
using System.Net;

/// <summary>
/// Community San Andreas Multiplayer Launcher programming interface namespace
/// </summary>
namespace CSLPI
{
    /// <summary>
    /// San Andreas Multiplayer server interface
    /// </summary>
    public interface ISAMPServer : IComparable, IComparable<ISAMPServer>, IDisposable
    {
        /// <summary>
        /// IPv4 address unsigned integer
        /// </summary>
        uint IPv4AddressUInt { get; }

        /// <summary>
        /// Port
        /// </summary>
        ushort Port { get; }

        /// <summary>
        /// Is valid
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// IP address
        /// </summary>
        IPAddress IPAddress { get; }

        /// <summary>
        /// Has password
        /// </summary>
        bool HasPassword { get; }

        /// <summary>
        /// Player count
        /// </summary>
        ushort PlayerCount { get; }

        /// <summary>
        /// Maximal players
        /// </summary>
        ushort MaxPlayers { get; }

        /// <summary>
        /// Hostname
        /// </summary>
        string Hostname { get; }

        /// <summary>
        /// Gamemode
        /// </summary>
        string Gamemode { get; }

        /// <summary>
        /// Language
        /// </summary>
        string Language { get; }

        /// <summary>
        /// Geo location
        /// </summary>
        IGeoLocation GeoLocation { get; }

        /// <summary>
        /// Rule keys
        /// </summary>
        string[] RuleKeys { get; }

        /// <summary>
        /// Client keys
        /// </summary>
        string[] ClientKeys { get; }

        /// <summary>
        /// Player keys
        /// </summary>
        byte[] PlayerKeys { get; }

        /// <summary>
        /// Player values
        /// </summary>
        ISAMPServerPlayer[] PlayerValues { get; }

        /// <summary>
        /// Ping
        /// </summary>
        uint Ping { get; }

        /// <summary>
        /// IP and port string
        /// </summary>
        string IPPortString { get; }

        /// <summary>
        /// Is data fetched
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <returns>Data fetched</returns>
        bool IsDataFetched(ERequestResponseType requestType);

        /// <summary>
        /// Fetch any data
        /// </summary>
        void FetchAnyData();

        /// <summary>
        /// Fetch any data asynchronous
        /// </summary>
        void FetchAnyDataAsync();

        /// <summary>
        /// Fetch multiple data
        /// </summary>
        /// <param name="requestTypes">Request types</param>
        void FetchMultiData(ERequestResponseType[] requestTypes);

        /// <summary>
        /// Fetch data
        /// </summary>
        /// <param name="requestType">Request type</param>
        void FetchData(ERequestResponseType requestType);

        /// <summary>
        /// Fetch data asynchronous
        /// </summary>
        /// <param name="requestType">Request type</param>
        void FetchDataAsync(ERequestResponseType requestType);

        /// <summary>
        /// Send query when expired
        /// </summary>
        /// <param name="requestType">Request type</param>
        /// <param name="milliseconds">Milliseconds</param>
        /// <returns>"true" if attempted sending query, othewrwise "false"</returns>
        bool SendQueryWhenExpiredAsync(ERequestResponseType requestType, uint milliseconds);

        /// <summary>
        /// Force request
        /// </summary>
        void ForceRequest();

        /// <summary>
        /// Get rule value
        /// </summary>
        /// <param name="ruleName">Rule name</param>
        /// <returns>Rule value</returns>
        string GetRuleValue(string ruleName);

        /// <summary>
        /// Get score from client
        /// </summary>
        /// <param name="clientName">Client name</param>
        /// <returns></returns>
        int GetScoreFromClient(string clientName);

        /// <summary>
        /// Get player
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Player</returns>
        ISAMPServerPlayer GetPlayer(byte id);

        /// <summary>
        /// To favourites server
        /// </summary>
        /// <param name="serverPassword">Server password</param>
        /// <param name="rconPassword">RCON password</param>
        /// <returns></returns>
        IFavouriteSAMPServer ToFavouriteServer(string serverPassword, string rconPassword);

        /// <summary>
        /// To favourites server
        /// </summary>
        /// <param name="serverPassword">Server password</param>
        /// <param name="rconPassword">RCON password</param>
        /// <returns></returns>
        IFavouriteSAMPServer ToFavouriteServer();
    }
}
