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
                DeveloperToolsConfigDataContract ret = new DeveloperToolsConfigDataContract();
                ret.acknowledgesLimit = Utils.GetInt(acknowledgesLimitSingleLineTextField.Text);
                ret.announce = announceCheckBox.Checked;
                ret.bind = bindSingleLineTextField.Text;
                ret.chatLogging = chatLoggingCheckBox.Checked;
                ret.connectionCookies = connectionCookiesCheckBox.Checked;
                ret.connectionSeedTime = Utils.GetInt(connectionSeedTimeSingleLineTextField.Text);
                ret.cookieLogging = cookieLoggingCheckBox.Checked;
                ret.databaseLogQueries = databaseLoggingCheckBox.Checked;
                ret.databaseLogging = databaseLoggingCheckBox.Checked;
                ret.hostname = hostnameSingleLineTextField.Text;
                ret.inCarRate = Utils.GetInt(inCarRateSingleLineTextField.Text);
                ret.lagCompensationMode = Utils.GetInt(lagCompensationModeSingleLineTextField.Text);
                ret.language = languageSingleLineTextField.Text;
                ret.lanMode = lanModeCheckBox.Checked;
                ret.logQueries = logQueriesCheckBox.Checked;
                ret.logTimeFormat = logTimeFormatSingleLineTextField.Text;
                ret.mapName = mapNameSingleLineTextField.Text;
                ret.maximumPlayers = Utils.GetInt(maximalPlayersSingleLineTextField.Text);
                ret.maximumNPCs = Utils.GetInt(maximalNPCsSingleLineTextField.Text);
                ret.messageHoleLimit = Utils.GetInt(messageHoleLimitSingleLineTextField.Text);
                ret.messagesLimit = Utils.GetInt(messagesLimitSingleLineTextField.Text);
                ret.minimumConnectionTime = Utils.GetInt(minimumConnectionTimeSingleLineTextField.Text);
                ret.noSign = noSignSingleLineTextField.Text;
                ret.onFootRate = Utils.GetInt(onFootRateSingleLineTextField.Text);
                ret.password = passwordSingleLineTextField.Text;
                ret.playerTimeOut = Utils.GetInt(playerTimeOutSingleLineTextField.Text);
                ret.port = Utils.GetInt(portSingleLineTextField.Text);
                ret.query = queryCheckBox.Checked;
                ret.rcon = rconCheckBox.Checked;
                ret.rconPassword = rconPasswordSingleLineTextField.Text;
                ret.sleep = Utils.GetInt(sleepSingleLineTextField.Text);
                ret.streamDistance = Utils.GetFloat(streamDistanceSingleLineTextField.Text);
                ret.streamRate = Utils.GetInt(streamRateSingleLineTextField.Text);
                ret.timestamp = timestampCheckBox.Checked;
                ret.weaponRate = Utils.GetInt(weaponRateSingleLineTextField.Text);
                ret.websiteURL = websiteURLSingleLineTextField.Text;
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
            acknowledgesLimitSingleLineTextField.Text = developerToolsConfigDataContract.acknowledgesLimit.ToString();
            announceCheckBox.Checked = developerToolsConfigDataContract.announce;
            bindSingleLineTextField.Text = developerToolsConfigDataContract.bind;
            chatLoggingCheckBox.Checked = developerToolsConfigDataContract.chatLogging;
            connectionCookiesCheckBox.Checked = developerToolsConfigDataContract.connectionCookies;
            connectionSeedTimeSingleLineTextField.Text = developerToolsConfigDataContract.connectionSeedTime.ToString();
            cookieLoggingCheckBox.Checked = developerToolsConfigDataContract.cookieLogging;
            databaseLoggingCheckBox.Checked = developerToolsConfigDataContract.databaseLogQueries;
            databaseLoggingCheckBox.Checked = developerToolsConfigDataContract.databaseLogging;
            hostnameSingleLineTextField.Text = developerToolsConfigDataContract.hostname;
            inCarRateSingleLineTextField.Text = developerToolsConfigDataContract.inCarRate.ToString();
            lagCompensationModeSingleLineTextField.Text = developerToolsConfigDataContract.lagCompensationMode.ToString();
            languageSingleLineTextField.Text = developerToolsConfigDataContract.language;
            lanModeCheckBox.Checked = developerToolsConfigDataContract.lanMode;
            logQueriesCheckBox.Checked = developerToolsConfigDataContract.logQueries;
            logTimeFormatSingleLineTextField.Text = developerToolsConfigDataContract.logTimeFormat;
            mapNameSingleLineTextField.Text = developerToolsConfigDataContract.mapName;
            maximalPlayersSingleLineTextField.Text = developerToolsConfigDataContract.maximumPlayers.ToString();
            maximalNPCsSingleLineTextField.Text = developerToolsConfigDataContract.maximumNPCs.ToString();
            messageHoleLimitSingleLineTextField.Text = developerToolsConfigDataContract.messageHoleLimit.ToString();
            messagesLimitSingleLineTextField.Text = developerToolsConfigDataContract.messagesLimit.ToString();
            minimumConnectionTimeSingleLineTextField.Text = developerToolsConfigDataContract.minimumConnectionTime.ToString();
            noSignSingleLineTextField.Text = developerToolsConfigDataContract.noSign;
            onFootRateSingleLineTextField.Text = developerToolsConfigDataContract.onFootRate.ToString();
            passwordSingleLineTextField.Text = developerToolsConfigDataContract.password;
            playerTimeOutSingleLineTextField.Text = developerToolsConfigDataContract.playerTimeOut.ToString();
            portSingleLineTextField.Text = developerToolsConfigDataContract.port.ToString();
            queryCheckBox.Checked = developerToolsConfigDataContract.query;
            rconCheckBox.Checked = developerToolsConfigDataContract.rcon;
            rconPasswordSingleLineTextField.Text = developerToolsConfigDataContract.rconPassword;
            sleepSingleLineTextField.Text = developerToolsConfigDataContract.sleep.ToString();
            streamDistanceSingleLineTextField.Text = developerToolsConfigDataContract.streamDistance.ToString();
            streamRateSingleLineTextField.Text = developerToolsConfigDataContract.streamRate.ToString();
            timestampCheckBox.Checked = developerToolsConfigDataContract.timestamp;
            weaponRateSingleLineTextField.Text = developerToolsConfigDataContract.weaponRate.ToString();
            websiteURLSingleLineTextField.Text = developerToolsConfigDataContract.websiteURL;
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
