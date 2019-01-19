using System.IO;
using System.Runtime.Serialization;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Configuration data contract class
    /// </summary>
    [DataContract]
    internal class ConfigurationDataContract
    {
        /// <summary>
        /// Modules path
        /// </summary>
        [DataMember]
        private string modulesPath;

        /// <summary>
        /// Modules path
        /// </summary>
        public string ModulesPath
        {
            get
            {
                if (modulesPath == null)
                {
                    modulesPath = "." + Path.DirectorySeparatorChar + "modules" + Path.DirectorySeparatorChar;
                }
                return modulesPath;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        internal ConfigurationDataContract()
        {
            // ...
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="modulesPath">Modules path</param>
        public ConfigurationDataContract(string modulesPath)
        {
            this.modulesPath = modulesPath;
        }
    }
}
