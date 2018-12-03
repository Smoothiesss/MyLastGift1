using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLastGift
{
    public partial class Admin : UserControl
    {
        public Admin()
        {
            InitializeComponent();
            userManagement1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userManagement1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            reportTab1.BringToFront();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            setPrice1.BringToFront();
        }
    }
}
