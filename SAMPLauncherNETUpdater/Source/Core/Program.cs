using SAMPLauncherNETUpdater.UI;
using System;
using System.Windows.Forms;

/// <summary>
/// SA:MP launcher .NET updater namespace
/// </summary>
namespace SAMPLauncherNETUpdater
{
    /// <summary>
    /// Program class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
