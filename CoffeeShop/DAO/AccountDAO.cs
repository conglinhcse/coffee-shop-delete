using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public DataTable GetMenuAccount()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT Username AS [Tên tài khoản], UserPassword AS [Mật khẩu], DisplayName AS [Tên hiển thị], UserType AS[Loại tài khoản] FROM dbo.Account");

            return data;
        }

        public bool isLogin(string username, string passworrd)
        {
            string query = "USP_Login @username , @password";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] {username, passworrd });

            return data.Rows.Count > 0;
        }

        public Account GetAccountByUsername(string userName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM Account WHERE Username = '" + userName + "'");

            foreach(DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool UpdateAccount(string password, string displayName, string userType, string username)
        {
            int iUserType = 0;
            if (userType == "Quản trị viên") iUserType = 1;
            string query = string.Format("UPDATE dbo.Account SET UserPassword = N'{0}', DisplayName = N'{1}', UserType = {2} WHERE Username = N'{3}'", password, displayName, iUserType, username);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public bool InsertAccount(string password, string displayName, int userType, string username)
        {
            string query = string.Format("INSERT dbo.Account (Username, UserPassword, DisplayName, UserType) VALUES (N'{0}', N'{1}', N'{2}', {3})", username, password, displayName, userType);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public DataTable SearchAccountName(string displayName)
        {

            string query = string.Format("SELECT Username AS [Tên tài khoản], UserPassword AS [Mật khẩu], DisplayName AS [Tên hiển thị], UserType AS[Loại tài khoản] " +
                                         "FROM dbo.Account " +
                                         "WHERE DisplayName LIKE N'%{0}%'", displayName);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            return data;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("DELETE FROM dbo.Account WHERE Username = N'{0}'", username);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
