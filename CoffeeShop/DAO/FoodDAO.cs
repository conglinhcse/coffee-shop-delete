using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return instance; }
            private set { instance = value; }
        }

        private FoodDAO() { }


        public List<Food> GetFoodListByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "SELECT * FROM Food WHERE CategoryID = " + id.ToString();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public bool InsertFood(string name, int categoryId, int price)
        {
            string query = string.Format("INSERT dbo.Food (FoodName, CategoryID, FoodPrice) VALUES (N'{0}', {1}, {2})", name, categoryId, price);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateFood(string name, int categoryId, int price, int foodId)
        {
            string query = string.Format("UPDATE dbo.Food SET FoodName = N'{0}', CategoryID = {1}, FoodPrice = {2} WHERE ID = {3}", name, categoryId, price, foodId);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteFood(string name, int categoryId, int price, int foodId)
        {
            string query = string.Format("UPDATE dbo.Food SET FoodName = N'{0}', CategoryID = {1}, FoodPrice = {2} WHERE ID = {3}", name+"(Tạm ngừng kinh doanh)", categoryId, price, foodId);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
