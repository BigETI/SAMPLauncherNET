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
        private readonly Language[] languages = new [] { new Language("DUTCH", "nl-BE"), new Language("ENGLISH", "en-GB"), new Language("GEORGIAN", "ge-GE"), new Language("GERMAN", "de-DE"), new Language("PORTUGUESE", "pt-PT"), new Language("PORTUGUESE_BRAZIL", "pt-BR"), new Language("RUSSIAN", "ru-RU") };

        /// <summary>
        /// Launcher configuration
        /// </summary>
        private LauncherConfigDataContract launcherConfig;

        /// <summary>
        /// Language
        /// </summary>
        public string Language
        {
            get
            {
                if (launcherConfig == null)
                {
                    launcherConfig = SAMP.LauncherConfigIO;
                }
                return launcherConfig.Language;
            }
            set
            {
                launcherConfig.Language = value;
                SAMP.LauncherConfigIO = launcherConfig;
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
            if (launcherConfig == null)
            {
                launcherConfig = SAMP.LauncherConfigIO;
            }
            SAMP.LauncherConfigIO = launcherConfig;
        }
    }
}
