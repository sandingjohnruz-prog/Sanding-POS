using System;
using System.Data;
using System.Windows.Forms;

namespace Sanding_Win_Form_POS
{
    public partial class Form1 : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        decimal totalAmount = 0;

        private string cashierName;
        private string cashierID;

        public Form1(string name, string id)
        {
            InitializeComponent();
            cashierName = name;
            cashierID = id;
            this.Text = $"POS Only Pos - Cashier: {cashierName}";
            LoadProducts();
            ApplyTheme();
        }
        private void LoadProducts(string search = "")
        {
            Catalog.Items.Clear();
            string query = "SELECT ProductCode, ProductName, Price, Stock FROM Products";
            if (!string.IsNullOrEmpty(search))
                query += $" WHERE ProductCode LIKE '%{search}%' OR ProductName LIKE '%{search}%'";
            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["ProductCode"].ToString());
                item.SubItems.Add(row["ProductName"].ToString());
                item.SubItems.Add("₱" + Convert.ToDecimal(row["Price"]).ToString("F2"));
                item.SubItems.Add(row["Stock"].ToString());
                Catalog.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProducts(TxtSearch.Text.Trim());
        }

        private void Catalog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Catalog.SelectedItems.Count > 0)
            {
                TxtItemCode.Text = Catalog.SelectedItems[0].SubItems[0].Text;
                
            }
        }
        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            if (Catalog.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item from the catalog first.");
                return;
            }
            if (!int.TryParse(TxTQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }
            string code = Catalog.SelectedItems[0].SubItems[0].Text;
            string name = Catalog.SelectedItems[0].SubItems[1].Text;
            decimal price = Convert.ToDecimal(Catalog.SelectedItems[0].SubItems[2].Text.Replace("₱", ""));
            int stock = Convert.ToInt32(Catalog.SelectedItems[0].SubItems[3].Text);
            if (qty > stock)
            {
                MessageBox.Show($"Not enough stock! Only {stock} left.");
                return;
            }
            decimal subtotal = price * qty;
            ListViewItem item = new ListViewItem(code);
            item.SubItems.Add(name);
            item.SubItems.Add(qty.ToString());
            item.SubItems.Add("₱" + price.ToString("F2"));
            item.SubItems.Add("₱" + subtotal.ToString("F2"));
            listView1.Items.Add(item);
            UpdateTotals();
        }

        private void BtnRmvOrder_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].Remove();
                UpdateTotals();
            }
            else
                MessageBox.Show("Please select an item to remove.");
        }

        private void btnClrAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            decimal amount = 0;
            int totalQty = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                amount += Convert.ToDecimal(item.SubItems[4].Text.Replace("₱", ""));
                totalQty += Convert.ToInt32(item.SubItems[2].Text);
            }
            decimal vat = amount * 0.12m;
            decimal.TryParse(txtDiscount.Text, out decimal discountPercent);
            decimal discountAmount = amount * (discountPercent / 100);
            decimal grandTotal = amount + vat - discountAmount;
            txtAmount.Text = "₱" + amount.ToString("F2");
            txtTotalQTY.Text = totalQty.ToString();
            TXTvAT.Text = "₱" + vat.ToString("F2");
            txtGrandTtl.Text = "₱" + grandTotal.ToString("F2");
            totalAmount = grandTotal;
            ComputeChange();
        }

        private void ComputeChange()
        {
            decimal.TryParse(txtCash.Text, out decimal cash);
            decimal change = cash - totalAmount;
            txtChange.Text = "₱" + (change >= 0 ? change : 0).ToString("F2");
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            ComputeChange();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No items in order!");
                return;
            }
            decimal.TryParse(txtCash.Text, out decimal cash);
            if (cash < totalAmount)
            {
                MessageBox.Show("Cash is not enough!");
                return;
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string code = item.SubItems[0].Text;
                string name = item.SubItems[1].Text;
                int qty = Convert.ToInt32(item.SubItems[2].Text);
                decimal price = Convert.ToDecimal(item.SubItems[3].Text.Replace("₱", ""));
                decimal subtotal = Convert.ToDecimal(item.SubItems[4].Text.Replace("₱", ""));
                decimal vat = Convert.ToDecimal(TXTvAT.Text.Replace("₱", ""));
                decimal discount = Convert.ToDecimal(txtDiscount.Text == "" ? "0" : txtDiscount.Text);

                string query = @"INSERT INTO Transactions 
                    (ProductCode, ProductName, Quantity, Price, Subtotal, VAT, Discount, GrandTotal, TransactionDate)
                    VALUES (@code, @name, @qty, @price, @subtotal, @vat, @discount, @grandTotal, @date)";

                var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
                {
                    new Microsoft.Data.SqlClient.SqlParameter("@code", code),
                    new Microsoft.Data.SqlClient.SqlParameter("@name", name),
                    new Microsoft.Data.SqlClient.SqlParameter("@qty", qty),
                    new Microsoft.Data.SqlClient.SqlParameter("@price", price),
                    new Microsoft.Data.SqlClient.SqlParameter("@subtotal", subtotal),
                    new Microsoft.Data.SqlClient.SqlParameter("@vat", vat),
                    new Microsoft.Data.SqlClient.SqlParameter("@discount", discount),
                    new Microsoft.Data.SqlClient.SqlParameter("@grandTotal", totalAmount),
                    new Microsoft.Data.SqlClient.SqlParameter("@date", DateTime.Now)
                };
                db.ExecuteNonQuery(query, parameters);

                string updateStock = "UPDATE Products SET Stock = Stock - @qty WHERE ProductCode = @code";
                var stockParams = new Microsoft.Data.SqlClient.SqlParameter[]
                {
                    new Microsoft.Data.SqlClient.SqlParameter("@qty", qty),
                    new Microsoft.Data.SqlClient.SqlParameter("@code", code)
                };
                db.ExecuteNonQuery(updateStock, stockParams);
            }

            string receipt = "";
            receipt += "==================================================\n";
            receipt += "POS ONLY POS           \n";
            receipt += "==================================================\n";
            receipt += $"   Date: {DateTime.Now:MM/dd/yyyy hh:mm tt}\n\n";

            foreach (ListViewItem item in listView1.Items)
            {
                string rCode = item.SubItems[0].Text;
                string rName = item.SubItems[1].Text;
                string rQty = item.SubItems[2].Text;
                string rPrice = item.SubItems[4].Text;
                receipt += $"{rCode,-8}{rName,-18}{rQty,4}{rPrice,8}\n";
            }

            receipt += "--------------------------------\n";
            receipt += $"{"Amount:",-20}{txtAmount.Text,12}\n";
            receipt += $"{"VAT (12%):",-20}{TXTvAT.Text,12}\n";
            receipt += $"{"Discount:",-20}{txtDiscount.Text + "%",12}\n";
            receipt += $"{"Grand Total:",-20}{txtGrandTtl.Text,12}\n";
            receipt += $"{"Cash:",-20}{"₱" + txtCash.Text,12}\n";
            receipt += $"{"Change:",-20}{txtChange.Text,12}\n";
            receipt += "==================================================\n";
            receipt += "   Thank you! Come again!\n";
            receipt += "==================================================\n";

            ReceiptForm rf = new ReceiptForm(receipt);
            rf.ShowDialog();
            listView1.Items.Clear();
            txtCash.Text = "0";
            txtDiscount.Text = "0";
            UpdateTotals();
            LoadProducts();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }

        private void btnInv_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.ShowDialog();
            LoadProducts();
        }

        private void TxtItemCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void btnSenior_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "30";
        }

        private void btnPWD_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "20";
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "5";
        }

        private void btnNoDisc_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "0";
        }

        private void TxtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                QuickAdd();
            }
        }

        private void btnQuickAdd_Click(object sender, EventArgs e)
        {
            QuickAdd();
        }

        private void QuickAdd()
        {
            string code = TxtItemCode.Text.Trim();
            if (string.IsNullOrEmpty(code))
            {
                MessageBox.Show("Please enter an item code.");
                return;
            }

            if (!int.TryParse(txtQuickQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Find item in catalog
            ListViewItem foundItem = null;
            foreach (ListViewItem item in Catalog.Items)
            {
                if (item.SubItems[0].Text == code)
                {
                    foundItem = item;
                    break;
                }
            }

            if (foundItem == null)
            {
                MessageBox.Show("Item not found!");
                return;
            }

            string name = foundItem.SubItems[1].Text;
            decimal price = Convert.ToDecimal(foundItem.SubItems[2].Text.Replace("₱", ""));
            int stock = Convert.ToInt32(foundItem.SubItems[3].Text);

            if (qty > stock)
            {
                MessageBox.Show($"Not enough stock! Only {stock} left.");
                return;
            }

            decimal subtotal = price * qty;

            // Add to order list
            ListViewItem orderItem = new ListViewItem(code);
            orderItem.SubItems.Add(name);
            orderItem.SubItems.Add(qty.ToString());
            orderItem.SubItems.Add("₱" + price.ToString("F2"));
            orderItem.SubItems.Add("₱" + subtotal.ToString("F2"));
            listView1.Items.Add(orderItem);

            // Update totals
            UpdateTotals();

            // Clear inputs
            TxtItemCode.Clear();
            txtQuickQty.Text = "1";
            TxtItemCode.Focus();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm hist = new HistoryForm();
            hist.ShowDialog();
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            Cashier_Login login = new Cashier_Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                cashierName = login.CashierName;
                cashierID = login.CashierID;
                this.Text = $"POS Only Pos - Cashier: {cashierName}";
            }

        }

        private void ApplyTheme()
        {
            // Form background
            this.BackColor = System.Drawing.Color.White;

            // LEFT PANEL
            panel1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // Header labels - Orange
            label1.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);

            label2.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);

            // MIDDLE PANEL
            panel3.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // RIGHT PANEL
            rghtpnl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // Purchase Details header
            label7.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);

            // Search button - Green
            btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 166, 81);
            btnSearch.ForeColor = System.Drawing.Color.White;
            btnSearch.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // ADD button - Green
            BtnAddOrder.BackColor = System.Drawing.Color.FromArgb(0, 166, 81);
            BtnAddOrder.ForeColor = System.Drawing.Color.White;
            BtnAddOrder.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            BtnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // REMOVE button - Orange
            BtnRmvOrder.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            BtnRmvOrder.ForeColor = System.Drawing.Color.White;
            BtnRmvOrder.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            BtnRmvOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // CLEAR button - Orange
            btnClrAll.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            btnClrAll.ForeColor = System.Drawing.Color.White;
            btnClrAll.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            btnClrAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // CHECKOUT button - Red
            btnCheckout.BackColor = System.Drawing.Color.FromArgb(220, 50, 50);
            btnCheckout.ForeColor = System.Drawing.Color.White;
            btnCheckout.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Quick Add button - Green
            btnQuickAdd.BackColor = System.Drawing.Color.FromArgb(0, 166, 81);
            btnQuickAdd.ForeColor = System.Drawing.Color.White;
            btnQuickAdd.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            btnQuickAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Discount buttons
            btnSenior.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            btnSenior.ForeColor = System.Drawing.Color.White;
            btnSenior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            btnpwd.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            btnpwd.ForeColor = System.Drawing.Color.White;
            btnpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            btnStudent.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            btnStudent.ForeColor = System.Drawing.Color.White;
            btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            btnNoDisc.BackColor = System.Drawing.Color.FromArgb(150, 150, 150);
            btnNoDisc.ForeColor = System.Drawing.Color.White;
            btnNoDisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // View History - Green
            btnHistory.BackColor = System.Drawing.Color.FromArgb(0, 166, 81);
            btnHistory.ForeColor = System.Drawing.Color.White;
            btnHistory.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // View Inventory - Green
            btnInv.BackColor = System.Drawing.Color.FromArgb(0, 166, 81);
            btnInv.ForeColor = System.Drawing.Color.White;
            btnInv.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            btnInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Switch User - Orange
            btnSwitch.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            btnSwitch.ForeColor = System.Drawing.Color.White;
            btnSwitch.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);
            btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // ListViews
            Catalog.BackColor = System.Drawing.Color.White;
            listView1.BackColor = System.Drawing.Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
        }
    
