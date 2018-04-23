using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    // Declare delagates
    //public delegate void TransactionHandler();
    //public delegate void RetunHandler();
    //public delegate void EnterRebateHandler();
    //public delegate void GenRebateHandler(int id);
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
            Database dataBase = new Database();
            ModelI controllerModel = dataBase;
            Database viewModel = dataBase;

            // Set up controllers
            SalesManager transactionController = new SalesManager(controllerModel);
            ReturnsManager returnController = new ReturnsManager(controllerModel);
            RebateManager rebateController = new RebateManager(controllerModel);

            // Set up output 
            GeneratedCode.CashierOutputView cashierOutput = new GeneratedCode.CashierOutputView(dataBase);
            GeneratedCode.CustomerServiceOutputView returnsOutput = new GeneratedCode.CustomerServiceOutputView(dataBase);
            GeneratedCode.RebateOutputView rebateOutput = new GeneratedCode.RebateOutputView(dataBase);
            GeneratedCode.uxForm genRebateOutput = new GeneratedCode.uxForm(dataBase);

            // Set up input views
            GeneratedCode.CashierInputView cashierView = new GeneratedCode.CashierInputView(transactionController.transHandler);
            GeneratedCode.CustomerServiceInputView customerView = new GeneratedCode.CustomerServiceInputView(returnController.returnItem);
            GeneratedCode.RebateInputView rebateView = new GeneratedCode.RebateInputView(rebateController.enterRebate);
            GeneratedCode.GenerateRebateInputView genRebateView = new GeneratedCode.GenerateRebateInputView(rebateController.genRebate);

            // Add observers
            transactionController.register(cashierOutput.run);
            returnController.register(returnsOutput.run);
            rebateController.register(rebateOutput.run, genRebateOutput.run);

            // Set up and run application
            Application.EnableVisualStyles();
            Application.Run(genRebateView);
        }
    }
}
