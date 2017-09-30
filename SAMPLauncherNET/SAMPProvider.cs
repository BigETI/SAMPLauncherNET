using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// SA:MP provider class
    /// </summary>
    public static class SAMPProvider
    {
        /// <summary>
        /// Current version
        /// </summary>
        private static SAMPVersion currentVersion = null;

        /// <summary>
        /// Version required
        /// </summary>
        private static bool versionRequired = true;

        /// <summary>
        /// Versions
        /// </summary>
        private static Dictionary<string, SAMPVersion> versions = new Dictionary<string, SAMPVersion>()
        {
            { "SxplMI/xGDXr5ZcXtB9l8pzEY1FIbSf9dIvpdkUGoB221m6TeFYV/tKX3WPrR2bxo4Xgk2gqdu+yI4bjIhwWMA==", new SAMPVersion("SA:MP 0.1b", "http://bigeti.de/mods/SAMP/Installations/samp01b-installer.zip", "http://files.sa-mp.com/samp01b-installer.exe", 0U) },
            { "2mLrwksSCFDpSQPB39vqv200vb3OMCk3eAlnjq75f9jVojcgOXjo6ruqftRVl1O1kgMFHVPfO1GcxCNT67RVrA==", new SAMPVersion("SA:MP 0.2.2-R3_a", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.2.2-R3_a.zip", "http://files.sa-mp.com/sa-mp-0.2.2-R3_a.exe", 1U) },
            { "EGmbJIXvp00yZ0aOvqwRnHoBRBHVwbIfH+b7EaErGuQTfk10EC3gWpJpXY97msHbutsPkL9MlXh577ljSdERyQ==", new SAMPVersion("SA:MP 0.2X-u1_2", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.2X-u1_2-install.zip", "http://files.sa-mp.com/sa-mp-0.2X-u1_2-install.exe", 2U) },
            { "XdOv6zhVI3mzh0a2eZ/wAAtqz6ZZgaMkhAU4QQvQ7BWDqRwkmSMftTkZigkdf3RVOR4XZOcC3VqqYl7ZlbNUqA==", new SAMPVersion("SA:MP 0.3a", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3a-install.zip", "http://files.sa-mp.com/sa-mp-0.3a-install.exe", 3U) },
            { "j2GWQt8BNu7JrP+ubvIA6eNeaj9fW+u17IzLbucY8t1QP3i47Qf/J+G9ds/5RiN1zMOFkZ7kQb3KBDlRalKYVA==", new SAMPVersion("SA:MP 0.3c", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3c-install.zip", "http://files.sa-mp.com/sa-mp-0.3c-install.exe", 4U) },
            { "N1deN3bE58N4G4gvK9x4+VXlk6VS47FQ+fAtP4jG8GlMNoG/aBap3iCCpgZWska2SueV0T2kSaJrs0Ay5WinKA==", new SAMPVersion("SA:MP 0.3c-R3", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3c-R3-install.zip", "http://files.sa-mp.com/sa-mp-0.3c-R3-install.exe", 5U) },
            { "vcRUCbPTcBvT4Shk3hFMPZPPoMS5sKcY1IZ/yOzXMGvCANDtyKBb46ZSEU25z0/Eb0Fj59Xi4+rG6MU9jKH79Q==", new SAMPVersion("SA:MP 0.3d-R2", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3d-R2-install.zip", "http://files.sa-mp.com/sa-mp-0.3d-R2-install.exe", 6U) },
            { "85BJiO1pN+bYzmjpDOzCEAoFn8FX8NaoZucT6jK/dyq+imoPdV1IDfFcXI2VWmaFAKiP9X2c8C3rOwz4RwGpzQ==", new SAMPVersion("SA:MP 0.3e", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3e-install.zip", "http://files.sa-mp.com/sa-mp-0.3e-install.exe", 7U) },
            { "qA9TM22lO70CM31n+ujW6zQKDeadAkI7rK7m23eAJyqQ+WrZgOb66UazpQCHy8e+n8VQXg3vrscdWTYrsl2wnQ==", new SAMPVersion("SA:MP 0.3x-R1-2", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3x-R1-2-install.zip", "http://files.sa-mp.com/sa-mp-0.3x-R1-2-install.exe", 8U) },
            { "UCAPOfPRWGTPxlH8v/QCofsNekgtgo9lJ1aCFICWwUqCQoxxDdoLE9J2+OBCXQdIn1mPVtDCf0kexv1qCwFhgQ==", new SAMPVersion("SA:MP 0.3x-R2", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3x-R2-install.zip", "http://files.sa-mp.com/sa-mp-0.3x-R2-install.exe", 9U) },
            { "08uPhPCuam8TCGXag4op1t6b8GXZKta1e41zbLtXq1KLl1Vg4fnerP6rlRpgC1MKbRh6IbhaiS+L/m59pG61dw==", new SAMPVersion("SA:MP 0.3z-R1", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3z-R1-install.zip", "http://files.sa-mp.com/sa-mp-0.3z-R1-install.exe", 10U) },
            { "rLRn+UqORgyDvTljTLDp+TUasgEhUJxXIxhepBf6AeTISTENdP2HIx7BOn4bE+fJt2Cowc5scNJ1n9jDFwQJsg==", new SAMPVersion("SA:MP 0.3z-R2", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3z-R2-install.zip", "http://files.sa-mp.com/sa-mp-0.3z-R2-install.exe", 11U) },
            { "GGbK+iME4k1AuzVVhu+QaO0fn8j6+FFaGgwYONR0y5Xegq0WEZSOMTxIpkULD7iAPhQfOlP2em1XSKEtwNILLg==", new SAMPVersion("SA:MP 0.3.7", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3.7-install.zip", "http://files.sa-mp.com/sa-mp-0.3.7-install.exe", 12U) },
            { "FguJEPUaX2mbLVl9gQXpEVsRcP6ypKt8T106lhrBNitTCOz8xZeCTsNvVzzKrgyby87Rq2vSBXmbr7MdmAc+ZQ==", new SAMPVersion("SA:MP 0.3.7-R2", "http://bigeti.de/mods/SAMP/Installations/sa-mp-0.3.7-R2-install.zip", "http://files.sa-mp.com/sa-mp-0.3z-R2-install.exe", 13U) }
        };

        /// <summary>
        /// Versions
        /// </summary>
        public static IEnumerable<SAMPVersion> Versions
        {
            get
            {
                List<SAMPVersion> ret = new List<SAMPVersion>(versions.Values);
                ret.Sort();
                return ret;
            }
        }

        /// <summary>
        /// Current Version
        /// </summary>
        public static SAMPVersion CurrentVersion
        {
            get
            {
                if (versionRequired)
                {
                    versionRequired = false;
                    try
                    {
                        if (File.Exists(SAMP.SAMPDLLPath))
                        {
                            using (SHA512 sha512 = SHA512.Create())
                            {
                                using (FileStream stream = new FileStream(SAMP.SAMPDLLPath, FileMode.Open))
                                {
                                    string key = Convert.ToBase64String(sha512.ComputeHash(stream));
                                    if (versions.ContainsKey(key))
                                        currentVersion = versions[key];
                                }
                            }
                        }
                    }
                    catch
                    {
                        //
                    }
                }
                return currentVersion;
            }
        }

        /// <summary>
        /// Reset version cache
        /// </summary>
        public static void ResetVersionCache()
        {
            versionRequired = true;
            currentVersion = null;
        }
    }
}
