using System;
using System.Data;
using System.Windows.Forms;

namespace Sanding_Win_Form_POS
{
    public partial class Form1 : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        decimal totalAmount = 0;

        public Form1()
        {
            InitializeComponent();
            LoadProducts();
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
                TxtItemCode.Text = Catalog.SelectedItems[0].SubItems[0].Text;
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

            MessageBox.Show($"Checkout successful!\nChange: ₱{Convert.ToDecimal(txtChange.Text.Replace("₱", "")).ToString("F2")}");
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
            txtDiscount.Text = "20";
        }

        private void btnPWD_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "20";
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "10";
        }

        private void btnNoDisc_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = "0";
        }

        private void TxtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string code = TxtItemCode.Text.Trim();
                foreach (ListViewItem item in Catalog.Items)
                {
                    if (item.SubItems[0].Text == code)
                    {
                        item.Selected = true;
                        item.EnsureVisible();
                        Catalog.Focus();
                        return;
                    }
                }
                MessageBox.Show("Item not found!");
            }
        }
    }
}