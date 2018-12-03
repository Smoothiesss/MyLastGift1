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
    public partial class setPrice : UserControl
    {
        public setPrice()
        {
            InitializeComponent();
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            var info = listView1.HitTest(e.X, e.Y);
            var row = info.Item.Index;
            var col = info.Item.SubItems.IndexOf(info.SubItem);
            var value = info.Item.SubItems[col].Text;
            MessageBox.Show(string.Format("R{0}:C{1} val '{2}'", row, col, value));
        }
    }
}
