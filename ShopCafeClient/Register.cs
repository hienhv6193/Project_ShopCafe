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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công!!!");
        }

        private void ckbHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHidePass.Checked)
            {
                txbPass.UseSystemPasswordChar = txbCheckPass.UseSystemPasswordChar = false;
            }
            if (!ckbHidePass.Checked)
            {
                txbPass.UseSystemPasswordChar = txbCheckPass.UseSystemPasswordChar = true;
            }
        }
    }
}
