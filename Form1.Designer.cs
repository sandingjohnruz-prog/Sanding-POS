namespace Sanding_Win_Form_POS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuickAdd = new System.Windows.Forms.Button();
            this.txtQuickQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtItemCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Catalog = new System.Windows.Forms.ListView();
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rghtpnl = new System.Windows.Forms.Panel();
            this.btnNoDisc = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnpwd = new System.Windows.Forms.Button();
            this.btnSenior = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGrandTtl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTvAT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalQTY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClrAll = new System.Windows.Forms.Button();
            this.BtnRmvOrder = new System.Windows.Forms.Button();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            this.TxTQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.rghtpnl.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnQuickAdd);
            this.panel1.Controls.Add(this.txtQuickQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtItemCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Catalog);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 640);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnQuickAdd
            // 
            this.btnQuickAdd.Location = new System.Drawing.Point(287, 579);
            this.btnQuickAdd.Name = "btnQuickAdd";
            this.btnQuickAdd.Size = new System.Drawing.Size(80, 25);
            this.btnQuickAdd.TabIndex = 9;
            this.btnQuickAdd.Text = "Quick Add";
            this.btnQuickAdd.UseVisualStyleBackColor = true;
            this.btnQuickAdd.Click += new System.EventHandler(this.btnQuickAdd_Click);
            // 
            // txtQuickQty
            // 
            this.txtQuickQty.Location = new System.Drawing.Point(231, 581);
            this.txtQuickQty.Name = "txtQuickQty";
            this.txtQuickQty.Size = new System.Drawing.Size(50, 20);
            this.txtQuickQty.TabIndex = 8;
            this.txtQuickQty.Text = "1";
            this.txtQuickQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtItemCode_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "QTY";
            // 
            // TxtItemCode
            // 
            this.TxtItemCode.Location = new System.Drawing.Point(60, 582);
            this.TxtItemCode.Name = "TxtItemCode";
            this.TxtItemCode.Size = new System.Drawing.Size(120, 20);
            this.TxtItemCode.TabIndex = 6;
            this.TxtItemCode.TextChanged += new System.EventHandler(this.TxtItemCode_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code";
            // 
            // Catalog
            // 
            this.Catalog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Code,
            this.ItemName,
            this.Price,
            this.Stock});
            this.Catalog.FullRowSelect = true;
            this.Catalog.HideSelection = false;
            this.Catalog.Location = new System.Drawing.Point(10, 90);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(355, 480);
            this.Catalog.TabIndex = 4;
            this.Catalog.UseCompatibleStateImageBehavior = false;
            this.Catalog.View = System.Windows.Forms.View.Details;
            this.Catalog.SelectedIndexChanged += new System.EventHandler(this.Catalog_SelectedIndexChanged);
            // 
            // Code
            // 
            this.Code.Text = "Code";
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ItemName.Width = 135;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stock.Width = 100;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(276, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(70, 52);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(200, 20);
            this.TxtSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM CATALOG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rghtpnl
            // 
            this.rghtpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rghtpnl.Controls.Add(this.btnSwitch);
            this.rghtpnl.Controls.Add(this.btnNoDisc);
            this.rghtpnl.Controls.Add(this.btnStudent);
            this.rghtpnl.Controls.Add(this.btnpwd);
            this.rghtpnl.Controls.Add(this.btnSenior);
            this.rghtpnl.Controls.Add(this.btnInv);
            this.rghtpnl.Controls.Add(this.btnHistory);
            this.rghtpnl.Controls.Add(this.btnCheckout);
            this.rghtpnl.Controls.Add(this.txtChange);
            this.rghtpnl.Controls.Add(this.label14);
            this.rghtpnl.Controls.Add(this.txtCash);
            this.rghtpnl.Controls.Add(this.label13);
            this.rghtpnl.Controls.Add(this.txtGrandTtl);
            this.rghtpnl.Controls.Add(this.label12);
            this.rghtpnl.Controls.Add(this.txtDiscount);
            this.rghtpnl.Controls.Add(this.label11);
            this.rghtpnl.Controls.Add(this.TXTvAT);
            this.rghtpnl.Controls.Add(this.label10);
            this.rghtpnl.Controls.Add(this.txtTotalQTY);
            this.rghtpnl.Controls.Add(this.label9);
            this.rghtpnl.Controls.Add(this.txtAmount);
            this.rghtpnl.Controls.Add(this.label8);
            this.rghtpnl.Controls.Add(this.label7);
            this.rghtpnl.Controls.Add(this.panel4);
            this.rghtpnl.Location = new System.Drawing.Point(807, 0);
            this.rghtpnl.Name = "rghtpnl";
            this.rghtpnl.Size = new System.Drawing.Size(379, 640);
            this.rghtpnl.TabIndex = 1;
            // 
            // btnNoDisc
            // 
            this.btnNoDisc.Location = new System.Drawing.Point(271, 203);
            this.btnNoDisc.Name = "btnNoDisc";
            this.btnNoDisc.Size = new System.Drawing.Size(90, 25);
            this.btnNoDisc.TabIndex = 22;
            this.btnNoDisc.Text = "No Discount";
            this.btnNoDisc.UseVisualStyleBackColor = true;
            this.btnNoDisc.Click += new System.EventHandler(this.btnNoDisc_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(185, 203);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(80, 25);
            this.btnStudent.TabIndex = 21;
            this.btnStudent.Text = "Student 5%";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnpwd
            // 
            this.btnpwd.Location = new System.Drawing.Point(99, 203);
            this.btnpwd.Name = "btnpwd";
            this.btnpwd.Size = new System.Drawing.Size(80, 25);
            this.btnpwd.TabIndex = 20;
            this.btnpwd.Text = "PWD 20%";
            this.btnpwd.UseVisualStyleBackColor = true;
            this.btnpwd.Click += new System.EventHandler(this.btnPWD_Click);
            // 
            // btnSenior
            // 
            this.btnSenior.Location = new System.Drawing.Point(13, 203);
            this.btnSenior.Name = "btnSenior";
            this.btnSenior.Size = new System.Drawing.Size(80, 25);
            this.btnSenior.TabIndex = 19;
            this.btnSenior.Text = "Senior 30%";
            this.btnSenior.UseVisualStyleBackColor = true;
            this.btnSenior.Click += new System.EventHandler(this.btnSenior_Click);
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(200, 535);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(160, 35);
            this.btnInv.TabIndex = 18;
            this.btnInv.Text = "View Inventory";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(13, 535);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(160, 35);
            this.btnHistory.TabIndex = 17;
            this.btnHistory.Text = "View History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(10, 479);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(350, 50);
            this.btnCheckout.TabIndex = 16;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(160, 303);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(200, 20);
            this.txtChange.TabIndex = 15;
            this.txtChange.Text = "₱0.00";
            this.txtChange.Click += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(10, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Change";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(160, 277);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(200, 20);
            this.txtCash.TabIndex = 13;
            this.txtCash.Text = "0";
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(10, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Cash";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtGrandTtl
            // 
            this.txtGrandTtl.Location = new System.Drawing.Point(160, 251);
            this.txtGrandTtl.Name = "txtGrandTtl";
            this.txtGrandTtl.Size = new System.Drawing.Size(200, 20);
            this.txtGrandTtl.TabIndex = 11;
            this.txtGrandTtl.Text = "₱0.00";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Grand Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(160, 177);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDiscount.TabIndex = 9;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Discount (%)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TXTvAT
            // 
            this.TXTvAT.Location = new System.Drawing.Point(160, 137);
            this.TXTvAT.Name = "TXTvAT";
            this.TXTvAT.Size = new System.Drawing.Size(200, 20);
            this.TXTvAT.TabIndex = 7;
            this.TXTvAT.Text = "₱0.00";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(10, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "VAT (%12)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTotalQTY
            // 
            this.txtTotalQTY.Location = new System.Drawing.Point(160, 97);
            this.txtTotalQTY.Name = "txtTotalQTY";
            this.txtTotalQTY.Size = new System.Drawing.Size(200, 20);
            this.txtTotalQTY.TabIndex = 5;
            this.txtTotalQTY.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total QTY";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(160, 57);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "₱0.00";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Amount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "PURCHASE DETAILS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(820, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 460);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.btnClrAll);
            this.panel3.Controls.Add(this.BtnRmvOrder);
            this.panel3.Controls.Add(this.BtnAddOrder);
            this.panel3.Controls.Add(this.TxTQty);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(376, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 640);
            this.panel3.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(355, 480);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "QTY";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SubTotal";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 85;
            // 
            // btnClrAll
            // 
            this.btnClrAll.Location = new System.Drawing.Point(288, 49);
            this.btnClrAll.Name = "btnClrAll";
            this.btnClrAll.Size = new System.Drawing.Size(80, 25);
            this.btnClrAll.TabIndex = 5;
            this.btnClrAll.Text = "CLEAR";
            this.btnClrAll.UseVisualStyleBackColor = true;
            this.btnClrAll.Click += new System.EventHandler(this.btnClrAll_Click);
            // 
            // BtnRmvOrder
            // 
            this.BtnRmvOrder.Location = new System.Drawing.Point(202, 49);
            this.BtnRmvOrder.Name = "BtnRmvOrder";
            this.BtnRmvOrder.Size = new System.Drawing.Size(80, 25);
            this.BtnRmvOrder.TabIndex = 4;
            this.BtnRmvOrder.Text = "REMOVE";
            this.BtnRmvOrder.UseVisualStyleBackColor = true;
            this.BtnRmvOrder.Click += new System.EventHandler(this.BtnRmvOrder_Click);
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.Location = new System.Drawing.Point(116, 49);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(80, 25);
            this.BtnAddOrder.TabIndex = 3;
            this.BtnAddOrder.Text = "ADD";
            this.BtnAddOrder.UseVisualStyleBackColor = true;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // TxTQty
            // 
            this.TxTQty.Location = new System.Drawing.Point(50, 52);
            this.TxTQty.Name = "TxTQty";
            this.TxTQty.Size = new System.Drawing.Size(60, 20);
            this.TxTQty.TabIndex = 2;
            this.TxTQty.Text = "1";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "QTY";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "CURRENT ORDER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(289, 612);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(80, 25);
            this.btnSwitch.TabIndex = 23;
            this.btnSwitch.Text = "Switch User";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.rghtpnl);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "POS Only Pos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rghtpnl.ResumeLayout(false);
            this.rghtpnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel rghtpnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView Catalog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TxtItemCode;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAddOrder;
        private System.Windows.Forms.TextBox TxTQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnRmvOrder;
        private System.Windows.Forms.Button btnClrAll;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalQTY;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXTvAT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGrandTtl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnpwd;
        private System.Windows.Forms.Button btnSenior;
        private System.Windows.Forms.Button btnNoDisc;
        private System.Windows.Forms.Button btnQuickAdd;
        private System.Windows.Forms.TextBox txtQuickQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSwitch;
    }
}

