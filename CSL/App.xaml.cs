using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CSL
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        public static void Main()
        {
            App application = new App();
            application.InitializeComponent();
            application.Run();
        }
    }
}
