using CoffeeShop.DAO;
using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class fTableManager : Form
    {
        // Thuộc tính
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.UserType); }
        }
        // Hàm dựng
        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
        }
        #region Method
        void ChangeAccount(int type)
        {
            mntAdmin.Enabled = type == 1;
        }
        void LoadCategory()
        {
            cbCategoryFood.DisplayMember = "name";
            cbCategoryFood.DataSource = CategoryDAO.Instance.GetListCategory(); ;
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodListByCategoryID(id);
            cbFood.DisplayMember = "foodName";
            cbFood.DataSource = listFood;
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();

            List<Table> listTable = TableDAO.Instance.GetListTable();

            foreach (Table item in listTable)
            {
                // Tạo 1 button tương ứng 1 bàn
                Button btn = new Button() { Height = TableDAO.TableHeight, Width = TableDAO.TableWidth };
                // Set text cho button
                btn.Text = item.Name + Environment.NewLine + item.Status;
                // Set color cho button
                if (item.Status == "Trống") btn.BackColor = Color.GhostWhite;
                if (item.Status == "Có người") btn.BackColor = Color.Gray;
                // Tạo thẻ cho button
                btn.Tag = item;
                // Tạo 1 sự kiện(event) cho button
                btn.Click += btn_Click;
                flpTable.Controls.Add(btn);
            }

        }
        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            int TotalPrice = 0;
            int discount = (int)nmDiscount.Value;
            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                lvBill.Items.Add(lsvItem);
                TotalPrice += item.TotalPrice;
            }
            TotalPrice = TotalPrice*(100 - discount)/100;
            //CultureInfo culture = new CultureInfo("vi-VN");
            //tbTotalPrice.Text = TotalPrice.ToString("c", culture);
            tbTotalPrice.Text = TotalPrice.ToString() + " VNĐ";
        }
        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as Table).ID;
            lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
        }
        private void mntAboutSoftware_Click(object sender, EventArgs e)
        {
            string content = "Phần mềm quản lý bán hàng, dùng cho các quán cà phê." + Environment.NewLine +
                             "Do nhóm sinh viên Bách Khoa thiết kế.";
            string title = "Thông tin phần mềm";
            MessageBox.Show(content, title, MessageBoxButtons.OK);
        }

        private void mntAboutAuthor_Click(object sender, EventArgs e)
        {
            string content = "Nhóm tác giả gồm 3 sinh viên của Khoa khoa học và kỹ thuật máy tính. " + Environment.NewLine +
                             "Đỗ Đăng Khôi - 1711807" + Environment.NewLine +
                             "Nguyễn Hữu Thắng - 171" + Environment.NewLine +
                             "Võ Trung Thiên Tường - 170";
            string title = "Thông tin tác giả";
            MessageBox.Show(content, title, MessageBoxButtons.OK);
        }

        private void mntUpdateSoftware_Click(object sender, EventArgs e)
        {
            string content = "Tác giả phần mềm khuyến cáo bạn nên cập nhật phần mềm thường xuyên (hàng tháng)." + Environment.NewLine +
                             "Để cập nhập phần mềm, bạn truy suất đường link bên dưới : " + Environment.NewLine +
                             "https://github.com/UrekMazinoTOG/CoffeeShop";
            string title = "Cập nhật phần mềm";
            MessageBox.Show(content, title, MessageBoxButtons.OK);
        }

        private void mntFeedBack_Click(object sender, EventArgs e)
        {
            string content = "Tác giả thành thật xin lỗi vì lỗi tồn đọng của phần mềm." + Environment.NewLine +
                             "Để báo lỗi hệ thống, bạn truy cập đường link bên dưới : " + Environment.NewLine +
                             "https://github.com/UrekMazinoTOG/CoffeeShop";
            string title = "Báo lỗi hệ thống";
            MessageBox.Show(content, title, MessageBoxButtons.OK);
        }

        private void mntAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdmin fAd = new fAdmin();
            fAd.ShowDialog();
            this.Show();
        }
        private void cbCategoryFoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null) return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListByCategoryID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;

            int billID = BillDAO.Instance.GetUncheckBillByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmNumOfFood.Value;

            if (billID == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxBillID(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(billID, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            int totalPrice = Convert.ToInt32(tbTotalPrice.Text.Split(' ')[0]);

            if (idBill != -1)
            {
                string content = "Bạn có chắc muốn thanh toán hóa đơn cho " + table.Name;
                string title = "Thông báo";
                if (MessageBox.Show(content, title, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, totalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            ShowBill(table.ID);
        }

        private void mntAccInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAccInfo fAccInfo = new fAccInfo(loginAccount);
            fAccInfo.ShowDialog();
            this.Show();

            loginAccount = AccountDAO.Instance.GetAccountByUsername(loginAccount.Username);
        }
        #endregion


    }
}
