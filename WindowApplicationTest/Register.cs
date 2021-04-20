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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void noteListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteList f3 = new NoteList(); //this is the change, code for redirect  
            f3.ShowDialog();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f = new Home(); //this is the change, code for redirect  
            f.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=yamin-mmocc;Database=MMOCC_Bulletin");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO tbl_users (UserId, UserName,UserPassword) VALUES(@id, @name,@password)";
            cmd.Parameters.AddWithValue("id", txtuserID.Text.Trim());
            cmd.Parameters.AddWithValue("name", txtUserName.Text.Trim());
            cmd.Parameters.AddWithValue("password", txtPassword.Text.Trim());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully register");
            this.Hide();
            Home f = new Home(); //this is the change, code for redirect  
            f.ShowDialog();
        }
    }
}
