/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Filter option
    /// </summary>
    public class FilterOption
    {
        /// <summary>
        /// Field
        /// </summary>
        private string field;

        /// <summary>
        /// Display name
        /// </summary>
        private string displayName;

        /// <summary>
        /// Field
        /// </summary>
        public string Field
        {
            get => field;
            set
            {
                if (value != null)
                {
                    field = value;
                }
            }
        }

        /// <summary>
        /// Display name
        /// </summary>
        public string DisplayName
        {
            get => displayName;
            set
            {
                if (value != null)
                {
                    displayName = value;
                }
            }
        }

        /// <summary>
        /// Constrcutor
        /// </summary>
        public FilterOption()
        {
            field = "";
            displayName = "";
        }

        /// <summary>
        /// Constrcutor
        /// </summary>
        /// <param name="field">Field</param>
        /// <param name="displayName">Display name</param>
        public FilterOption(string field, string displayName)
        {
            this.field = field;
            this.displayName = displayName;
        }
    }
}
