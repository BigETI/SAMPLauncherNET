using CSLPI;
using System.Windows.Controls;

/// <summary>
/// Community San Andreas Multiplayer Launcher ASI plugins namespace
/// </summary>
namespace CSLASIPlugins
{
    /// <summary>
    /// ASI plugins page class
    /// </summary>
    public partial class ASIPluginsPage : UserControl, ICSLModule, ICSLPage
    {
        /// <summary>
        /// Community San Andreas Multiplayer Launcher
        /// </summary>
        private ICSL csl;

        /// <summary>
        /// Configuration
        /// </summary>
        private Configuration configuration;

        /// <summary>
        /// Community San Andreas Multiplayer Launcher module configuration
        /// </summary>
        public ACSLConfiguration ModuleConfiguration
        {
            get
            {
                if (configuration == null)
                {
                    configuration = new Configuration();
                }
                return configuration;
            }
        }

        /// <summary>
        /// Title
        /// </summary>
        public string Title => "ASI_PLUGINS";

        /// <summary>
        /// Default constructor
        /// </summary>
        public ASIPluginsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize Community San Andreas Multiplayer Launcher module
        /// </summary>
        /// <param name="csl"></param>
        public void Init(ICSL csl)
        {
            this.csl = csl;
        }

        /// <summary>
        /// Exit Community San Andreas Multiplayer Launcher module
        /// </summary>
        public void Exit()
        {
            // ...
        }
    }
}
