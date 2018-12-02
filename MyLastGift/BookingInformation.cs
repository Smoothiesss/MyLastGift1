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
    public partial class BookingInformation : UserControl
    {
       

        Room roomDTO;
        RoomType typeRoomDTO;
        Guest guestDTO;
        DTO.Booking bookingDTO;

        public BookingInformation()
        {
            InitializeComponent();
          
        }

        public void setBookingInfo(int bookingID, string roomID, int roomTypeID, int status, string guestName, int price, DateTime dateFrom, DateTime dateTo)
        {
            setBookingID(bookingID);
            setRoomTypeID(roomTypeID);
            setGuestName(guestName);
            setRoomID(roomID);
            setStatus(status);
            setDateFrom(dateFrom);
            setDateTo(dateTo);
            setPrice(price);
            
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            editGuestInfo editGuest = new editGuestInfo();
            editGuest.Visible = true;
            foreach (Control c in this.Parent.Controls)
            {
                editGuest = c as editGuestInfo;
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


        public void setRoomID(string roomID)
        {
            this.roomIdLabel.Text = roomID;
        }

        //chua set
        public void setStatus(int status)
        {
            this.statusComboBox.Text = status.ToString();
        }

        public void setPrice(int price)
        {
            this.priceLabel.Text = "$" + price;
        }

        //chua set
        public void setRoomTypeID(int roomTypeID)
        {
            roomTypeComboBox.Text = roomTypeID.ToString();
        }


        public void setGuestName(String guestName)
        {
            this.guestNameLabel.Text = guestName;
        }

        public void setBookingID(int bookingID)
        {
            this.bookID.Text = bookingID.ToString();
        }

        public void setBookingTypeID(String bookingTypeID)
        {
            bookingTypeID = bookingDTO.BookingTypeID;
        }

        public void setDateFrom(DateTime dateFrom)
        {
            this.fromDateLabel.Text = dateFrom.ToString("dd.MM.yyyy");
        }

        public void setDateTo(DateTime dateTo)
        {
            this.fromDateLabel.Text = dateTo.ToString("dd.MM.yyyy");
        }

        public string getDays(DateTime checkin, DateTime checkout)
        {
            TimeSpan time = checkout - checkin;
            double day = Math.Ceiling((double)time.Hours / 24);
            this.daysLabel.Text = day.ToString();

            return this.daysLabel.Text;
        }

        private void guestNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomTypeIconLabel_Click(object sender, EventArgs e)
        {

        }

        private void roomIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fromDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void toDayLabel_Click(object sender, EventArgs e)
        {

        }

        private void daysLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extra extra = null;
            foreach (Control c in this.Parent.Controls)
            {
                extra = c as Extra;
                if (extra != null)
                {
                    break;
                }
            }

            if (extra != null)
            {
                extra.Visible = true;
            }
        }
    }
}
