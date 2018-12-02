using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace MyLastGift
{
    public delegate void MyEventHandler(object src, overview1 o);
    public partial class LeftView : UserControl
    {
        public event MyEventHandler handler;
        
        public LeftView()
        {
            InitializeComponent();
        }

        private void cbStandard_CheckedChanged(object sender, EventArgs e)
        {
            /*List<roomIcon> icon = overview1.Ri;

            if(cbStandard.Checked == false)
            {
                icon.Visible = false;
                if(icon.mainLabel.Text == "STANDARD")
                {
                    icon.Visible = false;
                }
                else
                {
                    icon.Visible = true;
                }
            }*/
            
        }
    }
}
