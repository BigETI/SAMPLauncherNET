using System;
/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// SA:MP version
    /// </summary>
    public class SAMPVersion : IComparable<SAMPVersion>
    {
        /// <summary>
        /// Name
        /// </summary>
        private string name;

        /// <summary>
        /// Zip URI
        /// </summary>
        private string zipURI;

        /// <summary>
        /// Installation URI
        /// </summary>
        private string installationURI;

        /// <summary>
        /// Order number
        /// </summary>
        private uint orderNumber = 0U;

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
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="zipURI">Zip URI</param>
        /// <param name="installationURI">Installation URI</param>
        /// <param name="dllSHA512">DLL SHA512</param>
        public SAMPVersion(string name, string zipURI, string installationURI, uint orderNumber = 0U)
        {
            this.name = name;
            this.zipURI = zipURI;
            this.installationURI = installationURI;
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
        public int CompareTo(SAMPVersion other)
        {
            int ret = -1;
            if (other != null)
            {
                ret = (int)(other.orderNumber - orderNumber);
                if (ret == 0)
                {
                    ret = other.name.CompareTo(name);
                    if (ret == 0)
                    {
                        ret = other.zipURI.CompareTo(zipURI);
                        if (ret == 0)
                            ret = other.installationURI.CompareTo(installationURI);
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Equals operator
        /// </summary>
        /// <param name="left">Left</param>
        /// <param name="right">Right</param>
        /// <returns>Result</returns>
        /*public static bool operator ==(SAMPVersion left, SAMPVersion right)
        {
            bool ret = false;
            if ((left == null) && (right == null))
                ret = true;
            else if ((left == null) || (right == null))
                ret = false;
            else
                ret = (left.CompareTo(right) == 0);
            return ret;
        }*/

        /// <summary>
        /// Does not equal operator
        /// </summary>
        /// <param name="left">Left</param>
        /// <param name="right">Right</param>
        /// <returns>Result</returns>
        /*public static bool operator !=(SAMPVersion left, SAMPVersion right)
        {
            return !(left == right);
        }*/
    }
}
