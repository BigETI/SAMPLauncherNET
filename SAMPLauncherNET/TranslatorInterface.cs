using System.Collections.Generic;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Translator interface class
    /// </summary>
    public class TranslatorInterface : ITranslatorInterface
    {
        /// <summary>
        /// Languages
        /// </summary>
        private Language[] languages = new Language[] { new Language("DUTCH", "nl-BE"), new Language("ENGLISH", "en-GB"), new Language("GEORGIAN", "ge-GE"), new Language("GERMAN", "de-DE"), new Language("RUSSIAN", "ru-RU") , new Language("PORTUGUESE", "pt-BR") };

        /// <summary>
        /// Language
        /// </summary>
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

        /// <summary>
        /// Fallback language
        /// </summary>
        public string FallbackLanguage
        {
            get
            {
                return "en-GB";
            }
        }

        /// <summary>
        /// Assembly name
        /// </summary>
        public string AssemblyName
        {
            get
            {
                return "SAMPLauncherNET";
            }
        }

        /// <summary>
        /// Languages
        /// </summary>
        public IEnumerable<Language> Languages
        {
            get
            {
                return languages;
            }
        }

        /// <summary>
        /// Save settings
        /// </summary>
        public void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }
    }
}
