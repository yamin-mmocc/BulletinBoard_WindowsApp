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
    public partial class NoteList : Form
    {
        public NoteList()
        {
            InitializeComponent();
            loadNoteData();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNote f1 = new AddNote(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f1 = new Home(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void noteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteList f1 = new NoteList(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            User.UserID = null;
            Home f2 = new Home(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void NoteList_Load(object sender, EventArgs e)
        {
            loadNoteData();
        }

        private void loadNoteData()
        {
            if (User.UserID == null)
            {
                //this.Hide();
                Login f2 = new Login(); //this is the change, code for redirect  
                f2.ShowDialog();
            }
            else
            {
                this.Show();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();


                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=yamin-mmocc;Database=MMOCC_Bulletin");
                conn.Open();
                // quite complex sql statement
                string sql = "Select * from tbl_note";
                // data adapter making request from our connection
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                // i always reset DataSet before i do
                // something with it.... i don't know why :-)
                ds.Reset();
                // filling DataSet with result from NpgsqlDataAdapter
                da.Fill(ds);
                // since it C# DataSet can handle multiple tables, we will select first
                dt = ds.Tables[0];
                // connect grid to DataTable
                dtNoteList.DataSource = dt;
                // since we only showing the result we don't need connection anymore
                conn.Close();
            }
        }

        private void dtNoteList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NoteDetails f2 = new NoteDetails(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void dtNoteList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtNoteList.Rows[e.RowIndex];
                User.NoteNo = row.Cells[0].Value.ToString();               
            }
        }
    }
}
