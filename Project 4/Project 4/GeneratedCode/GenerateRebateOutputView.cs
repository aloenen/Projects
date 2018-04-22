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
    public partial class GenerateRebateOutputView : Form
    {
        public delegate void Observer();
        public Observer run;

        public GenerateRebateOutputView(Database d)
        {
            InitializeComponent();
            run = new Observer(update);
        }

        public void update()
        {

        }
    }
}
