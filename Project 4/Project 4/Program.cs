using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public delegate void TransactionHandler(Object sender, EventArgs e);
    public delegate void ReturnHandler(Object sender, EventArgs e);
    public delegate void RebateHandler(Object sender, EventArgs e);
    public delegate void Observer();

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up model
            ModelI dataBase = new Database();

            // Set up controllers
            SalesManager transactionHandler = new SalesManager(dataBase);
            ReturnsManager returnHandler = new ReturnsManager(dataBase);
            RebateManager enterRebateHandler = new RebateManager(dataBase);

            // Set up output 
            TransactionScreen transactionScreen = new TransactionScreen();
            ReturnScreen returnScreen = new ReturnScreen();
            RebateScreen rebateScreen = new RebateScreen();
            GenScreen genScreen = new GenScreen();

            // Set up input views
            GeneratedCode.CashierView cashierView = new GeneratedCode.CashierView(transactionHandler.createTransaction);
            GeneratedCode.CustomerServiceView customerView = new GeneratedCode.CustomerServiceView(returnHandler.returnItem);
            GeneratedCode.RebateView rebateView = new GeneratedCode.RebateView(enterRebateHandler.enterRebate, enterRebateHandler.genRebate);

            // Add observers
            transactionHandler.register(transactionScreen.update);
            returnHandler.register(returnScreen.update);
            enterRebateHandler.register(rebateScreen.update, genScreen.update);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(cashierView);
        }
    }
}
