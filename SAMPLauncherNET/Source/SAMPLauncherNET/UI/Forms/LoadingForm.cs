using System.Drawing;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// SA:MP launcher .NET namespace
/// </summary>
namespace SAMPLauncherNET
{
    /// <summary>
    /// Loading form class
    /// </summary>
    public partial class LoadingForm : Form
    {
        /// <summary>
        /// Loading text
        /// </summary>
        private string loadingText;

        /// <summary>
        /// Loading text font
        /// </summary>
        private Font loadingTextFont = new Font("Roboto", 20.25f);

        /// <summary>
        /// Loading text brush
        /// </summary>
        private Brush loadingTextBrush = Brushes.White;

        /// <summary>
        /// Loading text point
        /// </summary>
        private Point loadingTextPoint;

        /// <summary>
        /// Loading text format
        /// </summary>
        StringFormat loadingTextFormat;

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoadingForm()
        {
            InitializeComponent();
            //Translator.LoadTranslation(this);
            loadingText = Utils.Translator.GetTranslation("LOADING");
            //Size sz = TextRenderer.MeasureText(loadingText, loadingTextFont);
            loadingTextPoint = new Point(Size.Width / 2, Size.Height / 2);
            loadingTextFormat = new StringFormat();
            loadingTextFormat.LineAlignment = StringAlignment.Center;
            loadingTextFormat.Alignment = StringAlignment.Center;
        }

        /// <summary>
        /// Loading form paint event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void LoadingForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(loadingText, loadingTextFont, loadingTextBrush, loadingTextPoint, loadingTextFormat);
        }
    }
}
