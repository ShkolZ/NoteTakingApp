namespace NoteTaking
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            rightClickContextMenuStrip = new ContextMenuStrip(components);
            newNoteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            tsmSave = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AllNotes = new DataGridView();
            NoteText = new TextBox();
            btnSaveNote = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            rightClickContextMenuStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllNotes).BeginInit();
            SuspendLayout();
            // 
            // rightClickContextMenuStrip
            // 
            rightClickContextMenuStrip.Items.AddRange(new ToolStripItem[] { newNoteToolStripMenuItem });
            rightClickContextMenuStrip.Name = "rightClickContextMenuStrip";
            rightClickContextMenuStrip.Size = new Size(128, 26);
            rightClickContextMenuStrip.ItemClicked += rightClickContextMenuStrip_ItemClicked;
            // 
            // newNoteToolStripMenuItem
            // 
            newNoteToolStripMenuItem.Image = Properties.Resources.Без_имени;
            newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            newNoteToolStripMenuItem.Size = new Size(127, 22);
            newNoteToolStripMenuItem.Text = "New Note";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(957, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmSave, toolStripMenuItem2 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // tsmSave
            // 
            tsmSave.Name = "tsmSave";
            tsmSave.Size = new Size(180, 22);
            tsmSave.Text = "Save";
            tsmSave.Click += tsmSave_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Open";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // AllNotes
            // 
            AllNotes.AllowUserToAddRows = false;
            AllNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllNotes.BackgroundColor = SystemColors.Control;
            AllNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllNotes.Location = new Point(12, 38);
            AllNotes.MultiSelect = false;
            AllNotes.Name = "AllNotes";
            AllNotes.Size = new Size(391, 487);
            AllNotes.TabIndex = 3;
            AllNotes.CellMouseClick += AllNotes_CellMouseClick;
            AllNotes.MouseDown += AllNotes_MouseDown;
            // 
            // NoteText
            // 
            NoteText.BorderStyle = BorderStyle.FixedSingle;
            NoteText.Location = new Point(409, 38);
            NoteText.Multiline = true;
            NoteText.Name = "NoteText";
            NoteText.Size = new Size(536, 425);
            NoteText.TabIndex = 4;
            // 
            // btnSaveNote
            // 
            btnSaveNote.Location = new Point(452, 469);
            btnSaveNote.Name = "btnSaveNote";
            btnSaveNote.Size = new Size(463, 45);
            btnSaveNote.TabIndex = 5;
            btnSaveNote.Text = "Save Note";
            btnSaveNote.UseVisualStyleBackColor = true;
            btnSaveNote.Click += btnSaveNote_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 537);
            Controls.Add(btnSaveNote);
            Controls.Add(NoteText);
            Controls.Add(AllNotes);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "NoteTakingApp";
            Load += Form1_Load;
            rightClickContextMenuStrip.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip rightClickContextMenuStrip;
        private ToolStripMenuItem newNoteToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private DataGridView AllNotes;
        private TextBox NoteText;
        private Button btnSaveNote;
        private ToolStripMenuItem tsmSave;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem helpToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
