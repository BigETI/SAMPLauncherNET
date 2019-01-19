using CSLPI;
using System;
using System.IO;
using System.Runtime.Serialization.Json;

/// <summary>
/// Community San Andreas Multiplayer Launcher San Andreas Multiplayer versions namespace
/// </summary>
namespace CSLSAMPVersions
{
    /// <summary>
    /// Configuration class
    /// </summary>
    internal class Configuration : ACSLConfiguration
    {
        /// <summary>
        /// Serializer
        /// </summary>
        private DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ConfigurationDataContract));

        /// <summary>
        /// Configuration
        /// </summary>
        private ConfigurationDataContract configurationData;

        /// <summary>
        /// Configuration data
        /// </summary>
        internal ConfigurationDataContract ConfigurationData
        {
            get
            {
                if (configurationData == null)
                {
                    configurationData = new ConfigurationDataContract();
                }
                return configurationData;
            }
        }

        /// <summary>
        /// Load configuration
        /// </summary>
        /// <param name="path">Configuration path</param>
        public override void Load(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read))
                    {
                        ConfigurationDataContract configuration_data = serializer.ReadObject(stream) as ConfigurationDataContract;
                        if (configuration_data != null)
                        {
                            configurationData = configuration_data;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }

        /// <summary>
        /// Save configuration
        /// </summary>
        /// <param name="path">Configuration path</param>
        public override void Save(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (FileStream stream = File.Open(path, FileMode.Create, FileAccess.Write))
                {
                    serializer.WriteObject(stream, ConfigurationData);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
        }
    }
}
