using ShopCafeClient.BUS;
using ShopCafeClient.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopCafeClient
{
    public partial class adminAccount : Form
    {
        public adminAccount()
        {
            InitializeComponent();
        }

        private void adminAccount_Load(object sender, EventArgs e)
        {
            List<Account> accounts = AccountBUS.Instance.GetAll();
            dvcListAccount.DataSource = accounts;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String key = txbSearch.Text.Trim();
            List<Account> accounts =  AccountBUS.Instance.Search(key);
            dvcListAccount.DataSource = accounts;
        }

        private void dvcListAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (dvcListAccount.SelectedRows.Count > 0)
            {
               int id = int.Parse(dvcListAccount.SelectedRows[0].Cells["id"].Value.ToString());
                Account account = AccountBUS.Instance.GetDetails(id);
                if (account != null)
                {
                    txbID.Text = account.id.ToString();
                    txbUser.Text = account.Username;
                    txbDisplay.Text = account.DisplayName;
                    txbType.Text = account.type.ToString();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                id = 0,
                Username = txbUser.Text.Trim(),
                DisplayName = txbDisplay.Text.Trim(),
                type = int.Parse(txbType.Text),
            };



            bool result = new AccountBUS().AddNew(account);

            if (result)
            {
                List<Account> accounts = AccountBUS.Instance.GetAll();
                dvcListAccount.DataSource = accounts;
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                id = int.Parse(txbID.Text),
                DisplayName = txbDisplay.Text.Trim(),
                type = int.Parse(txbType.Text),
            };



            bool result = new AccountBUS().Update(account);


            if (result)
            {
                List<Account> accounts = AccountBUS.Instance.GetAll();
                dvcListAccount.DataSource = accounts;
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa !", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(txbID.Text);
                bool result = new AccountBUS().Delete(id);
                if (result)
                {
                    List<Account> accounts = AccountBUS.Instance.GetAll();
                    dvcListAccount.DataSource = accounts;
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }
    }
}
