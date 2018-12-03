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
    public partial class newBooking : UserControl
    {
        NhanVien nv;

        public NhanVien Nv
        {
            get
            {
                return nv;
            }

            set
            {
                
                nv = value;
                staffComboBox.Text = nv.TenNv;
            }
        }

        public newBooking()
        {
            InitializeComponent();
            dateCheckin.DateTime = DateTime.Now;
            
            
        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newEditGuest editGuest = null;
            foreach (Control c in this.Parent.Controls)
            {
                editGuest = c as newEditGuest;
                if (editGuest != null)
                {
                    break;
                }
            }

            if (editGuest != null)
            {
                editGuest.Visible = true;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void roomTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (roomTypeComboBox.Text != null)
            {
                roomComboBox.Properties.Items.Clear();
                getRoomType();
            }

            if (roomTypeComboBox.Text == null)
            {
                breakfastCheckbox.Enabled = false;
            }
            else if (roomTypeComboBox.Text.Equals("STANDARD"))
            {
                //Console.WriteLine(roomTypeComboBox.Text.Equals("STANDARD"));
            
                breakfastCheckbox.Checked = false;
                breakfastCheckbox.Enabled = false;
                bookingTypeCombobox.Enabled = true;
                roomComboBox.Enabled = true;
            }
            else if (roomTypeComboBox.Text.Equals("SUPERIOR"))
            {
                breakfastCheckbox.Enabled = true;
                bookingTypeCombobox.Enabled = true;
                roomComboBox.Enabled = true;
            }
            else
            {
                breakfastCheckbox.Checked = true;
                breakfastCheckbox.Enabled = false;
                bookingTypeCombobox.Enabled = true;
                roomComboBox.Enabled = true;
            }
        }

        public void getRoomType()
        {
            RoomBUS r = new RoomBUS();
            RoomType room = new RoomType();
            List<Room> list = r.getRoomByRoomType(roomTypeComboBox.Text);
            foreach (Room Aroom in list)
            {
                Console.WriteLine(Aroom.RoomID);
                roomComboBox.Properties.Items.Add(Aroom.RoomID);
            }
        }


        public void getDays(DateTime checkOut)
        {

            DateTime checkIn = this.dateCheckin.DateTime;
            this.dateCheckout.DateTime = checkOut;
            TimeSpan time = checkOut - checkIn;
            double day = Math.Ceiling((double)time.TotalHours / 24);
            this.daysLabel.Text = day.ToString();
            updatePrice(day);
            Console.WriteLine(day.ToString());
        }

        public void updatePrice(double days)
        {
            string roomType = roomTypeComboBox.Text;
            PayBUS pbus = new PayBUS();
            int roomPrice = pbus.getRoomPrice(roomType);
            int tmp =   roomPrice * (int)days;
            priceLabel.Text = tmp.ToString();
        }

        private void dateCheckout_EditValueChanged(object sender, EventArgs e)
        {
            getDays(this.dateCheckout.DateTime);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name = guestNameTextBox.Text;
            string nal = nationTB.Text;

            Guest g = new Guest(null, name, nal, DateTime.Now);

            GuestBUS gBUS = new GuestBUS();

            g = gBUS.insertGuest(g);
            if (g != null)
            {
                MessageBox.Show(g.FullName + " " + g.Nationality);
            }
            else
            {
                return;
            }
            BookingBUS bBUS = new BookingBUS();
            string roomType = roomTypeComboBox.Text;
            string roomID = roomComboBox.Text;
            string bookingType = bookingTypeCombobox.Text;
            DateTime dateIn = dateCheckin.DateTime;
            DateTime dateout = dateCheckout.DateTime;
            if (bBUS.checkAvaiable(roomID, dateIn, dateout) == false)
            {
                MessageBox.Show("ADD BOOKING SUCCESS FAILED!! ROOM BOOKED", "CONFIRMATION",
      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool breakfast = false;
            if (breakfastCheckbox.Checked == true)
            {
                breakfast = true;
            }
            string type = "003";
            if (bookingType == "AGODA")
            {
                type = "001";
            }
            else if (bookingType == "Booking.com")
            {
                type = "002";
            }
            else
            {

            }
            DTO.Booking b = new DTO.Booking(0, roomID, g.InfoID, type, nv.NhanVienID, DateTime.Now, dateIn, dateout, breakfast);


            if (bBUS.InsertBooking(b))
            {
                MessageBox.Show("ADD BOOKING SUCCESS FULL", "CONFIRMATION",
                    MessageBoxButtons.OK);
            }
            else
            {

                MessageBox.Show("ADD BOOKING SUCCESS FAILED", "CONFIRMATION",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
