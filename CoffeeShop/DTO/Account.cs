using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
    public class Account
    {
        public Account(string username, string password, string displayName, int userType)
        {
            this.username = username;
            this.password = password;
            this.displayName = displayName;
            this.userType = userType;
        }

        public Account(DataRow row)
        {
            this.username = row["Username"].ToString();
            this.password = row["UserPassword"].ToString();
            this.displayName = row["DisplayName"].ToString();
            this.userType = (int)row["UserType"];
        }

        private string username;
        private string password;
        private string displayName;
        private int userType;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int UserType { get => userType; set => userType = value; }
    }
}
