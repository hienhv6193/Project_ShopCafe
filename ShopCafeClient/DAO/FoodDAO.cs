using Cafee;
using Demo;
using ShopCafeClient.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCafeClient.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        private FoodDAO() { }
        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) { instance = new FoodDAO(); }
                return FoodDAO.instance;
            }
            private set { FoodDAO.instance = value; }
        }
        private Food newFood(DataRow row)
        {
            Food food = new Food()
            {
                id = (int)row["id"],
                name = row["name"].ToString(),
                idCategory = (int)row["idCategory"],
                price = (float)row["price"],
                image = (string)row["image"],
            };
            return food;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food> ();
            string query = "SELECT *  FROM dbo.Food";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow dataRow in dataTable.Rows)
            {
                Food food = newFood(dataRow);
                list.Add(food);
            }
            return list;
        }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("SELECT *  FROM dbo.Food where idCategory=@id", new object[] { id });
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Food food = newFood(dataRow);
                list.Add(food);
            }
            return list;
        }

        public Food FoodCategoryByFood(int id)
        {
            Food foodCategory = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.CategoryFood where id= @id", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                foodCategory = newFood(item);
            }
            return foodCategory;
        }

        public bool AddFood(Food newFood)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "INSERT INTO Food(name,idCategory,price,image) VALUES( @name , @idCategory , @price , @image )",
                new object[] { newFood.name, newFood.idCategory, newFood.price, newFood.image, newFood.id });
            if (result == true)
                return true;
            return false;
        }
        public bool UpdateFood(Food newFood)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "UPDATE Food SET name= @name ,idCategory= @idCategory ,price= @price ,image= @image where id= @ID",
                new object[] { newFood.name, newFood.idCategory, newFood.price, newFood.image, newFood.id });
            if (result == true)
                return true;
            return false;
        }
        public bool DeteleFood(int id)
        {
            bool result = DataProvider.Instance.ExecuteNonQurey(
                "DELETE FROM Food where id= @id ",
                new object[] { id });
            if (result == true)
                return true;
            return false;
        }
    }
}
