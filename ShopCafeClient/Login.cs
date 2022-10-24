using ShopCafeClient;
using ShopCafeClient.DAO;
using ShopCafeClient.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Account account = new Account()
            {
                Username = txbUser.Text,
                Password = txbPass.Text
            };

            if (CheckLogin( account.Username, account.Password))
            {
                MessageBox.Show("Welcome to Cafe !!!!");
                Manager manager = new Manager();
                this.Hide();
                manager.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Login Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool CheckLogin(string Username, string Password)
        {
            return AccountDAO.Instance.CheckLogin(Username, Password);
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
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txbUser.Focus();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPass.Checked)
            {
                txbPass.UseSystemPasswordChar = false;
            }
            if (!ckbShowPass.Checked)
            {
                txbPass.UseSystemPasswordChar = true;
            }
        }
    }
}
