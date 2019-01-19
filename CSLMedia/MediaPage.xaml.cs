using CSLPI;
using System.Windows.Controls;

/// <summary>
/// Community San Andreas Multiplayer Launcher media namespace
/// </summary>
namespace CSLMedia
{
    /// <summary>
    /// Media page class
    /// </summary>
    public partial class MediaPage : UserControl, ICSLModule, ICSLPage
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
        /// Title
        /// </summary>
        public string Title => "MEDIA";

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
        /// Default constructor
        /// </summary>
        public MediaPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Intialize Community San Andreas Multiplayer Launcher module
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
