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
        private EventHandler genRebate;
        private EventHandler enterRebate;

        public RebateView(EventHandler r, EventHandler g)
        {
            enterRebate = r;
            genRebate = g;
            InitializeComponent();
        }

        private void uxEnterRebateButton_Click(object sender, EventArgs e)
        {
            enterRebate(sender, e); 
        }

        private void uxGenerateRebateButton_Click(object sender, EventArgs e)
        {
            genRebate(sender, e);
        }
    }
}
