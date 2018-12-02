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
    public partial class roomIcon : UserControl
    {

        public roomIcon()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        public void setRoomIcon(Room r) {

            this.roomIdLabel.Text = "Room " + r.RoomID;
            switch (r.NumPerson)
            {
                case 1:
                    this.mainLabel.Text = "Single Room";
                    break;
                case 2:
                    this.mainLabel.Text = "Double Room";
                    break;
                case 3:
                    this.mainLabel.Text = "Triple Room";
                    break;
                case 4:
                    this.mainLabel.Text = "Family Room";
                    break;
                default:
                    this.mainLabel.Text = "Free Room";
                    break;
            }

            switch (r.Status)
            {
                case 1:
                    this.statusLabel.Text = "Reserved";
                    break;
                case 2:
                    this.statusLabel.Text = "Occupied";
                    break;
                case 3:
                    this.statusLabel.Text = "Checked-out";
                    break;
                default:
                    this.statusLabel.Text = "Available";
                    if (this.statusLabel.Text == "Available" && this.mainLabel.Text == "Free Room")
                    {
                        this.mainPanel.BackColor = Color.FromArgb(63, 81, 181);
                    }
                    break;
            }


        }



    }
}
