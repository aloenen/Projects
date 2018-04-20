using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public delegate void EventHandler(Object sender, EventArgs e);
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up controllers
            TransactionHandler transactionHandler = new SalesManager();
            RetunHandler returnHandler = new ReturnsManager();
            EnterRebateHandler enterRebateHandler = new RebateManager();
            GenRebateHandler genRebateHandler = new RebateManager();
            
            // Set up output 
            TransactionScreen transactionScreen = new TransactionScreen();
            ReturnScreen returnScreen = new ReturnScreen();
            RebateScreen rebateScreen = new RebateScreen();
            GenScreen genScreen = new GenScreen();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new GeneratedCode.CashierView(transactionHandler.createTransaction, transactionScreen));
        }
    }
}
