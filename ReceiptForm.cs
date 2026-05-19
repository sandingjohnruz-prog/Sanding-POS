using System;
using System.Windows.Forms;

namespace Sanding_Win_Form_POS
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(string receiptText)
        {
            InitializeComponent();
            rtxReceipt.Text = receiptText;
            rtxReceipt.SelectAll();
            rtxReceipt.SelectionAlignment = HorizontalAlignment.Center;
            rtxReceipt.DeselectAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewTrans_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}