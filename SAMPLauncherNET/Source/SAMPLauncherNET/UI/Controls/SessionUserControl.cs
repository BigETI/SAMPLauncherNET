using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WinFormsTranslator;
using System.Threading;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;

/// <summary>
/// SA:MP launcher .NET UI namespace
/// </summary>
namespace SAMPLauncherNET.UI
{
    /// <summary>
    /// Session user control class
    /// </summary>
    public partial class SessionUserControl : UserControl
    {
        /// <summary>
        /// Session
        /// </summary>
        private Session session;

        /// <summary>
        /// Gallery thread
        /// </summary>
        private Thread galleryThread;

        /// <summary>
        /// Gallery
        /// </summary>
        private Dictionary<string, Image> loadedGallery = new Dictionary<string, Image>();

        /// <summary>
        /// Last gallery image index
        /// </summary>
        private uint lastGalleryImageIndex = 0U;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">Session</param>
        public SessionUserControl(Session session)
        {
            this.session = session;
            InitializeComponent();
            Translator.LoadTranslation(this);
            if (session != null)
            {
                lastChatlogRichTextBox.Rtf = ChatlogFormatter.Format(session.Chatlog, EChatlogFormatType.RTF, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked);
                savedPositionsTextBox.Text = session.SavedPositions;
                ReloadGallery();
            }
            Disposed += (sender, e) =>
            {
                if (galleryThread != null)
                {
                    galleryThread.Abort();
                    galleryThread = null;
                }
            };
        }

        /// <summary>
        /// Reload gallery
        /// </summary>
        private void ReloadGallery()
        {
            if (galleryThread != null)
            {
                galleryThread.Abort();
            }
            galleryListView.Clear();
            galleryImageList.Images.Clear();
            loadedGallery.Clear();
            lastGalleryImageIndex = 0U;
            galleryThread = new Thread(() =>
            {
                foreach (KeyValuePair<string, Image> thumbnail in session.Thumbnails)
                {
                    lock (loadedGallery)
                    {
                        loadedGallery.Add(thumbnail.Key, thumbnail.Value);
                    }
                }
            });
            galleryThread.Start();
        }

