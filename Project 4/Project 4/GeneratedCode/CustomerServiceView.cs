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
    public partial class CustomerServiceView : Form
    {
        private EventHandler eventHandler;
        private ReturnScreen output;

        public CustomerServiceView(EventHandler h, ReturnScreen o)
        {
            eventHandler = h;
            output = o;
            InitializeComponent();
        }

        private void uxReturnButton_Click(object sender, EventArgs e)
        {
            uxReturnedItemsOutput.Text = output.update();
        }

        private void uxFinishReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
