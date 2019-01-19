using CSLPI;
using System.Windows.Controls;

/// <summary>
/// Community San Andreas Multiplayer Launcher dashboard namespace
/// </summary>
namespace CSLDashboard
{
    /// <summary>
    /// Dashboard page class
    /// </summary>
    public partial class DashboardUserControl : UserControl, ICSLModule, ICSLPage
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
        /// Default constructor
        /// </summary>
        public DashboardUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Module configuration
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
        public string Title => "DASHBOARD";

        /// <summary>
        /// Initialize module
        /// </summary>
        /// <param name="csl">Community San Andreas Multiplayer Launcher</param>
        public void Init(ICSL csl)
        {
            this.csl = csl;
        }

        /// <summary>
        /// Exit module
        /// </summary>
        public void Exit()
        {
            // ...
        }
    }
}
