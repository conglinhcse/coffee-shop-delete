using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "SELECT f.FoodName, bi.CountBill, f.FoodPrice, f.FoodPrice*bi.CountBill AS TotalPrice "
                         + "FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f "
                         + "WHERE bi.BillID = b.ID AND bi.FoodID = f.ID AND b.BillStatus = 0 AND b.TableID = " + id.ToString();
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

        public DataTable GetFoodMenu()
        {

            string query = "SELECT F.FoodName AS [Tên món], F.FoodPrice AS [Giá tiền], C.FoodCatagoryName AS [Danh mục], F.ID AS[Mã món]" +
                           "FROM Food AS F, FoodCategory AS C " +
                           "WHERE C.ID = F.CategoryID";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }

        public DataTable SearchFoodName(string foodName)
        {

            string query = string.Format("SELECT F.FoodName AS[Tên món], F.FoodPrice AS[Giá tiền], C.FoodCatagoryName AS[Danh mục], F.ID AS[Mã món]" +
                                         "FROM Food AS F, FoodCategory AS C " +
                                         "WHERE F.FoodName LIKE N'%{0}%' AND C.ID = F.CategoryID", foodName);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }
    }
}
