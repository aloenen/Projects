using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public delegate void EventHandler(object sender, EventArgs e);
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SalesManager salesManager = new SalesManager();
            TransactionScreen transactionScreen = new TransactionScreen();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CashierView(salesManager.createTransaction(), transactionScreen));
        }
    }
}
