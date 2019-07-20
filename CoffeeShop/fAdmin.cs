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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadDateTimePinkerBill();
            LoadListBillByDate(dtpStart.Value, dtpEnd.Value);

            LoadFoodMenu();
            LoadCategoryIntoCombobox();
            AddFoodBinding();

            LoadCategoryMenu();
            AddCategoryBinding();

            LoadTableMenu();
            AddTableBinding();

            LoadAccountMenu();
            AddAccountBinding();

        }
        #region Method
        void LoadDateTimePinkerBill()
        {
            DateTime today = DateTime.Now;
            dtpStart.Value = new DateTime(today.Year, today.Month, 1);
            dtpEnd.Value = dtpStart.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime start, DateTime end)
        {
            dgvListBill.DataSource = BillDAO.Instance.GetListBillByDate(start, end);
        }
        void LoadFoodMenu()
        {
            dgvListFood.DataSource = MenuDAO.Instance.GetFoodMenu();
        }
        void LoadCategoryIntoCombobox()
        {
            cbFoodCategory.DisplayMember = "name";
            cbFoodCategory.DataSource = CategoryDAO.Instance.GetListCategory();
        }
        void AddFoodBinding()
        {
            tbFoodName.DataBindings.Add(new Binding("Text", dgvListFood.DataSource, "Tên món", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", dgvListFood.DataSource, "Giá tiền", true, DataSourceUpdateMode.Never));
            cbFoodCategory.DataBindings.Add(new Binding("Text", dgvListFood.DataSource, "Danh mục", true, DataSourceUpdateMode.Never));
            tbFoodID.DataBindings.Add(new Binding("Text", dgvListFood.DataSource, "Mã món", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryMenu()
        {
            dgvCategory.DataSource = CategoryDAO.Instance.GetMenuCategory();
        }
        void AddCategoryBinding()
        {
            tbCategoryID.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Mã danh mục", true, DataSourceUpdateMode.Never));
            tbNameCategory.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Tên danh mục", true, DataSourceUpdateMode.Never));
        }
        void LoadTableMenu()
        {
            dgvFoodTable.DataSource = TableDAO.Instance.GetMenuTable();
        }
        void AddTableBinding()
        {
            tbTableID.DataBindings.Add(new Binding("Text", dgvFoodTable.DataSource, "Mã bàn", true, DataSourceUpdateMode.Never));
            tbTableName.DataBindings.Add(new Binding("Text", dgvFoodTable.DataSource, "Tên bàn", true, DataSourceUpdateMode.Never));
            cbTableStatus.DataBindings.Add(new Binding("Text", dgvFoodTable.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
        }
        void LoadAccountMenu()
        {
            dtgvAccount.DataSource = AccountDAO.Instance.GetMenuAccount();
        }
        void AddAccountBinding()
        {
            tbUsername.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên tài khoản", true, DataSourceUpdateMode.Never));
            tbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            cbUserType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never));
        }
        DataTable SearchFoodByName(string foodName)
        {
            DataTable data = MenuDAO.Instance.SearchFoodName(foodName);

            return data;
        }
        DataTable SearchCategoryByName(string categoryName)
        {
            DataTable data = CategoryDAO.Instance.SearchCategoryName(categoryName);

            return data;
        }
        DataTable SearchTableByName(string tableName)
        {
            DataTable data = TableDAO.Instance.SearchTableName(tableName);

            return data;
        }
        DataTable SearchAccountByName(string displayName)
        {
            DataTable data = AccountDAO.Instance.SearchAccountName(displayName);

            return data;
        }

        #endregion

        #region Event


        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            string foodName = tbFoodName.Text;
            int categoryId = (cbFoodCategory.SelectedItem as Category).ID;
            int price = (int)nmPrice.Value;
            int foodId = Convert.ToInt32(tbFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(foodName, categoryId, price, foodId))
            {
                MessageBox.Show("Xóa món ăn thành công", "Thông báo");
                LoadFoodMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi xóa món ăn", "Thông báo");
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string categoryName = tbNameCategory.Text;
            int categoryId = Convert.ToInt32(tbCategoryID.Text);

            if (CategoryDAO.Instance.DeleteCategory(categoryName, categoryId))
            {
                MessageBox.Show("Xóa danh mục thành công", "Thông báo");
                LoadCategoryMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi xóa thông tin danh mục", "Thông báo");
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string tableName = tbTableName.Text;
            string tableStatus = cbTableStatus.Text;
            int tableId = Convert.ToInt32(tbTableID.Text);

            if (TableDAO.Instance.DeleteTable(tableName, tableStatus, tableId))
            {
                MessageBox.Show("Xóa bàn ăn thành công", "Thông báo");
                LoadTableMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi xóa bàn ăn", "Thông báo");
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;

            if (AccountDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo");
                LoadAccountMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi xóa tài khoản", "Thông báo");
            }
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;
            LoadListBillByDate(start, end);
        }







        private void btnEditFoodInfo_Click(object sender, EventArgs e)
        {
            string foodName = tbFoodName.Text;
            int categoryId = (cbFoodCategory.SelectedItem as Category).ID;
            int price = (int)nmPrice.Value;
            int foodId = Convert.ToInt32(tbFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(foodName, categoryId, price, foodId))
            {
                MessageBox.Show("Sửa thông tin món ăn thành công", "Thông báo");
                LoadFoodMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi sửa thông tin món ăn", "Thông báo");
            }
        }


        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string categoryName = tbNameCategory.Text;
            int categoryId = Convert.ToInt32(tbCategoryID.Text);

            if (CategoryDAO.Instance.UpdateCategory(categoryName, categoryId))
            {
                MessageBox.Show("Sửa thông tin danh mục thành công", "Thông báo");
                LoadCategoryMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi sửa thông tin danh mục", "Thông báo");
            }
        }
        private void btnUpdateTable_Click(object sender, EventArgs e)
        {
            string tableName = tbTableName.Text;
            string tableStatus = cbTableStatus.Text;
            int tableId = Convert.ToInt32(tbTableID.Text);

            if (TableDAO.Instance.UpdateTable(tableName, tableStatus, tableId))
            {
                MessageBox.Show("Sửa thông tin bàn ăn thành công", "Thông báo");
                LoadTableMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi sửa thông tin bàn ăn", "Thông báo");
            }
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string foodName = tbFoodName.Text;
            int categoryId = (cbFoodCategory.SelectedItem as Category).ID;
            int price = (int)nmPrice.Value;
            if (FoodDAO.Instance.InsertFood(foodName, categoryId, price))
            {
                MessageBox.Show("Thêm món thành công", "Thông báo");
                LoadFoodMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi thêm món", "Thông báo");
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = tbNameCategory.Text;

            if (CategoryDAO.Instance.InsertCategory(categoryName))
            {
                MessageBox.Show("Thêm danh mục thành công", "Thông báo");
                LoadCategoryMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi thêm danh mục", "Thông báo");
            }
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string tableName = tbTableName.Text;
            string tableStatus = cbTableStatus.Text;
            if (TableDAO.Instance.InsertTable(tableName, tableStatus))
            {
                MessageBox.Show("Thêm bàn thành công", "Thông báo");
                LoadTableMenu();
            }
            else
            {
                MessageBox.Show("Xảy ra lỗi khi thêm bàn", "Thông báo");
            }
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbUsername.Text;
                string password = tbUsername.Text;
                string displayName = tbDisplayName.Text;
                int userType = Convert.ToInt32(cbUserType.Text);
                if (AccountDAO.Instance.InsertAccount(password, displayName, userType, username))
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Thông báo");
                    LoadAccountMenu();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi thêm tài khoản", "Thông báo");
                }
            }
            catch { }
        }
        private void btnFindFood_Click(object sender, EventArgs e)
        {
            string foodName = tbFindFood.Text;
            dgvListFood.DataSource = SearchFoodByName(foodName);
        }
        private void btnFindCategory_Click(object sender, EventArgs e)
        {
            string categoryName = tbFindCategory.Text;
            dgvCategory.DataSource = SearchCategoryByName(categoryName);
        }
        private void btnFindTable_Click(object sender, EventArgs e)
        {
            string tableName = tbFindTable.Text;
            dgvFoodTable.DataSource = SearchTableByName(tableName);
        }

        private void btnFindAccount_Click(object sender, EventArgs e)
        {
            string displayName = tbFindAccount.Text;
            dtgvAccount.DataSource = SearchAccountByName(displayName);
        }

        #endregion

       
    }
}
