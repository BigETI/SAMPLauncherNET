using System.Collections.Generic;
using MetroFramework;
using MetroTranslatorStyler;

namespace SAMPLauncherNET
{
    public class TranslatorStylerInterface : ITranslatorStylerInterface
    {
        private Language[] languages = new Language[] { new Language("ENGLISH", "en-GB"), new Language("GERMAN", "de-DE") };

        public string Language
        {
            get
            {
                return Properties.Settings.Default.Language;
            }
            set
            {
                Properties.Settings.Default["Language"] = value;
            }
        }

        public string AssemblyName
        {
            get
            {
                return "SAMPLauncherNET";
            }
        }

        public IEnumerable<Language> Languages
        {
            get
            {
                return languages;
            }
        }

        public MetroThemeStyle UseTheme
        {
            get
            {
                return Properties.Settings.Default.Theme;
            }
            set
            {
                Properties.Settings.Default["Theme"] = value;
            }
        }
        public MetroColorStyle UseStyle
        {
            get
            {
                return Properties.Settings.Default.Style;
            }
            set
            {
                Properties.Settings.Default["Style"] = value;
            }
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
    }
}
