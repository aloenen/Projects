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
    public partial class CustomerServiceInputView : Form
    {
        private ReturnsManager.ReturnHandler returnHandler;

        public CustomerServiceInputView(ReturnsManager.ReturnHandler h)
        {
            returnHandler = h;
            InitializeComponent();
            uxAddReturnButton.Enabled = false;

        }

        /// <summary>
        /// Runs when user wants to add an item to return
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReturnButton_Click(object sender, EventArgs e)
        {
            string message = "0 items returned.";
            while (uxQuantity.Value > 0)
            {
                message = returnHandler(uxItemName.Text, (int)uxTransactionNum.Value);
            }
            MessageBox.Show(message);
        }

     

        private void uxTransactionNum_ValueChanged(object sender, EventArgs e)
        {
            uxAddReturnButton.Enabled = true;

        }

        /// <summary>
        /// Completes the return transaction and resets the customer service view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFinishReturn_Click_1(object sender, EventArgs e)
        {
            uxTransactionNum.Value = 0;
            uxAddReturnButton.Enabled = false;

        }
    }
}
