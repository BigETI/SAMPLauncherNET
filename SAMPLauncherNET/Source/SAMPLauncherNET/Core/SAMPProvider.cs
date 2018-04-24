using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
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
        /// Versions URI
        /// </summary
        private static readonly string VersionsURI = "https://raw.githubusercontent.com/BigETI/SAMPLauncherNET/master/versions.json";

        /// <summary>
        /// API HTTP content type
        /// </summary>
        private static readonly string APIHTTPContentType = "text/html";

        /// <summary>
        /// API HTTP accept
        /// </summary>
        private static readonly string APIHTTPAccept = "text/html, */*";

        /// <summary>
        /// API HTTP user agent
        /// </summary>
        private static readonly string APIHTTPUserAgent = "Mozilla/3.0 (compatible; SA:MP launcher .NET)";

        /// <summary>
        /// Current version
        /// </summary>
        private static SAMPVersionDataContract currentVersion;

        /// <summary>
        /// Version required
        /// </summary>
        private static bool versionRequired = true;

        /// <summary>
        /// Versions
        /// </summary>
        private static Dictionary<string, SAMPVersionDataContract> versions;

        /// <summary>
        /// Versions
        /// </summary>
        public static Dictionary<string, SAMPVersionDataContract> Versions
        {
            get
            {
                if (versions == null)
                {
                    versions = new Dictionary<string, SAMPVersionDataContract>();
                    try
                    {
                        using (WebClientEx wc = new WebClientEx(5000))
                        {
                            wc.Headers.Set(HttpRequestHeader.ContentType, APIHTTPContentType);
                            wc.Headers.Set(HttpRequestHeader.Accept, APIHTTPAccept);
                            wc.Headers.Set(HttpRequestHeader.UserAgent, APIHTTPUserAgent);
                            using (MemoryStream stream = new MemoryStream(wc.DownloadData(VersionsURI)))
                            {
                                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<SAMPVersionDataContract>));
                                List<SAMPVersionDataContract> samp_versions = serializer.ReadObject(stream) as List<SAMPVersionDataContract>;
                                if (samp_versions != null)
                                {
                                    foreach (SAMPVersionDataContract version in samp_versions)
                                    {
                                        versions.Add(version.SAMPDLLSHA512, version);
                                    }
                                }
                            }
                        }

                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                }
                return versions;
            }
        }

        /// <summary>
        /// Versions list
        /// </summary>
        public static List<SAMPVersionDataContract> VersionsList
        {
            get
            {
                List<SAMPVersionDataContract> ret = new List<SAMPVersionDataContract>(Versions.Values);
                ret.Sort();
                return ret;
            }
        }

        /// <summary>
        /// Current Version
        /// </summary>
        public static SAMPVersionDataContract CurrentVersion
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
                                    if (Versions.ContainsKey(key))
                                    {
                                        currentVersion = Versions[key];
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                }
                return currentVersion;
            }
        }

        /// <summary>
        /// User agent
        /// </summary>
        public static string UserAgent
        {
            get
            {
                return ((CurrentVersion == null) ? APIHTTPUserAgent : CurrentVersion.UserAgent);
            }
        }

        /// <summary>
        /// Internet tab URI
        /// </summary>
        public static string InternetTabURI
        {
            get
            {
                return ((CurrentVersion == null) ? "" : CurrentVersion.InternetTabURI);
            }
        }

        /// <summary>
        /// Hosted tab URI
        /// </summary>
        public static string HostedTabURI
        {
            get
            {
                return ((CurrentVersion == null) ? "" : CurrentVersion.HostedTabURI);
            }
        }

        /// <summary>
        /// Official tab URI
        /// </summary>
        public static string OfficialTabURI
        {
            get
            {
                return ((CurrentVersion == null) ? "" : CurrentVersion.OfficialTabURI);
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
