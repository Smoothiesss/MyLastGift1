using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Booking
    {
        public Booking()
        {

        }
        public Booking(int bookingID, string roomID, string guestID, string bookingTypeID,int nhanVienID,DateTime date, DateTime checkIn, DateTime checkOut,bool breakfast)
        {
            this.bookingID = bookingID;
            this.roomID = roomID;
            this.guestID = guestID;
            this.bookingTypeID = bookingTypeID;
            this.nhanVienID = nhanVienID;
            this.date = date;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.BreakFast = breakfast;
        }

        private int bookingID;
        private string roomID;
        private string guestID;
        private string bookingTypeID;
        private int nhanVienID;
        private DateTime date;
        private DateTime checkIn;
        private DateTime checkOut;
        private bool breakFast;

        public double getDates()
        {
            TimeSpan span = this.CheckOut - this.CheckIn;
            double days = Math.Ceiling((double)span.TotalHours / 24);
            return days;
        }
        public int BookingID
        {
            get
            {
                return bookingID;
            }

            set
            {
                bookingID = value;
            }
        }

        public string RoomID
        {
            get
            {
                return roomID;
            }

            set
            {
                roomID = value;
            }
        }


        public string GuestID
        {
            get
            {
                return guestID;
            }

            set
            {
                guestID = value;
            }
        }

        public string BookingTypeID
        {
            get
            {
                return bookingTypeID;
            }

            set
            {
                bookingTypeID = value;
            }
        }

        public int NhanVienID
        {
            get
            {
                return nhanVienID;
            }

            set
            {
                nhanVienID = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public DateTime CheckIn
        {
            get
            {
                return checkIn;
            }

            set
            {
                checkIn = value;
            }
        }

        public DateTime CheckOut
        {
            get
            {
                return checkOut;
            }

            set
            {
                checkOut = value;
            }
        }

        public bool BreakFast
        {
            get
            {
                return breakFast;
            }

            set
            {
                breakFast = value;
            }
        }
    }
}
