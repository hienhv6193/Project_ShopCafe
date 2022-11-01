using ShopCafeClient.DTO;
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

        //bool CheckType(Account account)
        //{
        //    if (account.type == 1)
        //    {
        //        doanhThuToolStripMenuItem.Enabled = thứcĂnToolStripMenuItem.Enabled = danhMụcToolStripMenuItem.Enabled = bànĂnToolStripMenuItem.Enabled = tàiKhoảnToolStripMenuItem.Enabled = false;
        //    }
        //}

        private void Manager_Load(object sender, EventArgs e)
        {
            //CheckType();
        }
        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminRevenue revenue = new adminRevenue();
            revenue.ShowDialog();
        }
        private void thứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminFood food = new adminFood();
            food.ShowDialog();
        }
        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminAccount adminAccount = new adminAccount();
            adminAccount.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminCategory adminCategory = new adminCategory();
            adminCategory.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
