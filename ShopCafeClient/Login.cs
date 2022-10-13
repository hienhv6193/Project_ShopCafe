using ShopCafeClient;
using ShopCafeClient.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopCafeClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txbUser.Text.Trim();
            string Password = txbPass.Text.Trim();
            if (CheckLogin(Username, Password))
            {
                Manager manager = new Manager();
                this.Hide();
                manager.ShowDialog();
                this.Show();
                MessageBox.Show("Welcome to Cafe !!!!");
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu! Xin vui lòng nhập lại");
            }
        }

        bool CheckLogin(string Username, string Password)
        {
            return false;
        }
        private void btxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            MessageBox.Show("Welcome to Cafe !!!!");
            manager.ShowDialog();
            this.Show();
        }
    }
}
