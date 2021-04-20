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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void registerItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register f1 = new Register(); //this is the change, code for redirect  
            f1.ShowDialog();
        }

        private void loginItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f2 = new Login(); //this is the change, code for redirect  
            f2.ShowDialog();
        }

        private void noteListItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NoteList f3 = new NoteList(); //this is the change, code for redirect  
            f3.ShowDialog();
        }
    }
}
