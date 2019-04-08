using CSLPI;

/// <summary>
/// Community San Andreas Multiplayer Launcher namespace
/// </summary>
namespace CSL
{
    /// <summary>
    /// Community San Andreas Multiplayer Launcher module data structure
    /// </summary>
    internal struct ModulesData
    {
        /// <summary>
        /// Data
        /// </summary>
        private ModulesDataContract data;

        /// <summary>
        /// Assembly version
        /// </summary>
        private string assemblyVersion;

        /// <summary>
        /// File version
        /// </summary>
        private string fileVersion;

        /// <summary>
        /// Product version
        /// </summary>
        private string productVersion;

        /// <summary>
        /// Community San Andreas Multiplayer Launcher modules
        /// </summary>
        private ICSLModule[] modules;

        /// <summary>
        /// Community San Andreas Multiplayer Launcher pages
        /// </summary>
        private ICSLPage[] pages;

        /// <summary>
        /// Data
        /// </summary>
        public ModulesDataContract Data
        {
            get
            {
                if (data == null)
                {
                    data = new ModulesDataContract();
                }
                return data;
            }
        }

        /// <summary>
        /// Community San Andreas Multiplayer Launcher modules
        /// </summary>
        public ICSLModule[] Modules
        {
            get
            {
                if (modules == null)
                {
                    modules = new ICSLModule[0];
                }
                return modules.Clone() as ICSLModule[];
            }
        }

        /// <summary>
        /// Community San Andreas Multiplayer Launcher pages
        /// </summary>
        public ICSLPage[] Pages
        {
            get
            {
                if (pages == null)
                {
                    pages = new ICSLPage[0];
                }
                return pages.Clone() as ICSLPage[];
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data">Data</param>
        /// <param name="assemblyVersion">Assembly version</param>
        /// <param name="fileVersion">File version</param>
        /// <param name="productVersion">Product version</param>
        /// <param name="modules">Community San Andreas Multiplayer Launcher modules</param>
        /// <param name="pages">Community San Andreas Multiplayer Launcher pages</param>
        internal ModulesData(ModulesDataContract data, string assemblyVersion, string fileVersion, string productVersion, ICSLModule[] modules, ICSLPage[] pages)
        {
            this.data = data;
            this.assemblyVersion = assemblyVersion;
            this.fileVersion = fileVersion;
            this.productVersion = productVersion;
            this.modules = modules;
            this.pages = pages;
        }
    }
}
