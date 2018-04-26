using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4.GeneratedCode
{
    public partial class ReciptOutputView : Form
    {
        public delegate void Observer(int id, bool valid);
        public Observer run;

        private Database database;

        public ReciptOutputView(Database d)
        {
            InitializeComponent();
            run = new Observer(update);
            database = d;
        }

        public void update(int id, bool valid)
        {
            if (valid)
            {
                string i = "ID: " + id;
                string date = "Date: " + DateTime.Today.ToString();
                string items = "";
                Transaction transaction = database.getTransaction(id);
                foreach (Item item in transaction.Items.Values)
                {
                    if (item.Returned)
                        items += "**Returned** \nName: " + item.Name + "\nPrice: $" + item.Price + "\nQty: " + item.RAmount + "\n************";
                    else
                        items += "Name: " + item.Name + "\nPrice: $" + item.Price + "\nQty: " + (item.Amount - item.RAmount);
                }
                string total = "Total: $" + transaction.Total;
                MessageBox.Show(i + "\n" + date + "\n\n" + items + "\n\n" + total);
            }
            else
            {
                MessageBox.Show("Invalid transaction");
            }
        }
    }
}
