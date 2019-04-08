using CSLPI;
using System;
using System.IO;
using System.Windows.Controls;

/// <summary>
/// Community San Andreas Multiplayer Launcher developer tools namespace
/// </summary>
namespace CSLDeveloperTools
{
    /// <summary>
    /// Developer tools page class
    /// </summary>
    public partial class DeveloperToolsPage : UserControl, ICSLModule, ICSLPage
    {
        /// <summary>
        /// Configuration path
        /// </summary>
        private static readonly string ConfigurationPath = Path.Combine(Path.Combine(Environment.CurrentDirectory, "config"), "developer_tools.json");

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
        public string Title => "DEVELOPER_TOOLS";

        /// <summary>
        /// Default constructor
        /// </summary>
        public DeveloperToolsPage()
        {
            InitializeComponent();
            ModuleConfiguration.Load(ConfigurationPath);
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
            ModuleConfiguration.Save(ConfigurationPath);
        }
    }
}
