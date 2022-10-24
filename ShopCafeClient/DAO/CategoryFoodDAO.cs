using Cafee;
using ShopCafeClient.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShopCafeClient.DAO
{
    public class CategoryFoodDAO
    {
        private static CategoryFoodDAO instance;

        public static CategoryFoodDAO Instance
        {
            get
            {
                if (instance == null)
                { instance = new CategoryFoodDAO(); }
                return CategoryFoodDAO.instance;
            }
            private set { CategoryFoodDAO.instance = value; }
        }
        private CategoryFoodDAO() { }
        private CategoryFood newCategory(DataRow row)
        {
            CategoryFood categoryFood = new CategoryFood()
            {
                id = (int)row["id"],
                name = row["name"].ToString(),
                image = row["image"].ToString(),
            };
            return categoryFood;
        }
        public List<CategoryFood> ListCategory()
        {
            List<CategoryFood> categories = new List<CategoryFood>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.CategoryFood");
            foreach (DataRow dataRow in data.Rows)
            {
                CategoryFood categoryFood = newCategory(dataRow);
                categories.Add(categoryFood);
            }
            return categories;
        }
        public CategoryFood FoodCategoryByFood(int id)
        {
            CategoryFood foodCategory = null;
            string query = string.Format("SELECT *  FROM dbo.CategoryFood where id=" + id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                foodCategory = newCategory(item);
            }
            return foodCategory;
        }
        public List<CategoryFood> GetCategporyByCategoryID(int id)
        {
            List<CategoryFood> list = new List<CategoryFood>();
            string query = string.Format("SELECT *  FROM dbo.CategoryFood where id=" + id);
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                CategoryFood food = newCategory(dataRow);
                list.Add(food);
            }
            return list;
        }
    }
}
