using System;
using System.Data;
using System.Windows.Forms;

namespace Sanding_Win_Form_POS
{
    public partial class HistoryForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public HistoryForm()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void LoadHistory(string search = "")
        {
            lvHistory.Items.Clear();
            string query = @"SELECT TransactionDate, ProductCode, ProductName, 
                            Quantity, Price, Subtotal, VAT, Discount, GrandTotal 
                            FROM Transactions";

            if (!string.IsNullOrEmpty(search))
                query += $" WHERE ProductCode LIKE '%{search}%' OR ProductName LIKE '%{search}%'";

            query += " ORDER BY TransactionDate DESC";

            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(Convert.ToDateTime(row["TransactionDate"]).ToString("MM/dd/yyyy hh:mm tt"));
                item.SubItems.Add(row["ProductCode"].ToString());
                item.SubItems.Add(row["ProductName"].ToString());
                item.SubItems.Add(row["Quantity"].ToString());
                item.SubItems.Add("₱" + Convert.ToDecimal(row["Price"]).ToString("F2"));
                item.SubItems.Add("₱" + Convert.ToDecimal(row["Subtotal"]).ToString("F2"));
                item.SubItems.Add("₱" + Convert.ToDecimal(row["VAT"]).ToString("F2"));
                item.SubItems.Add(row["Discount"].ToString() + "%");
                item.SubItems.Add("₱" + Convert.ToDecimal(row["GrandTotal"]).ToString("F2"));
                lvHistory.Items.Add(item);
            }
        }

        private void btnHistSearch_Click(object sender, EventArgs e)
        {
            LoadHistory(txtHistSearch.Text.Trim());
        }

        private void btnShowAllHist_Click(object sender, EventArgs e)
        {
            txtHistSearch.Clear();
            LoadHistory();
        }

        private void btnCloseHist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}