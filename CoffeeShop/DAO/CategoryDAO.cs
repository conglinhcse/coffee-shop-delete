using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> listTable = new List<Category>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.FoodCategory");

            foreach (DataRow item in data.Rows)
            {
                Category table = new Category(item);
                listTable.Add(table);
            }

            return listTable;
        }
        public DataTable GetMenuCategory()
        {
            string query = "SELECT ID AS [Mã danh mục], FoodCatagoryName AS [Tên danh mục] FROM FoodCategory";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
        public bool InsertCategory(string categoryName)
        {
            string query = string.Format("INSERT dbo.FoodCategory (FoodCatagoryName) VALUES (N'{0}')", categoryName);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(string newName, int ID)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET FoodCatagoryName = N'{0}' WHERE ID = {1}", newName, ID);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(string newName, int ID)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET FoodCatagoryName = N'{0}' WHERE ID = {1}", newName + "(Tạm ngừng kinh doanh)", ID);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public DataTable SearchCategoryName(string categoryName)
        {

            string query = string.Format("SELECT ID AS [Mã danh mục], FoodCatagoryName AS [Tên danh mục] " +
                                         "FROM FoodCategory " +
                                         "WHERE FoodCatagoryName LIKE N'%{0}%'", categoryName);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
    }
}
