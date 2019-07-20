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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            string content = "Bạn có thật sự muốn thoát chương trình";
            string title = "Thông báo";
            if (MessageBox.Show(content, title, MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            if(isLogin(username, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUsername(username); 
                fTableManager fTabMan = new fTableManager(loginAccount);
                this.Hide();
                fTabMan.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tên tài khoản hoặc mật khẩu", "Thông báo");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isLogin(string username, string password)
        {
            return AccountDAO.Instance.isLogin(username, password);
        }
    }
}
