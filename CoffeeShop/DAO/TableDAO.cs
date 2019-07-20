using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set { instance = value; }
        }

        private TableDAO() { }

        public static int TableHeight = 120;
        public static int TableWidth = 120;

        public List<Table> GetListTable()
        {
            List<Table> listTable = new List<Table>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.FoodTable");

            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                listTable.Add(table);
            }

            return listTable;
        }

        public DataTable GetMenuTable()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT ID AS [Mã bàn], TableName AS [Tên bàn], TableStatus AS[Trạng thái] FROM dbo.FoodTable");

            return data;
        }

        public bool InsertTable(string name, string status)
        {
            string query = string.Format("INSERT dbo.FoodTable (TableName, TableStatus) VALUES (N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateTable(string name, string status, int ID)
        {
            string query = string.Format("UPDATE dbo.FoodTable SET TableName = N'{0}', TableStatus = N'{1}' WHERE ID = {2}", name, status, ID);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteTable(string name, string status, int ID)
        {
            string query = string.Format("UPDATE dbo.FoodTable SET TableName = N'{0}', TableStatus = N'{1}' WHERE ID = {2}", name+"(Đang sửa)", status, ID);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public DataTable SearchTableName(string tableName)
        {

            string query = string.Format( "SELECT ID AS[Mã bàn], TableName AS[Tên bàn], TableStatus AS[Trạng thái] " +
                                          "FROM dbo.FoodTable " +
                                          "WHERE TableName LIKE N'%{0}%'", tableName);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
    }
}
