using MaterialSkin.Controls;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Developer tools config form class
    /// </summary>
    public partial class DeveloperToolsConfigForm : MaterialForm
    {
        /// <summary>
        /// Developer tools config data contract
        /// </summary>
        public DeveloperToolsConfigDataContract DeveloperToolsConfigDataContract
        {
            get
            {
                DeveloperToolsConfigDataContract ret = new DeveloperToolsConfigDataContract(
                    Utils.GetInt(acknowledgesLimitSingleLineTextField.Text),
                    announceCheckBox.Checked,
                    bindSingleLineTextField.Text,
                    chatLoggingCheckBox.Checked,
                    connectionCookiesCheckBox.Checked,
                    Utils.GetInt(connectionSeedTimeSingleLineTextField.Text),
                    cookieLoggingCheckBox.Checked,
                    databaseLoggingCheckBox.Checked,
                    databaseLoggingCheckBox.Checked,
                    hostnameSingleLineTextField.Text,
                    Utils.GetInt(inCarRateSingleLineTextField.Text),
                    Utils.GetInt(lagCompensationModeSingleLineTextField.Text),
                    languageSingleLineTextField.Text,
                    lanModeCheckBox.Checked,
                    logQueriesCheckBox.Checked,
                    logTimeFormatSingleLineTextField.Text,
                    mapNameSingleLineTextField.Text,
                    Utils.GetInt(maximalPlayersSingleLineTextField.Text),
                    Utils.GetInt(maximalNPCsSingleLineTextField.Text),
                    Utils.GetInt(messageHoleLimitSingleLineTextField.Text),
                    Utils.GetInt(messagesLimitSingleLineTextField.Text),
                    Utils.GetInt(minimumConnectionTimeSingleLineTextField.Text),
                    noSignSingleLineTextField.Text,
                    Utils.GetInt(onFootRateSingleLineTextField.Text),
                    passwordSingleLineTextField.Text,
                    Utils.GetInt(playerTimeOutSingleLineTextField.Text),
                    Utils.GetInt(portSingleLineTextField.Text),
                    queryCheckBox.Checked,
                    rconCheckBox.Checked,
                    rconPasswordSingleLineTextField.Text,
                    Utils.GetInt(sleepSingleLineTextField.Text),
                    Utils.GetFloat(streamDistanceSingleLineTextField.Text),
                    Utils.GetInt(streamRateSingleLineTextField.Text),
                    timestampCheckBox.Checked,
                    Utils.GetInt(weaponRateSingleLineTextField.Text),
                    websiteURLSingleLineTextField.Text);
                return ret;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DeveloperToolsConfigForm(DeveloperToolsConfigDataContract developerToolsConfigDataContract)
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
            acknowledgesLimitSingleLineTextField.Text = developerToolsConfigDataContract.AcknowledgesLimit.ToString();
            announceCheckBox.Checked = developerToolsConfigDataContract.Announce;
            bindSingleLineTextField.Text = developerToolsConfigDataContract.Bind;
            chatLoggingCheckBox.Checked = developerToolsConfigDataContract.ChatLogging;
            connectionCookiesCheckBox.Checked = developerToolsConfigDataContract.ConnectionCookies;
            connectionSeedTimeSingleLineTextField.Text = developerToolsConfigDataContract.ConnectionSeedTime.ToString();
            cookieLoggingCheckBox.Checked = developerToolsConfigDataContract.CookieLogging;
            databaseLoggingCheckBox.Checked = developerToolsConfigDataContract.DatabaseLogQueries;
            databaseLoggingCheckBox.Checked = developerToolsConfigDataContract.DatabaseLogging;
            hostnameSingleLineTextField.Text = developerToolsConfigDataContract.Hostname;
            inCarRateSingleLineTextField.Text = developerToolsConfigDataContract.InCarRate.ToString();
            lagCompensationModeSingleLineTextField.Text = developerToolsConfigDataContract.LagCompensationMode.ToString();
            languageSingleLineTextField.Text = developerToolsConfigDataContract.Language;
            lanModeCheckBox.Checked = developerToolsConfigDataContract.LANMode;
            logQueriesCheckBox.Checked = developerToolsConfigDataContract.LogQueries;
            logTimeFormatSingleLineTextField.Text = developerToolsConfigDataContract.LogTimeFormat;
            mapNameSingleLineTextField.Text = developerToolsConfigDataContract.MapName;
            maximalPlayersSingleLineTextField.Text = developerToolsConfigDataContract.MaximumPlayers.ToString();
            maximalNPCsSingleLineTextField.Text = developerToolsConfigDataContract.MaximumNPCs.ToString();
            messageHoleLimitSingleLineTextField.Text = developerToolsConfigDataContract.MessageHoleLimit.ToString();
            messagesLimitSingleLineTextField.Text = developerToolsConfigDataContract.MessagesLimit.ToString();
            minimumConnectionTimeSingleLineTextField.Text = developerToolsConfigDataContract.MinimumConnectionTime.ToString();
            noSignSingleLineTextField.Text = developerToolsConfigDataContract.NoSign;
            onFootRateSingleLineTextField.Text = developerToolsConfigDataContract.OnFootRate.ToString();
            passwordSingleLineTextField.Text = developerToolsConfigDataContract.Password;
            playerTimeOutSingleLineTextField.Text = developerToolsConfigDataContract.PlayerTimeOut.ToString();
            portSingleLineTextField.Text = developerToolsConfigDataContract.Port.ToString();
            queryCheckBox.Checked = developerToolsConfigDataContract.Query;
            rconCheckBox.Checked = developerToolsConfigDataContract.RCON;
            rconPasswordSingleLineTextField.Text = developerToolsConfigDataContract.RCONPassword;
            sleepSingleLineTextField.Text = developerToolsConfigDataContract.Sleep.ToString();
            streamDistanceSingleLineTextField.Text = developerToolsConfigDataContract.StreamDistance.ToString();
            streamRateSingleLineTextField.Text = developerToolsConfigDataContract.StreamRate.ToString();
            timestampCheckBox.Checked = developerToolsConfigDataContract.Timestamp;
            weaponRateSingleLineTextField.Text = developerToolsConfigDataContract.WeaponRate.ToString();
            websiteURLSingleLineTextField.Text = developerToolsConfigDataContract.WebsiteURL;
        }

        /// <summary>
        /// OK button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void okButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Cancel button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
