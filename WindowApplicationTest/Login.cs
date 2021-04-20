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
    public partial class Login : Form
    {
        public Login()
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=yamin-mmocc;Database=MMOCC_Bulletin");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tbl_users where UserId = @id  AND UserPassword = @password";
            cmd.Parameters.AddWithValue("id", txtuserID.Text.ToString());
            cmd.Parameters.AddWithValue("password",txtpassword.Text.ToString());
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                User.UserID = txtuserID.Text.Trim().ToString();
                while (dr.Read())
                {
                    User.UserNo = dr.GetValue(0).ToString(); // On first iteration will be hello
                    
                }
                this.Hide();
                NoteList f3 = new NoteList(); //this is the change, code for redirect  
                f3.Show();
            }
            else
            {
                MessageBox.Show("User name or password is invalid.");
            }
        }
    }
}
