using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    // Declare delagates
    public delegate void TransactionHandler();
    public delegate void RetunHandler();
    public delegate void EnterRebateHandler();
    public delegate void GenRebateHandler();
    public delegate string Observer();

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
            SalesManager transactionController = new SalesManager(dataBase);
            ReturnsManager returnController = new ReturnsManager(dataBase);
            RebateManager rebateController = new RebateManager(dataBase);

            // Set up output 
            TransactionScreen transactionScreen = new TransactionScreen();
            ReturnScreen returnScreen = new ReturnScreen();
            RebateScreen rebateScreen = new RebateScreen();
            GenScreen genScreen = new GenScreen();

            // Set up input views
            GeneratedCode.CashierView cashierView = new GeneratedCode.CashierView(transactionController.createTransaction);
            GeneratedCode.CustomerServiceView customerView = new GeneratedCode.CustomerServiceView(returnController.returnItem);
            GeneratedCode.RebateView rebateView = new GeneratedCode.RebateView(rebateController.enterRebate, rebateController.genRebate);

            // Add observers
            transactionController.register(transactionScreen.update);
            returnController.register(returnScreen.update);
            rebateController.register(rebateScreen.update, genScreen.update);

            // Set up and run application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(cashierView);
        }
    }
}
