using CoffeeShop.DAO;
using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class fAccInfo : Form
    {
        public fAccInfo(Account Acc)
        {
            InitializeComponent();
            tbUsername.Text = Acc.Username;
            tbPassword.Text = Acc.Password;
            tbDisplayName.Text = Acc.DisplayName;
            if (Acc.UserType == 0) tbUserType.Text = "Nhân viên";
            else tbUserType.Text = "Quản trị viên";
        }

        private void btnChangeAccInfo_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string displayName = tbDisplayName.Text;
            string userType = tbUserType.Text;

            if (AccountDAO.Instance.UpdateAccount(password, displayName, userType, username))
            {
                MessageBox.Show("Sửa thông tin tài khoản thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi sửa thông tin tài khoản", "Thông báo");
            }
        }
    }
}
