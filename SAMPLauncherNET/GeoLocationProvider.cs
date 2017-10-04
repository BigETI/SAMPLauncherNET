using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Geo location provider
    /// </summary>
    public class GeoLocationProvider
    {
        /// <summary>
        /// Endpoint
        /// </summary>
        private readonly string endpoint;

        /// <summary>
        /// Serializer
        /// </summary>
        private DataContractJsonSerializer serializer;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="endpoint">Endpoint</param>
        /// <param name="type">Serialization type</param>
        public GeoLocationProvider(string endpoint, Type serializationType)
        {
            this.endpoint = endpoint;
            serializer = new DataContractJsonSerializer(serializationType);
        }

        /// <summary>
        /// Request data
        /// </summary>
        /// <param name="host">Host</param>
        /// <returns>Geo location data</returns>
        public GeoLocationData RequestData(string host)
        {
            GeoLocationData ret = null;
            try
            {
                WebClientEx wc = new WebClientEx(1000);
                wc.Headers.Set(HttpRequestHeader.Accept, "application/json");
                wc.Headers.Set(HttpRequestHeader.UserAgent, ServerListConnector.APIHTTPUserAgent);
                using (MemoryStream stream = new MemoryStream(wc.DownloadData(endpoint + host)))
                {
                    object result = serializer.ReadObject(stream);
                    if (result != null)
                    {
                        ret = new GeoLocationData(result);
                    }
                }
            }
            catch
            {
                //
            }
            return ret;
        }
    }
}
