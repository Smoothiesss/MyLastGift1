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
    public partial class newEditGuest : UserControl
    {
        public newEditGuest()
        {
            InitializeComponent();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newBooking booking = null;
            foreach (Control c in this.Parent.Controls)
            {
                booking = c as newBooking;
                if (booking != null)
                {
                    break;
                }
            }

            if (booking != null)
            {
                booking.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = guestNameTextBox.Text;
            string id = textBox1.Text;
            string booking;
        }
    }
}
