namespace NotePadProject
{
    partial class NotePad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            printPreToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            eaditToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            cToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            sellectAllToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            wardToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            highlightTextToolStripMenuItem = new ToolStripMenuItem();
            highlightTextColourToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem1 = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            myNotePadToolStripMenuItem = new ToolStripMenuItem();
            MainRichTextBox = new RichTextBox();
            saveFileDialog1 = new SaveFileDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDialog1 = new PrintDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Yellow;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, eaditToolStripMenuItem, formatToolStripMenuItem, aboutToolStripMenuItem1, redToolStripMenuItem1, blueToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem3, printPreToolStripMenuItem, printPreviewToolStripMenuItem, toolStripMenuItem4, exitToolStripMenuItem1, toolStripMenuItem5 });
            fileToolStripMenuItem.Image = (Image)resources.GetObject("fileToolStripMenuItem.Image");
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(66, 26);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(233, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(233, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(233, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Image = (Image)resources.GetObject("saveAsToolStripMenuItem.Image");
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(233, 26);
            saveAsToolStripMenuItem.Text = "S&ave As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(230, 6);
            // 
            // printPreToolStripMenuItem
            // 
            printPreToolStripMenuItem.Image = (Image)resources.GetObject("printPreToolStripMenuItem.Image");
            printPreToolStripMenuItem.Name = "printPreToolStripMenuItem";
            printPreToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printPreToolStripMenuItem.Size = new Size(233, 26);
            printPreToolStripMenuItem.Text = "&Print";
            printPreToolStripMenuItem.Click += printPreToolStripMenuItem_Click;
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(233, 26);
            printPreviewToolStripMenuItem.Text = "P&rint Preview";
            printPreviewToolStripMenuItem.Click += printPreviewToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(230, 6);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Image = (Image)resources.GetObject("exitToolStripMenuItem1.Image");
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(233, 26);
            exitToolStripMenuItem1.Text = "&Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(230, 6);
            // 
            // eaditToolStripMenuItem
            // 
            eaditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { redoToolStripMenuItem, undoToolStripMenuItem, toolStripMenuItem2, cToolStripMenuItem, copyToolStripMenuItem, toolStripMenuItem1, pasteToolStripMenuItem, deleteToolStripMenuItem, sellectAllToolStripMenuItem });
            eaditToolStripMenuItem.Image = (Image)resources.GetObject("eaditToolStripMenuItem.Image");
            eaditToolStripMenuItem.Name = "eaditToolStripMenuItem";
            eaditToolStripMenuItem.Size = new Size(69, 26);
            eaditToolStripMenuItem.Text = "&Edit";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = (Image)resources.GetObject("redoToolStripMenuItem.Image");
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            redoToolStripMenuItem.Size = new Size(210, 26);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = (Image)resources.GetObject("undoToolStripMenuItem.Image");
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(210, 26);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(207, 6);
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Enabled = false;
            cToolStripMenuItem.Image = (Image)resources.GetObject("cToolStripMenuItem.Image");
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cToolStripMenuItem.Size = new Size(210, 26);
            cToolStripMenuItem.Text = "&Cut";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(210, 26);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(207, 6);
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(210, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = (Image)resources.GetObject("deleteToolStripMenuItem.Image");
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(210, 26);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // sellectAllToolStripMenuItem
            // 
            sellectAllToolStripMenuItem.Image = (Image)resources.GetObject("sellectAllToolStripMenuItem.Image");
            sellectAllToolStripMenuItem.Name = "sellectAllToolStripMenuItem";
            sellectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            sellectAllToolStripMenuItem.Size = new Size(210, 26);
            sellectAllToolStripMenuItem.Text = "Se&llect All";
            sellectAllToolStripMenuItem.Click += sellectAllToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wardToolStripMenuItem, fontToolStripMenuItem, highlightTextToolStripMenuItem, highlightTextColourToolStripMenuItem });
            formatToolStripMenuItem.Image = (Image)resources.GetObject("formatToolStripMenuItem.Image");
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(90, 26);
            formatToolStripMenuItem.Text = "F&ormat";
            // 
            // wardToolStripMenuItem
            // 
            wardToolStripMenuItem.Name = "wardToolStripMenuItem";
            wardToolStripMenuItem.Size = new Size(233, 26);
            wardToolStripMenuItem.Text = "&Ward wrap";
            wardToolStripMenuItem.Click += wardToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Image = (Image)resources.GetObject("fontToolStripMenuItem.Image");
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(233, 26);
            fontToolStripMenuItem.Text = "&Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // highlightTextToolStripMenuItem
            // 
            highlightTextToolStripMenuItem.Image = (Image)resources.GetObject("highlightTextToolStripMenuItem.Image");
            highlightTextToolStripMenuItem.Name = "highlightTextToolStripMenuItem";
            highlightTextToolStripMenuItem.Size = new Size(233, 26);
            highlightTextToolStripMenuItem.Text = "&Highlight Text";
            highlightTextToolStripMenuItem.Click += highlightTextToolStripMenuItem_Click;
            // 
            // highlightTextColourToolStripMenuItem
            // 
            highlightTextColourToolStripMenuItem.Image = (Image)resources.GetObject("highlightTextColourToolStripMenuItem.Image");
            highlightTextColourToolStripMenuItem.Name = "highlightTextColourToolStripMenuItem";
            highlightTextColourToolStripMenuItem.Size = new Size(233, 26);
            highlightTextColourToolStripMenuItem.Text = "Highlight Text Colour";
            highlightTextColourToolStripMenuItem.Click += highlightTextColourToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem });
            aboutToolStripMenuItem1.Image = (Image)resources.GetObject("aboutToolStripMenuItem1.Image");
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(75, 26);
            aboutToolStripMenuItem1.Text = "&View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem });
            zoomToolStripMenuItem.Image = (Image)resources.GetObject("zoomToolStripMenuItem.Image");
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(132, 26);
            zoomToolStripMenuItem.Text = "Zoom";
            zoomToolStripMenuItem.Click += zoomToolStripMenuItem_Click;
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Image = (Image)resources.GetObject("zoomInToolStripMenuItem.Image");
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.Size = new Size(160, 26);
            zoomInToolStripMenuItem.Text = "Zoom In";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Image = (Image)resources.GetObject("zoomOutToolStripMenuItem.Image");
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.Size = new Size(160, 26);
            zoomOutToolStripMenuItem.Text = "Zoom Out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // redToolStripMenuItem1
            // 
            redToolStripMenuItem1.BackColor = Color.Red;
            redToolStripMenuItem1.Image = (Image)resources.GetObject("redToolStripMenuItem1.Image");
            redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            redToolStripMenuItem1.Size = new Size(69, 26);
            redToolStripMenuItem1.Text = "Red";
            redToolStripMenuItem1.Click += redToolStripMenuItem1_Click;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.BackColor = SystemColors.MenuHighlight;
            blueToolStripMenuItem.Image = (Image)resources.GetObject("blueToolStripMenuItem.Image");
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(72, 26);
            blueToolStripMenuItem.Text = "Blue";
            blueToolStripMenuItem.Click += blueToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { myNotePadToolStripMenuItem });
            aboutToolStripMenuItem.Image = (Image)resources.GetObject("aboutToolStripMenuItem.Image");
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(84, 26);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // myNotePadToolStripMenuItem
            // 
            myNotePadToolStripMenuItem.Image = (Image)resources.GetObject("myNotePadToolStripMenuItem.Image");
            myNotePadToolStripMenuItem.Name = "myNotePadToolStripMenuItem";
            myNotePadToolStripMenuItem.Size = new Size(226, 26);
            myNotePadToolStripMenuItem.Text = "Info About Notepad";
            myNotePadToolStripMenuItem.Click += myNotePadToolStripMenuItem_Click;
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.BackColor = SystemColors.HighlightText;
            MainRichTextBox.Dock = DockStyle.Fill;
            MainRichTextBox.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainRichTextBox.Location = new Point(0, 30);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(982, 723);
            MainRichTextBox.TabIndex = 1;
            MainRichTextBox.Text = "";
            MainRichTextBox.UseWaitCursor = true;
            MainRichTextBox.TextChanged += MainRichTextBox_TextChanged;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // NotePad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(982, 753);
            Controls.Add(MainRichTextBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NotePad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem printPreToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem eaditToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem sellectAllToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem myNotePadToolStripMenuItem;
        private RichTextBox MainRichTextBox;
        private SaveFileDialog saveFileDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem wardToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem highlightTextToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripSeparator toolStripMenuItem5;
        private FontDialog fontDialog1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem redToolStripMenuItem1;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem highlightTextColourToolStripMenuItem;
    }
}
