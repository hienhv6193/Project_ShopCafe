using ShopCafeClient.BUS;
using ShopCafeClient.DAO;
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
    public partial class adminCategory : Form
    {
        public adminCategory()
        {
            InitializeComponent();
        }

        private void adminCategory_Load(object sender, EventArgs e)
        {
            List<CategoryFood> categoryFoods = CategoryFoodBUS.Instance.ListAllCategory();
            dgvListCategory.DataSource = categoryFoods;
        }

        private void dgvListCategory_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
        }
    }
}
