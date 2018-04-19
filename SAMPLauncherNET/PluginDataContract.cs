using System;
using System.Runtime.Serialization;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Plugin data contract class
    /// </summary>
    [DataContract]
    public class PluginDataContract : IComparable, IComparable<PluginDataContract>, ITranslatable
    {
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        private string name;

        /// <summary>
        /// Plugin provider
        /// </summary>
        [DataMember]
        private string provider;

        /// <summary>
        /// Plugin URI
        /// </summary>
        [DataMember]
        private string uri;

        /// <summary>
        /// Is plugin enabled
        /// </summary>
        [DataMember]
        private bool enabled = true;

        /// <summary>
        /// Update frequency
        /// </summary>
        [DataMember]
        private string updateFrequency;

        /// <summary>
        /// Plugin provider item
        /// </summary>
        private EPluginProvider providerItem;

        /// <summary>
        /// Plugin provider item parsed
        /// </summary>
        private bool providerItemParsed;

        /// <summary>
        /// Plugin update frequency item
        /// </summary>
        private EUpdateFrequency updateFrequencyItem;

        /// <summary>
        /// Plugin update frequency item parsed
        /// </summary>
        private bool updateFrequencyItemParsed;

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
        /// Plugin provider
        /// </summary>
        public EPluginProvider Provider
        {
            get
            {
                if (!providerItemParsed)
                {
                    if (!(Enum.TryParse(provider, out providerItem)))
                    {
                        providerItem = EPluginProvider.URI;
                    }
                    providerItemParsed = true;
                }
                return providerItem;
            }
        }

        /// <summary>
        /// Plugin URI
        /// </summary>
        public string URI
        {
            get
            {
                return uri;
            }
        }

        /// <summary>
        /// Is plugin enabled
        /// </summary>
        public bool Enabled
        {
            get
            {
                return enabled;
            }
        }

        /// <summary>
        /// Is plugin enabled
        /// </summary>
        public EUpdateFrequency UpdateFrequency
        {
            get
            {
                if (!updateFrequencyItemParsed)
                {
                    if (!(Enum.TryParse(updateFrequency, out updateFrequencyItem)))
                    {
                        updateFrequencyItem = EUpdateFrequency.IfMissing;
                    }
                    updateFrequencyItemParsed = true;
                }
                return updateFrequencyItem;
            }
        }

        /// <summary>
        /// Translatable text
        /// </summary>
        public string TranslatableText
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="provider">Plugin provider</param>
        /// <param name="uri">Plugin URI</param>
        /// <param name="enabled">Is plugin enabled</param>
        /// <param name="updateFrequency">Plugin update frequency</param>
        public PluginDataContract(string name, EPluginProvider provider, string uri, bool enabled, EUpdateFrequency updateFrequency)
        {
            this.name = name;
            this.provider = provider.ToString();
            this.uri = uri;
            this.enabled = enabled;
            this.updateFrequency = updateFrequency.ToString();
            providerItem = provider;
            updateFrequencyItem = updateFrequency;
            providerItemParsed = true;
            updateFrequencyItemParsed = true;
        }

        /// <summary>
        /// Compare to
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Comparison</returns>
        public int CompareTo(object obj)
        {
            return ((obj is PluginDataContract) ? CompareTo((PluginDataContract)obj) : -1);
        }

        /// <summary>
        /// Compare to
        /// </summary>
        /// <param name="other">Other</param>
        /// <returns>Comparison</returns>
        public int CompareTo(PluginDataContract other)
        {
            int ret = -1;
            if (other != null)
            {
                ret = name.CompareTo(other.name);
                if (ret == 0)
                {
                    ret = uri.CompareTo(other.uri);
                    if (ret == 0)
                    {
                        ret = provider.CompareTo(other.provider);
                        if (ret == 0)
                        {
                            ret = enabled.CompareTo(other.enabled);
                            if (ret == 0)
                            {
                                ret = updateFrequency.CompareTo(other.updateFrequency);
                            }
                        }
                    }
                }
            }
            return ret;
        }
    }
}
