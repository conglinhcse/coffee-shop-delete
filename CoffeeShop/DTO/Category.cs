using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class Category
    {
        public Category(int iD, string name)
        {
            this.iD = iD;
            this.name = name;
        }
        public Category(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["FoodCatagoryName"].ToString();
        }

        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
