using System.Runtime.Serialization;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// API data contract
    /// </summary>
    [DataContract]
    public class APIDataContract
    {
        /// <summary>
        /// API name
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// API type
        /// </summary>
        [DataMember]
        private string type;

        /// <summary>
        /// API endpoint
        /// </summary>
        [DataMember]
        private string endpoint;

        /// <summary>
        /// API name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// API type
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// API endpoint
        /// </summary>
        public string Endpoint
        {
            get
            {
                return endpoint;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public APIDataContract()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="type">Type</param>
        /// <param name="endpoint">Endpoint</param>
        public APIDataContract(string name, string type, string endpoint)
        {
            this.name = name;
            this.type = type;
            this.endpoint = endpoint;
        }
    }
}
