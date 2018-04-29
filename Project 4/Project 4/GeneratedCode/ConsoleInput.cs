using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4.GeneratedCode
{
    class ConsoleInput
    {
        private SalesManager.TransactionHandler transHandler;
        private SalesManager.ItemHandler itemHandler;
        private SalesManager.EndTransactionHandler endTransaction;
        private int id = 1;

        public ConsoleInput(SalesManager.TransactionHandler h, SalesManager.ItemHandler i, SalesManager.EndTransactionHandler e)
        {
            transHandler = h;
            itemHandler = i;
            endTransaction = e;
        }
        public void run()
        {
            while (true)
            {
                Console.WriteLine("New transaction (enter)");
                Console.ReadLine();
                transHandler(id);
                id++;
                bool transaction = true;
                while (transaction)
                {
                    Console.WriteLine("Enter an (i)tem or (e)nd transaction: ");
                    string input = Console.ReadLine();
                    if(input == "i" || input == "I")
                    {
                        Console.WriteLine("Item Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Price: ");
                        float price = float.Parse(Console.ReadLine());
                        Console.WriteLine("Qty: ");
                        int qty = int.Parse(Console.ReadLine());
                        itemHandler(qty, price, name);
                    }
                    else if (input == "e" || input == "E")
                    {
                        endTransaction();
                        transaction = false;
                    }
                }
            }

        }

    }
}
