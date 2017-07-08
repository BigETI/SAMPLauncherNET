using System.Collections.Generic;
using WinFormsTranslator;

namespace SAMPLauncherNET
{
    public class TranslatorInterface : ITranslatorInterface
    {

        private Language[] languages = new Language[] { new Language("DUTCH", "nl-BE"), new Language("ENGLISH", "en-GB"), new Language("GERMAN", "de-DE") };

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

        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
    }
}
