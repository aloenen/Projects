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
    public partial class RebateView : Form
    {
        private GenRebateHandler genRebateHandle;
        private EnterRebateHandler enterRebateHandle;

        public RebateView(EnterRebateHandler r, GenRebateHandler g)
        {
            enterRebateHandle = r;
            genRebateHandle = g;
            InitializeComponent();
        }

        private void uxEnterRebateButton_Click(object sender, EventArgs e)
        {
            enterRebateHandle(); 
        }

        private void uxGenerateRebateButton_Click(object sender, EventArgs e)
        {
            genRebateHandle();
        }
    }
}
