using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCafeClient
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {

            changePassword changepassword = new changePassword();
            this.Hide();
            changepassword.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeProfile changeProfile = new changeProfile();
            this.Hide();
            changeProfile.ShowDialog();
            this.Show();
        }
    }
}
