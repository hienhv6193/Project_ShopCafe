using ShopCafeClient.BUS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ShopCafeClient
{
    public partial class adminFood : Form
    {
        int idFood = 0;
        string imageFood = "";
        public adminFood()
        {
            InitializeComponent();
        }

        private void adminFood_Load(object sender, EventArgs e)
        {
            LoadTVCategory();
        }
        private void LoadTVCategory()
        {
            lvFood.View = View.Details;
            lvFood.SmallImageList = imgLarge;
            List<CategoryFood> categories = CategoryFoodBUS.Instance.ListAllCategory();
            cbbFood.DataSource = categories;
            cbbFood.DisplayMember = "name";
            cbbFood.ValueMember = "id";

            int count = 0;
            foreach (CategoryFood cate in categories)
            {
                TreeNode node = new TreeNode();
                node.Text = cate.name;
                node.Tag = cate.id;
                node.ImageKey = cate.image;

                List<Food> foodList = FoodBUS.Instance.GetFoodByCategoryID(cate.id);
                foreach (Food food in foodList)
                {
                    TreeNode subNode = new TreeNode();
                    subNode.Text = food.name;
                    subNode.ImageKey = food.image;
                    subNode.SelectedImageKey = food.image;
                    subNode.Tag = food.id;
                    node.Nodes.Add(subNode);
                }
                tvCategoryFood.Nodes.Add(node);
                count++;
            }
        }
        private void lvFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFood.SelectedItems.Count > 0)
            {
                txbID.Text = lvFood.SelectedItems[0].SubItems[1].Text;
                txbNameFood.Text = lvFood.SelectedItems[0].SubItems[2].Text;
                int id = Int32.Parse(lvFood.SelectedItems[0].SubItems[3].Text);
                idFood = id;
                Food food = FoodBUS.Instance.GetFoodCategoryByFood(id);
                cbbFood.Text = food.name;
                nudPrice.Text = lvFood.SelectedItems[0].SubItems[4].Text;
                imageFood = lvFood.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void tvCategoryFood_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvFood.Items.Clear();
            int foodCateID = Int32.Parse(e.Node.Tag.ToString());
            List<Food> foods = FoodBUS.Instance.GetFoodByCategoryID(foodCateID);
            foreach (Food food in foods)
            {
                ListViewItem item = new ListViewItem();
                item.Text = food.name;
                item.ImageKey = food.image;
                item.SubItems.Add(food.id.ToString());
                item.SubItems.Add(food.name);
                item.SubItems.Add(food.idCategory.ToString());
                item.SubItems.Add(food.price.ToString());
                item.SubItems.Add(food.image);
                lvFood.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

        }
    }
}
