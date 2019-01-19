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
        /// Community San Andreas Multiplayer Launcher modules name
        /// </summary>
        private string name;

        /// <summary>
        /// Community San Andreas Multiplayer Launcher modules
        /// </summary>
        private ICSLModule[] modules;

        /// <summary>
        /// Community San Andreas Multiplayer Launcher pages
        /// </summary>
        private ICSLPage[] pages;

        /// <summary>
        /// Community San Andreas Multiplayer Launcher modules name
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
        /// <param name="name">Name</param>
        /// <param name="module">Module</param>
        /// <param name="pages">Pages</param>
        internal ModulesData(string name, ICSLModule[] modules, ICSLPage[] pages)
        {
            this.name = name;
            this.modules = modules;
            this.pages = pages;
        }
    }
}
