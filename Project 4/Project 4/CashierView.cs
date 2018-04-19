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
    public delegate void TransactionHandler(Object sender, EventArgs e);

    public partial class CashierView : Form
    {
        private EventHandler h;
        private TransactionScreen o;

        public CashierView(EventHandler h, TransactionScreen o)
        {
            this.h = h;
            this.o = o;
            InitializeComponent();
        }

        private void uxNewTransaction_Click(object sender, EventArgs e)
        {
            h(sender, e);
        }

        private void uxFinishTransaction_Click(object sender, EventArgs e)
        {

        }

        private void uxAddItem_Click(object sender, EventArgs e)
        {
            uxOutput.Text = o.ToString();
        }
    }
}
