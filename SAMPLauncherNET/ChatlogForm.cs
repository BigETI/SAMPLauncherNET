using MetroFramework.Forms;
using MetroTranslatorStyler;

namespace SAMPLauncherNET
{
    public partial class ChatlogForm : MetroForm
    {
        public ChatlogForm()
        {
            InitializeComponent();
            TranslatorStyler.LoadTranslationStyle(this, TranslatorStyler.TranslatorStylerInterface);
            chatlogTextBox.Text = Utils.Chatlog;
        }
    }
}
