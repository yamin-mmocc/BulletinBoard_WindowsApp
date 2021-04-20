
namespace WindowApplicationTest
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mMOCCBulletinBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMOCCBulletinBoardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mMOCCBulletinBoardToolStripMenuItem
            // 
            this.mMOCCBulletinBoardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerItem,
            this.loginItem,
            this.noteListItem});
            this.mMOCCBulletinBoardToolStripMenuItem.Name = "mMOCCBulletinBoardToolStripMenuItem";
            this.mMOCCBulletinBoardToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.mMOCCBulletinBoardToolStripMenuItem.Text = "MMOCC BulletinBoard";
            // 
            // registerItem
            // 
            this.registerItem.Name = "registerItem";
            this.registerItem.Size = new System.Drawing.Size(180, 22);
            this.registerItem.Text = "Register";
            this.registerItem.Click += new System.EventHandler(this.registerItem_Click);
            // 
            // loginItem
            // 
            this.loginItem.Name = "loginItem";
            this.loginItem.Size = new System.Drawing.Size(180, 22);
            this.loginItem.Text = "Login";
            this.loginItem.Click += new System.EventHandler(this.loginItem_Click);
            // 
            // noteListItem
            // 
            this.noteListItem.Name = "noteListItem";
            this.noteListItem.Size = new System.Drawing.Size(180, 22);
            this.noteListItem.Text = "Note List";
            this.noteListItem.Click += new System.EventHandler(this.noteListItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mMOCCBulletinBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerItem;
        private System.Windows.Forms.ToolStripMenuItem loginItem;
        private System.Windows.Forms.ToolStripMenuItem noteListItem;
    }
}