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

namespace MyLastGift
{
    public partial class editGuestInfo : UserControl
    {
        public editGuestInfo()
        {
            InitializeComponent();
         
        }

        public void setEditGuestInfo(string guestName, int guestID, string bookingTypeID, string nation,  string guestInfo)
        {
            setGuestID(guestID);
            setGuestName(guestName);
            setGuestNation(nation);
           
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BookingInformation bookingInfo = null;
            foreach (Control c in this.Parent.Controls)
            {
                bookingInfo = c as BookingInformation;
                if (bookingInfo != null)
                {
                    break;
                }
            }

            if (bookingInfo != null)
            {
                bookingInfo.Visible = true;
            }
        }

        public void setGuestID(int guestID)
        {
            this.guestIdTextBox.Text = guestID.ToString();
        }

        public void setGuestName(String guestName)
        {
            this.guestNameTextBox.Text = guestName;
        }




        public void setGuestNation(String nation)
        {
            this.nationTextBox.Text = nation;
        }

       
    }
}
