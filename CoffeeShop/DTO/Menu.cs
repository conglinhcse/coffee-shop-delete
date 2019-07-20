using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class Menu
    {
        public Menu(string foodName, int count, int price, int totalPrice = 0)
        {
            this.foodName = foodName;
            this.count = count;
            this.price = price;
            this.totalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.foodName = row["FoodName"].ToString();
            this.count = (int)row["CountBill"];
            this.price = (int)row["FoodPrice"];
            this.totalPrice = (int)row["TotalPrice"];
        }

        private string foodName;
        private int count;
        private int price;
        private int totalPrice;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public int Price { get => price; set => price = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
