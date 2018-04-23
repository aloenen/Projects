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
        }

        /// <summary>
        /// Runs when user wants to add an item to return
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxReturnButton_Click(object sender, EventArgs e)
        {
            returnHandler("", 0);
        }

        /// <summary>
        /// Completes the return transaction and resets the customer service view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFinishReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
