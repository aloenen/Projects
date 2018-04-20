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
        private EventHandler eventHandler;
        private RebateScreen outputR;
        private GenScreen outputG;

        public RebateView(EventHandler e, RebateScreen r, GenScreen g)
        {
            eventHandler = e;
            outputR = r;
            outputG = g;
            InitializeComponent();
        }

        private void uxEnterRebateButton_Click(object sender, EventArgs e)
        {
            uxValidRebate.Text = outputR.update();
        }

        private void uxGenerateRebateButton_Click(object sender, EventArgs e)
        {
            uxRebateReciptOutput.Text = outputG.update();
        }
    }
}
