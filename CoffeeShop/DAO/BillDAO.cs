using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return instance; }
            private set { instance = value; }
        }

        private BillDAO() { }
        // Thành công : BillID, thất bại : -1
        public int GetUncheckBillByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Bill WHERE TableID = " + id + " AND BillStatus = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            else return -1;
        }

        public DataTable GetListBillByDate(DateTime start, DateTime end)
        {
            return DataProvider.Instance.ExcuteQuery("EXEC USP_GetListBillByDate @start , @end ", new object[] { start, end });
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("dbo.USP_InsertBill @TableID", new object[] { id });
        }

        public int GetMaxBillID()
        {
            return (int)DataProvider.Instance.ExcuteScalar("SELECT MAX(id) FROM Bill");
        }

        public void CheckOut(int id, int discount, int totalPrice)
        {
            string query = "UPDATE dbo.Bill SET BillStatus = 1, Discount = " + discount + ", TotalPrice = " + totalPrice + " WHERE ID = " + id;
            DataProvider.Instance.ExcuteNonQuery(query);
        }
    }
}
