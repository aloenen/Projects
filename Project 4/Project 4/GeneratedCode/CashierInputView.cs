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
    public partial class CashierInputView : Form
    {
        private SalesManager.TransactionHandler transHandler;

        public CashierInputView(SalesManager.TransactionHandler h)
        {
            transHandler = h;
            InitializeComponent();
        }

        private void uxNewTransaction_Click(object sender, EventArgs e)
        {
            transHandler(2);
        }

        private void uxFinishTransaction_Click(object sender, EventArgs e)
        {

        }

        private void uxAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
