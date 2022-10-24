using ShopCafeClient.DAO;
using ShopCafeClient.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCafeClient.BUS
{
    internal class CategoryFoodBUS
    {
        private static CategoryFoodBUS instance;
        private CategoryFoodBUS() { }

        public static CategoryFoodBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new CategoryFoodBUS(); }
                return CategoryFoodBUS.instance;
            }
            private set { CategoryFoodBUS.instance = value; }
        }
        public List<CategoryFood> ListAllCategory()
        {
            List<CategoryFood> categories = CategoryFoodDAO.Instance.ListCategory();
            return categories;
        }
        public CategoryFood GetFoodCategoryByFood(int id)
        {
            CategoryFood foodCategory = CategoryFoodDAO.Instance.FoodCategoryByFood(id);
            return foodCategory;
        }
        public List<CategoryFood> GetCategporyByCategoryID(int id)
        {
            List<CategoryFood> foodCategories = CategoryFoodDAO.Instance.GetCategporyByCategoryID(id);
            return foodCategories;
        }
    }
}
