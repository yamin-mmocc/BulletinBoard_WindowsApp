using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowApplicationTest
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
        }

        private void noteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //NoteList f3 = new NoteList(); //this is the change, code for redirect  
            //f3.ShowDialog();
            Login f2 = new Login(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f1 = new Register(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=yamin-mmocc;Database=MMOCC_Bulletin");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            string ndate = dtNoteDate.Text.ToString();
            cmd.CommandText = "INSERT INTO tbl_note (NoteTitle, NoteContents,NoteDate,UserNo) VALUES(@notetitle, @content,@notedate,@userno)";
            cmd.Parameters.AddWithValue("notetitle", txttitle.Text.Trim());
            cmd.Parameters.AddWithValue("content", txtcontent.Text.Trim());
            cmd.Parameters.AddWithValue("notedate", dtNoteDate.Text.Trim());
            cmd.Parameters.AddWithValue("userno", Convert.ToInt32(User.UserNo));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Add Note");
            this.Hide();
            //NoteList f = new NoteList(); //this is the change, code for redirect  
            //f.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteList f = new NoteList(); //this is the change, code for redirect  
            f.ShowDialog();
        }
    }
}