        /// <summary>
        /// View selected image
        /// </summary>
        private void ViewSelectedImage()
        {
            Dictionary<string, Process> processes = new Dictionary<string, Process>();
            try
            {
                string temp_path = Path.Combine(Path.GetTempPath(), "SAMPLauncherNET");
                if (!(Directory.Exists(temp_path)))
                {
                    Directory.CreateDirectory(temp_path);
                }
                using (ZipArchive archive = ZipFile.Open(session.Path, ZipArchiveMode.Read))
                {
                    uint id = 0U;
                    foreach (ListViewItem item in galleryListView.SelectedItems)
                    {
                        try
                        {
                            string path = (string)(item.Tag);
                            ZipArchiveEntry entry = archive.GetEntry(path);
                            if (entry != null)
                            {
                                string destination_path;
                                do
                                {
                                    destination_path = Path.Combine(temp_path, "session_" + id + ".png");
                                    ++id;
                                }
                                while (File.Exists(destination_path));
                                using (FileStream file_stream = File.Open(destination_path, FileMode.Create))
                                {
                                    using (Stream stream = entry.Open())
                                    {
                                        stream.CopyTo(file_stream);
                                    }
                                }
                                Process process = Process.Start(destination_path);
                                if (process != null)
                                {
                                    processes.Add(destination_path, process);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e);
                            MessageBox.Show(e.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
            }
            foreach (KeyValuePair<string, Process> process in processes)
            {
                try
                {
                    process.Value.WaitForExit();
                    if (File.Exists(process.Key))
                    {
                        File.Delete(process.Key);
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Delete selected image
        /// </summary>
        private void DeleteSelectedImage()
        {
            List<string> paths = new List<string>();
            foreach (ListViewItem item in galleryListView.SelectedItems)
            {
                string path = (string)(item.Tag);
                if (File.Exists(path))
                {
                    paths.Add(path);
                }
            }
            if (paths.Count > 0)
            {
                if (MessageBox.Show(Translator.GetTranslation("DELETE_SELECTED_IMAGES"), Translator.GetTranslation("DELETE_SELECTED_IMAGES_TITLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (ZipArchive archive = ZipFile.Open(session.Path, ZipArchiveMode.Update))
                    {
                        foreach (string path in paths)
                        {
                            try
                            {
                                ZipArchiveEntry entry = archive.GetEntry(path);
                                if (entry != null)
                                {
                                    entry.Delete();
                                }
                            }
                            catch (Exception e)
                            {
                                Console.Error.WriteLine(e);
                            }
                        }
                    }
                    ReloadGallery();
                }
            }
        }

        /// <summary>
        /// Update chatlog format
        /// </summary>
        private void UpdateChatlogFormat()
        {
            lastChatlogRichTextBox.Rtf = ChatlogFormatter.Format(session.Chatlog, EChatlogFormatType.RTF, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked);
        }

        /// <summary>
        /// Tick timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void tickTimer_Tick(object sender, EventArgs e)
        {
            lock (loadedGallery)
            {
                foreach (KeyValuePair<string, Image> thumbnail in loadedGallery)
                {
                    galleryImageList.Images.Add(thumbnail.Value);
                    ListViewItem lvi = galleryListView.Items.Add(Path.GetFileName(thumbnail.Key), (int)lastGalleryImageIndex);
                    lvi.Tag = thumbnail.Key;
                    ++lastGalleryImageIndex;
                }
                loadedGallery.Clear();
            }
        }

        /// <summary>
        /// Gallery list view key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void galleryListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ViewSelectedImage();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedImage();
            }
        }

        /// <summary>
        /// Gallery list view double click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void galleryListView_DoubleClick(object sender, EventArgs e)
        {
            ViewSelectedImage();
        }

        /// <summary>
        /// Generic picture box mouse enter event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void genericPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Generic picture box mouse leave event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void genericPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Gallery view picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void galleryViewPictureBox_Click(object sender, EventArgs e)
        {
            ViewSelectedImage();
        }

        /// <summary>
        /// Gallery save picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void gallerySavePictureBox_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Portable Network Graphics (*.png)|*.png|All files (*.*)|*.*";
            try
            {
                using (ZipArchive archive = ZipFile.Open(session.Path, ZipArchiveMode.Read))
                {
                    foreach (ListViewItem item in galleryListView.SelectedItems)
                    {
                        try
                        {
                            string path = (string)(item.Tag);
                            ZipArchiveEntry entry = archive.GetEntry(path);
                            if (entry != null)
                            {
                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    try
                                    {
                                        string destination_path = saveFileDialog.FileName;
                                        if (File.Exists(destination_path))
                                        {
                                            File.Delete(destination_path);
                                        }
                                        using (FileStream file_stream = File.Open(destination_path, FileMode.Create))
                                        {
                                            using (Stream stream = entry.Open())
                                            {
                                                stream.CopyTo(file_stream);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.Error.WriteLine(ex);
                                        MessageBox.Show(ex.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Error.WriteLine(ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
        }

        /// <summary>
        /// Gallery delete picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void galleryDeletePictureBox_Click(object sender, EventArgs e)
        {
            DeleteSelectedImage();
        }

        /// <summary>
        /// Last chatlog copy text as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogCopyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ChatlogFormatter.Format(session.Chatlog, EChatlogFormatType.Plain, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
        }

        /// <summary>
        /// Last chatlog copy original text as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogCopyOriginalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(session.Chatlog);
        }

        /// <summary>
        /// Last chatlog copy HTML as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogCopyHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ChatlogFormatter.Format(session.Chatlog, EChatlogFormatType.HTMLSnippet, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
        }

        /// <summary>
        /// Last chatlog copy RTF as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogCopyRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ChatlogFormatter.Format(session.Chatlog, EChatlogFormatType.RTF, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
        }

        /// <summary>
        /// Last chatlog save text as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogSaveTextAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Utils.SaveTextFile(saveFileDialog.FileName, ChatlogFormatter.Format(session.Chatlog, EChatlogFormatType.Plain, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
            }
        }

        /// <summary>
        /// Last chatlog save original text as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogSaveOriginalTextAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Utils.SaveTextFile(saveFileDialog.FileName, session.Chatlog);
            }
        }

        /// <summary>
        /// Last chatlog save HTML as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogSaveHTMLAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Hypertext Markup Language files (*.html)|*.html|Hypertext Markup Language files (*.htm)|*.htm|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Utils.SaveTextFile(saveFileDialog.FileName, ChatlogFormatter.Format(session.Chatlog, EChatlogFormatType.HTML, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
            }
        }

        /// <summary>
        /// Last chatlog save RTF as tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void lastChatlogSaveRTFAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Rich Text Format files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Utils.SaveTextFile(saveFileDialog.FileName, ChatlogFormatter.Format(session.Chatlog, EChatlogFormatType.RTF, chatlogColorCodesCheckBox.Checked, chatlogColoredCheckBox.Checked, chatlogTimestampCheckBox.Checked));
            }
        }

        /// <summary>
        /// Chatlog generic check box checked changed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void chatlogGenericCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateChatlogFormat();
        }
    }
}
