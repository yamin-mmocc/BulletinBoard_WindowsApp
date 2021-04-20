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
    public partial class NoteDetails : Form
    {
        public NoteDetails()
        {
            InitializeComponent();
        }


        private void NoteDetails_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=yamin-mmocc;Database=MMOCC_Bulletin");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from tbl_note where noteno = @noteno";
            cmd.Parameters.AddWithValue("noteno", Convert.ToInt32(User.NoteNo.ToString()));
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    User.UserNo = dr.GetValue(0).ToString(); // On first iteration will be hello
                    lblcontent.Text = dr.GetValue(1).ToString();
                    lbltitle.Text = dr.GetValue(1).ToString();
                    lbldate.Text = dr.GetValue(3).ToString();
                    //txtcontent.Text = dr.GetValue(2).ToString();
                    rtxtcontent.Text= dr.GetValue(2).ToString();

                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
