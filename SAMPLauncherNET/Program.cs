using Microsoft.Win32;
using System;
using System.Windows.Forms;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    static class Program
    {
        // Dirty
        public static readonly string RegistryKey = "HKEY_CURRENT_USER\\SOFTWARE\\SAMP";

        public static bool IsSAMPInstalled
        {
            get
            {
                bool ret = false;
                try
                {
                    ret = (Registry.GetValue(RegistryKey, "gta_sa_exe", null) != null) && (Registry.GetValue(RegistryKey, "PlayerName", null) != null);
                }
                catch
                {
                    //
                }
                return ret;
            }
        }

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Translator.TranslatorInterface = new TranslatorInterface();
            if (IsSAMPInstalled)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else
                MessageBox.Show("San Andreas Multiplayer is not installed.\r\nTo use this application, you have to install GTA San Andreas and San Andreas Multiplayer first.", "San Andreas Multiplayer is not installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
