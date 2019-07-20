using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class Food
    {
        public Food(int iD, int categoryID, string foodName, int foodPrice)
        {
            this.iD = iD;
            this.categoryID = categoryID;
            this.foodName = foodName;
            this.foodPrice = foodPrice;
        }
        public Food(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.categoryID = (int)row["CategoryID"];
            this.foodName = row["FoodName"].ToString();
            this.foodPrice = (int)row["FoodPrice"];
        }
        private int iD;
        private int categoryID;
        private string foodName;
        private int foodPrice;

        public int ID { get => iD; set => iD = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int FoodPrice { get => foodPrice; set => foodPrice = value; }
    }
}
