using System;
using System.Runtime.Serialization;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// SA:MP version
    /// </summary>
    [DataContract]
    public class SAMPVersionDataContract : IComparable<SAMPVersionDataContract>
    {
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// Internet tap URI
        /// </summary>
        [DataMember]
        private string internetTabURI;

        /// <summary>
        /// Hosted tab URI
        /// </summary>
        [DataMember]
        private string hostedTabURI;

        /// <summary>
        /// Official tab URI
        /// </summary>
        [DataMember]
        private string officialTabURI;

        /// <summary>
        /// User agent
        /// </summary>
        [DataMember]
        private string userAgent;

        /// <summary>
        /// Zip URI
        /// </summary>
        [DataMember]
        private string zipURI;

        /// <summary>
        /// Installation URI
        /// </summary>
        [DataMember]
        private string installationURI;

        /// <summary>
        /// samp.dll SHA512
        /// </summary>
        [DataMember]
        private string sampDLLSHA512;

        /// <summary>
        /// Order number
        /// </summary>
        [DataMember]
        private uint orderNumber;

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                if (name == null)
                {
                    name = "";
                }
                return name;
            }
        }

        /// <summary>
        /// Internet tab URI
        /// </summary>
        public string InternetTabURI
        {
            get
            {
                if (internetTabURI == null)
                {
                    internetTabURI = "";
                }
                return internetTabURI;
            }
        }

        /// <summary>
        /// Hosted tab URI
        /// </summary>
        public string HostedTabURI
        {
            get
            {
                if (hostedTabURI == null)
                {
                    hostedTabURI = "";
                }
                return hostedTabURI;
            }
        }

        /// <summary>
        /// Official tab URI
        /// </summary>
        public string OfficialTabURI
        {
            get
            {
                if (officialTabURI == null)
                {
                    officialTabURI = "";
                }
                return officialTabURI;
            }
        }

        /// <summary>
        /// User agent
        /// </summary>
        public string UserAgent
        {
            get
            {
                if (userAgent == null)
                {
                    userAgent = "";
                }
                return userAgent;
            }
        }

        /// <summary>
        /// Zip URI
        /// </summary>
        public string ZipURI
        {
            get
            {
                if (zipURI == null)
                {
                    zipURI = "";
                }
                return zipURI;
            }
        }

        /// <summary>
        /// Installation URI
        /// </summary>
        public string InstallationURI
        {
            get
            {
                if (installationURI == null)
                {
                    installationURI = "";
                }
                return installationURI;
            }
        }

        /// <summary>
        /// samp.dll SHA512
        /// </summary>
        public string SAMPDLLSHA512
        {
            get
            {
                if (sampDLLSHA512 == null)
                {
                    sampDLLSHA512 = "";
                }
                return sampDLLSHA512;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="internetTabURI">Internet tab URI</param>
        /// <param name="hostedTabURI">Hosted tab URI</param>
        /// <param name="officialTabURI">Official tab URI</param>
        /// <param name="userAgent">User agent</param>
        /// <param name="zipURI">Zip URI</param>
        /// <param name="installationURI">Installation URI</param>
        /// <param name="sampDLLSHA512">SA:MP DLL SHA512</param>
        /// <param name="orderNumber">Order number</param>
        public SAMPVersionDataContract(string name, string internetTabURI, string hostedTabURI, string officialTabURI, string userAgent, string zipURI, string installationURI, string sampDLLSHA512, uint orderNumber)
        {
            this.name = name;
            this.internetTabURI = internetTabURI;
            this.hostedTabURI = hostedTabURI;
            this.officialTabURI = officialTabURI;
            this.userAgent = userAgent;
            this.zipURI = zipURI;
            this.installationURI = installationURI;
            this.sampDLLSHA512 = sampDLLSHA512;
            this.orderNumber = orderNumber;
        }

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>String representation</returns>
        public override string ToString()
        {
            return name;
        }

        /// <summary>
        /// Compare to
        /// </summary>
        /// <param name="other">Other</param>
        /// <returns>Compared value</returns>
        public int CompareTo(SAMPVersionDataContract other)
        {
            int ret = -1;
            if (other != null)
            {
                ret = orderNumber.CompareTo(other.orderNumber);
                if (ret == 0)
                {
                    ret = string.Compare(other.name, name, StringComparison.InvariantCulture);
                }
            }
            return ret;
        }
    }
}
