using CSLPI;
using System;
using System.IO;
using System.Windows.Controls;

/// <summary>
/// Community San Andreas Multiplayer Launcher about namespace
/// </summary>
namespace CSLAbout
{
    /// <summary>
    /// About page class
    /// </summary>
    public partial class AboutPage : UserControl, ICSLModule, ICSLPage
    {
        /// <summary>
        /// Configuration path
        /// </summary>
        private static readonly string ConfigurationPath = Path.Combine(Path.Combine(Environment.CurrentDirectory, "config"), "about.json");

        /// <summary>
        /// Community San Andreas Multiplayer Launcher
        /// </summary>
        private ICSL csl;

        /// <summary>
        /// Configuration
        /// </summary>
        private Configuration configuration;

        /// <summary>
        /// Default constructor
        /// </summary>
        public AboutPage()
        {
            InitializeComponent();
            ModuleConfiguration.Load(ConfigurationPath);
        }

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
        public string Title => "ABOUT";

        /// <summary>
        /// Initialize Community San Andreas Multiplayer Launcher module
        /// </summary>
        /// <param name="csl">Community San Andreas Multiplayer Launcher</param>
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
