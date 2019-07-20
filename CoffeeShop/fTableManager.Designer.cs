namespace CoffeeShop
{
    partial class fTableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mntAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mntAccInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mntAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mntAboutSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.mntAboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.mntUpdateSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.mntFeedBack = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.nmNumOfFood = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbCategoryFood = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNumOfFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntAdmin,
            this.mntAccInfo,
            this.mntAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1218, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mntAdmin
            // 
            this.mntAdmin.Name = "mntAdmin";
            this.mntAdmin.Size = new System.Drawing.Size(87, 20);
            this.mntAdmin.Text = "Quản trị viên";
            this.mntAdmin.Click += new System.EventHandler(this.mntAdmin_Click);
            // 
            // mntAccInfo
            // 
            this.mntAccInfo.Name = "mntAccInfo";
            this.mntAccInfo.Size = new System.Drawing.Size(123, 20);
            this.mntAccInfo.Text = "Thông tin tài khoản";
            this.mntAccInfo.Click += new System.EventHandler(this.mntAccInfo_Click);
            // 
            // mntAbout
            // 
            this.mntAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntAboutSoftware,
            this.mntAboutAuthor,
            this.mntUpdateSoftware,
            this.mntFeedBack});
            this.mntAbout.Name = "mntAbout";
            this.mntAbout.Size = new System.Drawing.Size(70, 20);
            this.mntAbout.Text = "Giới thiệu";
            // 
            // mntAboutSoftware
            // 
            this.mntAboutSoftware.Name = "mntAboutSoftware";
            this.mntAboutSoftware.Size = new System.Drawing.Size(187, 22);
            this.mntAboutSoftware.Text = "Thông tin phần mềm";
            this.mntAboutSoftware.Click += new System.EventHandler(this.mntAboutSoftware_Click);
            // 
            // mntAboutAuthor
            // 
            this.mntAboutAuthor.Name = "mntAboutAuthor";
            this.mntAboutAuthor.Size = new System.Drawing.Size(187, 22);
            this.mntAboutAuthor.Text = "Thông tin tác giả";
            this.mntAboutAuthor.Click += new System.EventHandler(this.mntAboutAuthor_Click);
            // 
            // mntUpdateSoftware
            // 
            this.mntUpdateSoftware.Name = "mntUpdateSoftware";
            this.mntUpdateSoftware.Size = new System.Drawing.Size(187, 22);
            this.mntUpdateSoftware.Text = "Cập nhật phần mềm";
            this.mntUpdateSoftware.Click += new System.EventHandler(this.mntUpdateSoftware_Click);
            // 
            // mntFeedBack
            // 
            this.mntFeedBack.Name = "mntFeedBack";
            this.mntFeedBack.Size = new System.Drawing.Size(187, 22);
            this.mntFeedBack.Text = "Báo lỗi hệ thống";
            this.mntFeedBack.Click += new System.EventHandler(this.mntFeedBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 509);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(687, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 503);
            this.panel3.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.tbTotalPrice);
            this.panel6.Controls.Add(this.btnPay);
            this.panel6.Controls.Add(this.btnDiscount);
            this.panel6.Controls.Add(this.nmDiscount);
            this.panel6.Location = new System.Drawing.Point(3, 444);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(498, 59);
            this.panel6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tổng tiền";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPrice.Location = new System.Drawing.Point(111, 13);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(142, 31);
            this.tbTotalPrice.TabIndex = 10;
            this.tbTotalPrice.Text = "0";
            this.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(367, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(128, 53);
            this.btnPay.TabIndex = 9;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Location = new System.Drawing.Point(259, 4);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(102, 27);
            this.btnDiscount.TabIndex = 6;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(259, 33);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(102, 20);
            this.nmDiscount.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lvBill);
            this.panel5.Location = new System.Drawing.Point(3, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(498, 382);
            this.panel5.TabIndex = 6;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBill.GridLines = true;
            this.lvBill.Location = new System.Drawing.Point(3, 3);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(495, 375);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 198;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 105;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.nmNumOfFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbCategoryFood);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 54);
            this.panel4.TabIndex = 5;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 29);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(297, 21);
            this.cbFood.TabIndex = 3;
            // 
            // nmNumOfFood
            // 
            this.nmNumOfFood.Location = new System.Drawing.Point(306, 30);
            this.nmNumOfFood.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNumOfFood.Name = "nmNumOfFood";
            this.nmNumOfFood.Size = new System.Drawing.Size(55, 20);
            this.nmNumOfFood.TabIndex = 2;
            this.nmNumOfFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(367, 3);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(128, 48);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbCategoryFood
            // 
            this.cbCategoryFood.FormattingEnabled = true;
            this.cbCategoryFood.Location = new System.Drawing.Point(3, 3);
            this.cbCategoryFood.Name = "cbCategoryFood";
            this.cbCategoryFood.Size = new System.Drawing.Size(358, 21);
            this.cbCategoryFood.TabIndex = 0;
            this.cbCategoryFood.SelectedIndexChanged += new System.EventHandler(this.cbCategoryFoodName_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flpTable);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 503);
            this.panel2.TabIndex = 3;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(3, 6);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(672, 491);
            this.flpTable.TabIndex = 0;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmNumOfFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mntAdmin;
        private System.Windows.Forms.ToolStripMenuItem mntAccInfo;
        private System.Windows.Forms.ToolStripMenuItem mntAbout;
        private System.Windows.Forms.ToolStripMenuItem mntAboutSoftware;
        private System.Windows.Forms.ToolStripMenuItem mntAboutAuthor;
        private System.Windows.Forms.ToolStripMenuItem mntUpdateSoftware;
        private System.Windows.Forms.ToolStripMenuItem mntFeedBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbCategoryFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmNumOfFood;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Label label1;
    }
}