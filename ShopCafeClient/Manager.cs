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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
    }
}
