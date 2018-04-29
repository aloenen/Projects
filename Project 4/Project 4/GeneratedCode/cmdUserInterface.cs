using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.GeneratedCode
{
    public class cmdUserInterface
    {
        /// <summary>
        /// The mainMenu method prints and simulates a menu selection screen directing to
        /// the desired screen following human input. 
        /// </summary>
        /// <returns>An integer value that tells the UserInterface which menu to call next</returns>
        public int mainMenu()
        {
            int response = 5;
            while (response > 4 || response < 0)//While loop to guarantee that the user enters a valid menu option
            {
                Console.WriteLine("\n-----------------------MAIN MENU-----------------------");
                Console.WriteLine(" 1 | Begin a sales transaction ");
                Console.WriteLine(" 2 | Return item(s) ");
                Console.WriteLine(" 3 | Submit a rebate ");
                Console.WriteLine(" 4 | Generate rebate checks ");
                Console.WriteLine(" 0 | Exit Program ");
                Console.WriteLine("\nPlease enter the # corresponding to the task you desire to complete: ");
                response = Convert.ToInt32(Console.ReadLine());
            }
            return response;
        }//End mainMenu
/*
        /// <summary>
        /// The saleScreen method is the entry point for a sale to begin. It allows interaction to
        /// add items to a sale. It then adds the sale to a database specifically for sales.
        /// </summary>
        public void saleScreen()
        {
            bool flag = true;
            string itemName;
            double itemPrice;
            int itemQuantity;
            int currentTransaction = headManager.newSale();

            while (flag)//While loop to allow the user to continue adding items to the sale until no longer desired
            {

                bool check = false;
                char response = 'X';

                Console.WriteLine("\nEnter the name of the item you are purchasing: ");
                itemName = Console.ReadLine();
                Console.WriteLine("Enter the price of this item: ");
                itemPrice = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                Console.WriteLine("Enter the quantity of this item: ");
                itemQuantity = Convert.ToInt32(Console.ReadLine());
                headManager.sendSale(currentTransaction, itemName, itemPrice, itemQuantity);

                while (check == false) //While loop to guarantee the user enters either 'Y' or 'N'
                {
                    Console.WriteLine("Do you wish to continue shopping? <Y>es or <N>o: ");
                    response = char.ToUpper(Console.ReadKey().KeyChar);
                    if (response.Equals('N') || response.Equals('Y'))
                    {
                        check = true;
                    }
                }

                if (response == 'N')
                {
                    break;
                }
            }//end While
            displayReceipt(headManager.getSale(currentTransaction));
            checkSale(headManager.doesSaleExist(currentTransaction));
        }//end saleScreen

        /// <summary>
        /// The returnScreen method allows the user to complete the required questions to remove items
        /// from a previous sale. It then modifies the sale to reflect the items that were returned.
        /// </summary>
        public void returnScreen()
        {
            bool flag = true;
            int transactionID = 0;
            while (!headManager.doesSaleExist(transactionID))//While loop to ensure they enter a valid Sale to modify
            {
                Console.WriteLine("\nPlease enter your Transaction ID to return an item: (Don't include # Symbol)");
                transactionID = Convert.ToInt32(Console.ReadLine());
                if (!headManager.doesSaleExist(transactionID))
                {
                    Console.WriteLine("Error | Invalid ID");
                }
            }

            if (!headManager.getSale(transactionID).rebateCheck())//Check to make sure the user hasn't attempted to return an item within a rebate
            {
                while (flag)//While loop to allow them to continue to return items until no longer desired
                {
                    bool check = false;
                    bool quantityCheck = false;
                    char response = 'X';

                    headManager.getSale(transactionID).display();
                    Console.WriteLine("Which item(s) would you like to return? (Use item #): ");
                    int itemNumber = Convert.ToInt32(Console.ReadLine());

                    while (!quantityCheck)
                    {
                        Console.WriteLine("How many would you like to return? ");
                        int returnQuantity = Convert.ToInt32(Console.ReadLine());
                        quantityCheck = headManager.getSale(transactionID).removeItem(itemNumber, returnQuantity);
                    }

                    headManager.getSale(transactionID).display();
                    while (check == false)//While loop to guarantee the user enters either 'Y' or 'N'
                    {
                        Console.WriteLine("Do you wish to return another item? <Y>es or <N>o: ");
                        response = char.ToUpper(Console.ReadKey().KeyChar);
                        if (response.Equals('N') || response.Equals('Y'))
                        {
                            check = true;
                        }
                    }

                    if (response == 'N')
                    {
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("\nINVALID | Returns are not allowed on transactions that have sent a rebate in...");
            }
        }//end returnScreen

        /// <summary>
        /// The rebateScreen method allows the user to create a rebate using a sale that was previously created.
        /// It then adds the rebate to a database specifically for rebates.
        /// </summary>
        public void rebateScreen()
        {
            int transactionID = 0;
            while (!headManager.doesSaleExist(transactionID))//While loop to verify they are creating a rebate on a valid sale
            {
                Console.WriteLine("\nPlease enter your Transaction ID to begin creating a rebate: (Not including # Symbol) ");
                transactionID = Convert.ToInt32(Console.ReadLine());
                if (!headManager.doesSaleExist(transactionID))
                {
                    Console.WriteLine("Error | Invalid ID");
                }
            }//end while


            Console.WriteLine("Transaction Found! | Please enter the following information: "); //User interaction to get information about the rebate
            Console.WriteLine("Enter your name: ");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter the current date (12/31/1999): ");
            int[] currentDate = parseDate(Console.ReadLine());
            Console.WriteLine("Enter your street address: ");
            string streetAddress = Console.ReadLine();
            Console.WriteLine("Enter your city name and state (City, State): ");
            string cityState = Console.ReadLine();
            Console.WriteLine("Enter your zip code: ");
            string zipCode = Console.ReadLine();
            string address = streetAddress + ", " + cityState + ", " + zipCode;

            headManager.newRebate(transactionID);   //Actual method calls to create and modify the rebate
            headManager.sendRebate(transactionID, customerName, currentDate, address);
            headManager.getSale(transactionID).changeStatus();
            checkRebate(headManager.doesRebateExist(transactionID));
        }//end rebateScreen

        /// <summary>
        /// The generateRebatesScreen method "processes" all rebates within the rebate database if they are valid
        /// </summary>
        public void generateRebatesScreen()
        {
            Console.WriteLine("Enter the current percent at which rebates are being given: (15% = 15) ");
            int rebatePercent = Convert.ToInt32(Console.ReadLine());
            headManager.generateRebates(rebatePercent);
        }//end generateRebatesScreen

        /// <summary>
        /// The displayReceipt is a simple method used to display the contents of a Sale to the Console.
        /// </summary>
        /// <param name="current">Sale object holding the current values desired to display</param>
        public void displayReceipt(Sale current)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("Transaction ID: #" + current.getID());
            Console.WriteLine("Transaction Date: June " + current.getDate() + ", 2018\n");
            current.display();
            Console.WriteLine("\nTotal cost: $" + current.totalCost());
        }//end displayReceipt

        /// <summary>
        /// The parseDate method takes a string in containing the date in "XX/XX/XXXX" form and converts it in
        /// an integer array containing the date in three separate pieces of digit value
        /// </summary>
        /// <param name="date">Inputted string from user containing the date in an unusable form</param>
        /// <returns>Integer array containing the date in 3 separate parts. [Month, Date, Year]</returns>
        public int[] parseDate(string date)
        {
            string[] dates = date.Split('/');
            int[] modDates = new int[3];
            modDates[0] = Convert.ToInt32(dates[0]);
            modDates[1] = Convert.ToInt32(dates[1]);
            modDates[2] = Convert.ToInt32(dates[2]);
            return modDates;
        }//end parseDate

        /// <summary>
        /// The checkSale method simply prints the success or failure of creation to the Console
        /// </summary>
        /// <param name="input">Boolean value containing whether the Sale was correctly created and
        /// added to the Sales database</param>
        public void checkSale(bool input)
        {
            if (input)
            {
                Console.WriteLine("\nSale successfully completed! | Have a nice day!");
            }
            else
            {
                Console.WriteLine("\nERROR!");
            }
        }//end checkSale

        /// <summary>
        /// The checkRebate method simply prints the success or failure of creation to the Console
        /// </summary>
        /// <param name="input">Boolean value containing whether the Rebate was correctly created and
        /// added to the Rebates database</param>
        public void checkRebate(bool input)
        {
            if (input)
            {
                Console.WriteLine("\n\nRebate successfully completed! | Have a nice day!");
            }
            else
            {
                Console.WriteLine("\nERROR!");
            }
        }//end checkRebate
        */
    }
}
