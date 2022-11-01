using ShopCafeClient.DAO;
using ShopCafeClient.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCafeClient.BUS
{
    public class FoodBUS
    {
        private static FoodBUS instance;

        public static FoodBUS Instance
        {
            get
            {
                if (instance == null)
                { instance = new FoodBUS(); }
                return FoodBUS.instance;
            }
            private set { FoodBUS.instance = value; }
        }
        private FoodBUS() { }

        public List<Food> GetListFood()
        {
            List<Food> foods = FoodDAO.Instance.GetListFood();
            return foods;
        }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> foods = FoodDAO.Instance.GetFoodByCategoryID(id);
            return foods;
        }
        public Food GetFoodCategoryByFood(int id)
        {
            Food foodCategory = FoodDAO.Instance.FoodCategoryByFood(id);
            return foodCategory;
        }

        public bool AddFood(Food newFood)
        {
            return FoodDAO.Instance.AddFood(newFood);
        }
        public bool UpdateFood(Food newFood)
        {
            return FoodDAO.Instance.UpdateFood(newFood);
        }
        public bool DeteleFood(int id)
        {
            return FoodDAO.Instance.DeteleFood(id);
        }
    }
}
