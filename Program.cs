using System;
using System.Windows.Forms;

namespace Sanding_Win_Form_POS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Cashier_Login login = new Cashier_Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Form1 mainForm = new Form1(login.CashierName, login.CashierID);
                Application.Run(mainForm);
            }
        }
    }
}