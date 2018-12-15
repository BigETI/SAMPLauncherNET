using System;
using System.Runtime.Serialization;
/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
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
        private readonly string name;

        /// <summary>
        /// Internet tap URI
        /// </summary>
        [DataMember]
        private readonly string internetTabURI;

        /// <summary>
        /// Hosted tab URI
        /// </summary>
        [DataMember]
        private readonly string hostedTabURI;

        /// <summary>
        /// Official tab URI
        /// </summary>
        [DataMember]
        private readonly string officialTabURI;

        /// <summary>
        /// User agent
        /// </summary>
        [DataMember]
        private readonly string userAgent;

        /// <summary>
        /// Zip URI
        /// </summary>
        [DataMember]
        private readonly string zipURI;

        /// <summary>
        /// Installation URI
        /// </summary>
        [DataMember]
        private readonly string installationURI;

        /// <summary>
        /// samp.dll SHA512
        /// </summary>
        [DataMember]
        private readonly string sampDLLSHA512;

        /// <summary>
        /// Order number
        /// </summary>
        [DataMember]
        private readonly uint orderNumber;

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
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
                ret = (int)(other.orderNumber - orderNumber);
                if (ret == 0)
                {
                    ret = string.Compare(other.name, name, StringComparison.InvariantCulture);
                }
            }
            return ret;
        }
    }
}
