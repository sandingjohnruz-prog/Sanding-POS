using System;
using System.Data;
using System.Windows.Forms;

namespace Sanding_Win_Form_POS
{
    public partial class Inventory : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public Inventory()
        {
            InitializeComponent();
            LoadInventory();
        }

        private void LoadInventory(string search = "")
        {
            lvInventory.Items.Clear();
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
                lvInventory.Items.Add(item);
            }
        }

        private void lvInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvInventory.SelectedItems.Count > 0)
                TxtSelectionItm.Text = lvInventory.SelectedItems[0].SubItems[0].Text
                    + " - " + lvInventory.SelectedItems[0].SubItems[1].Text;
        }

        private void btnInvSearch_Click(object sender, EventArgs e)
        {
            LoadInventory(TxtInvSearch.Text.Trim());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            TxtInvSearch.Clear();
            LoadInventory();
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (lvInventory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to restock.");
                return;
            }
            if (!int.TryParse(TxtRestockQTY.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid restock quantity.");
                return;
            }

            string code = lvInventory.SelectedItems[0].SubItems[0].Text;
            string query = "UPDATE Products SET Stock = Stock + @qty WHERE ProductCode = @code";
            var parameters = new Microsoft.Data.SqlClient.SqlParameter[]
            {
                new Microsoft.Data.SqlClient.SqlParameter("@qty", qty),
                new Microsoft.Data.SqlClient.SqlParameter("@code", code)
            };
            db.ExecuteNonQuery(query, parameters);
            MessageBox.Show($"Restocked! Added {qty} units to {lvInventory.SelectedItems[0].SubItems[1].Text}.");
            LoadInventory();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}