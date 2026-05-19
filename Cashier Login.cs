using System;
using System.Data;
using System.Windows.Forms;

namespace Sanding_Win_Form_POS
{
    public partial class Cashier_Login : Form
    {
        public string CashierName { get; private set; }
        public string CashierID { get; private set; }
        DatabaseHelper db = new DatabaseHelper();

        public Cashier_Login()
        {
            InitializeComponent();
        }

        private void btnLoginIn_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void txtCashierID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                DoLogin();
        }

        private void DoLogin()
        {
            string id = txtCashierID.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                lblError.Text = "Please enter your Cashier ID!";
                return;
            }

            string query = $"SELECT * FROM Users WHERE CashierID = '{id}' AND IsActive = 1";
            DataTable dt = db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                CashierName = dt.Rows[0]["CashierName"].ToString();
                CashierID = dt.Rows[0]["CashierID"].ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Text = "Invalid Cashier ID!";
                txtCashierID.Clear();
                txtCashierID.Focus();
            }
        }
    }
}