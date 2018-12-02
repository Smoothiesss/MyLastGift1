using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Prepaid 
    {
        public Prepaid()
        {

        }

        public Prepaid(int bookingID,string bookingtypeID,int amount,DateTime dates,int nvID)
        {
            this.bookingID = bookingID;
            this.bookingTypeID = bookingtypeID;
            this.amount = amount;
            this.dateReceive = dates;
            this.nhanvienID = nvID;
        }

        private int bookingID;
        private string bookingTypeID;
        private int amount;
        private DateTime dateReceive;
        private int nhanvienID;

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

        public int Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public DateTime DateReceive
        {
            get
            {
                return dateReceive;
            }

            set
            {
                dateReceive = value;
            }
        }

        public int NhanvienID
        {
            get
            {
                return nhanvienID;
            }

            set
            {
                nhanvienID = value;
            }
        }
    }
}
