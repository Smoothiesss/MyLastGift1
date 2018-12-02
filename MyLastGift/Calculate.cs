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
    public partial class Calculate : UserControl
    {
        public Calculate()
        {
            InitializeComponent();
            textBox1.Size = new Size(150, button2.Height);
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - 1).ToString();
        }
    }
}
