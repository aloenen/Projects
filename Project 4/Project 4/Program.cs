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
    //public delegate void Observer();

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up model
            ModelI dataBaseC = new Database();
            Database dataBaseV = new Database();

            // Set up controllers
            SalesManager transactionController = new SalesManager(dataBaseC);
            ReturnsManager returnController = new ReturnsManager(dataBaseC);
            RebateManager rebateController = new RebateManager(dataBaseC);

            // Set up output 
            GeneratedCode.CashierOutputView cashierOutput = new GeneratedCode.CashierOutputView(dataBaseV);
            GeneratedCode.CustomerServiceOutputView returnsOutput = new GeneratedCode.CustomerServiceOutputView();
            GeneratedCode.RebateOutputView rebateOutput = new GeneratedCode.RebateOutputView();
            GeneratedCode.RebateCheckOutputView checkOutput = new GeneratedCode.RebateCheckOutputView();

            // Set up input views
            GeneratedCode.CashierView cashierView = new GeneratedCode.CashierView(transactionController.createTransaction);
            GeneratedCode.CustomerServiceView customerView = new GeneratedCode.CustomerServiceView(returnController.returnItem);
            GeneratedCode.RebateView rebateView = new GeneratedCode.RebateView(rebateController.enterRebate, rebateController.genRebate);

            // Add observers
            transactionController.register(cashierOutput.run);
            returnController.register(returnsOutput.run);
            rebateController.register(rebateOutput.run, checkOutput.run);

            // Set up and run application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(cashierView);
        }
    }
}
