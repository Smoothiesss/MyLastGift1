using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace MyLastGift
{
    public partial class currentStatus : UserControl
    {
        public currentStatus()
        {
            InitializeComponent();
            XYDiagram diagram = (XYDiagram)chartOccupied.Diagram;
            diagram.EnableAxisXScrolling = true;
            
        }

        private void chartOccupied_Click(object sender, EventArgs e)
        {
            
        }

        private void chartOccupied_Click_1(object sender, EventArgs e)
        {

        }

        public bool EnableAxisXScrolling { get; set; }
    }
}
