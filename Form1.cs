using System.Windows.Forms;

namespace NotePadProject
{
    public partial class NotePad : Form
    {
        string filePath = "";
        public NotePad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Clear();
        }

        private void myNotePadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notepad is a text editing application in Windows, allowing to create, view, and edit plain text files .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Rich Text File(*.rtf)|*.rtf";
            openFileDialog.ShowDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".txt")
                {
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                {
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = Path.GetFileName(openFileDialog.FileName) + "MyNotePad";
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Redo();
        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }

        private void printPreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            printDialog1.Document = printDocument1;
            printDocument1.Print();
            MessageBox.Show("Print Your Page Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(MainRichTextBox.Text);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLineAsync(MainRichTextBox.Text);
                }

            }
        }



        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectedText = "";
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (MainRichTextBox.Text.Length > 0)
            {
                cToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
            }
            else
            {
                cToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
            }
        }

        private void wardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wardToolStripMenuItem.Checked = true)
            {
                wardToolStripMenuItem.Checked = false;
                MainRichTextBox.WordWrap = true;
            }
            else
            {
                wardToolStripMenuItem.Checked = false;
                MainRichTextBox.WordWrap = false;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            MainRichTextBox.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        private void highlightTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionBackColor = Color.Yellow;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentFontSize = MainRichTextBox.SelectionFont.Size;
            float newFontSize = currentFontSize + 2;
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.SelectionFont.FontFamily, newFontSize, MainRichTextBox.SelectionFont.Style);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentFontSize = MainRichTextBox.SelectionFont.Size;
            float newFontSize = currentFontSize - 2;
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.SelectionFont.FontFamily, newFontSize, MainRichTextBox.SelectionFont.Style);
        }



        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionBackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionBackColor = Color.Blue;
        }

        private void highlightTextColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.ForeColor = Color.Gray;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if there is any content to save
            if (string.IsNullOrEmpty(MainRichTextBox.Text))
            {
                MessageBox.Show("No content to save.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLine(MainRichTextBox.Text); // Use WriteLine instead of WriteLineAsync
                        }
                        MessageBox.Show("File saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the file: {ex.Message}");
                    }
                }
            }
        }
    }
    }
   