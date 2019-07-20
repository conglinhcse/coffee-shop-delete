using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billId, int foodId, int count)
        {
            this.id = id;
            this.billId = billId;
            this.foodId = foodId;
            this.count = count;
        }
        
        public BillInfo(DataRow row)
        {
            this.id = (int)row["ID"];
            this.billId = (int)row["BillID"];
            this.foodId = (int)row["FoodID"];
            this.count = (int)row["CountBill"];
        }

        private int id;
        private int billId;
        private int foodId;
        private int count;

        public int ID { get => id; set => id = value; }
        public int BillId { get => billId; set => billId = value; }
        public int FoodId { get => foodId; set => foodId = value; }
        public int Count { get => count; set => count = value; }
    }
}
