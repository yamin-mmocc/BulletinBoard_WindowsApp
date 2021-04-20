
namespace WindowApplicationTest
{
    partial class NoteList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtNoteList = new System.Windows.Forms.DataGridView();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mMOCCBulletinBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.noteno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notetitle = new System.Windows.Forms.DataGridViewLinkColumn();
            this.userno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtNoteList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtNoteList
            // 
            this.dtNoteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNoteList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteno,
            this.NoteContent,
            this.notetitle,
            this.userno,
            this.notedate});
            this.dtNoteList.Location = new System.Drawing.Point(38, 92);
            this.dtNoteList.Name = "dtNoteList";
            this.dtNoteList.Size = new System.Drawing.Size(440, 230);
            this.dtNoteList.TabIndex = 0;
            this.dtNoteList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNoteList_CellContentClick);
            this.dtNoteList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtNoteList_CellMouseClick);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNote.Location = new System.Drawing.Point(38, 343);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(124, 38);
            this.btnAddNote.TabIndex = 1;
            this.btnAddNote.Text = "Add Content";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMOCCBulletinBoardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mMOCCBulletinBoardToolStripMenuItem
            // 
            this.mMOCCBulletinBoardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noteListToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.mMOCCBulletinBoardToolStripMenuItem.Name = "mMOCCBulletinBoardToolStripMenuItem";
            this.mMOCCBulletinBoardToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mMOCCBulletinBoardToolStripMenuItem.Text = "MMOCC BulletinBoard";
            // 
            // noteListToolStripMenuItem
            // 
            this.noteListToolStripMenuItem.Name = "noteListToolStripMenuItem";
            this.noteListToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.noteListToolStripMenuItem.Text = "Note List";
            this.noteListToolStripMenuItem.Click += new System.EventHandler(this.noteListToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(168, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // noteno
            // 
            this.noteno.DataPropertyName = "noteno";
            this.noteno.HeaderText = "Number";
            this.noteno.Name = "noteno";
            // 
            // NoteContent
            // 
            this.NoteContent.DataPropertyName = "notecontents";
            this.NoteContent.HeaderText = "Notecontent";
            this.NoteContent.Name = "NoteContent";
            this.NoteContent.Visible = false;
            // 
            // notetitle
            // 
            this.notetitle.DataPropertyName = "notetitle";
            this.notetitle.HeaderText = "Title";
            this.notetitle.Name = "notetitle";
            this.notetitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.notetitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // userno
            // 
            this.userno.DataPropertyName = "userno";
            this.userno.HeaderText = "Writer";
            this.userno.Name = "userno";
            // 
            // notedate
            // 
            this.notedate.DataPropertyName = "notedate";
            this.notedate.HeaderText = "Date";
            this.notedate.Name = "notedate";
            // 
            // NoteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.dtNoteList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NoteList";
            this.Text = "NoteList";
            this.Load += new System.EventHandler(this.NoteList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNoteList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtNoteList;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mMOCCBulletinBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noteListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteno;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteContent;
        private System.Windows.Forms.DataGridViewLinkColumn notetitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn userno;
        private System.Windows.Forms.DataGridViewTextBoxColumn notedate;
    }
}