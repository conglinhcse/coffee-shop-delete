using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class Bill
    {
        public Bill(int id, int tableId, DateTime? dateCheckIn, int status, int discount, int totalPrice)
        {
            this.id = id;
            this.tableId = tableId;
            this.dateCheckIn = dateCheckIn;
            this.status = status;
            this.discount = discount;
            this.totalPrice = totalPrice;
        }

        public Bill(DataRow row)
        {
            this.id = (int)row["ID"];
            this.tableId = (int)row["TableID"];
            this.dateCheckIn = (DateTime?)row["DateCheckIn"];
            this.status = (int)row["BillStatus"];
            this.discount = (int)row["Discount"];
            this.totalPrice = (int)row["TotalPrice"];
        }

        private int id;
        private DateTime? dateCheckIn;
        private int status;
        private int tableId;
        private int discount;
        private int totalPrice;

        public int Id { get => id; set => id = value; }
        public int TableId { get => tableId; set => tableId = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
