using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Consume
    {
        public Consume(int bookingID, string bookingtypeID, int surchare, int cocacola, int instantNoodle, int lavie, int snack, int extrabed)
        {
            this.bookingID = bookingID;
            this.bookingTypeID = bookingtypeID;
            this.coCaCola = cocacola;
            this.surchare = surchare;
            this.instantNoodle = instantNoodle;
            this.extraBed = extrabed;
            this.snack = snack;
            this.lavie = lavie;
        }

        private int bookingID;
        private string bookingTypeID;
        private int coCaCola;
        private int lavie;
        private int extraBed;
        private int instantNoodle;
        private int snack;
        private int surchare;

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

        public int CoCaCola
        {
            get
            {
                return coCaCola;
            }

            set
            {
                coCaCola = value;
            }
        }

        public int Lavie
        {
            get
            {
                return lavie;
            }

            set
            {
                lavie = value;
            }
        }

        public int ExtraBed
        {
            get
            {
                return extraBed;
            }

            set
            {
                extraBed = value;
            }
        }

        public int InstantNoodle
        {
            get
            {
                return instantNoodle;
            }

            set
            {
                instantNoodle = value;
            }
        }

        public int Snack
        {
            get
            {
                return snack;
            }

            set
            {
                snack = value;
            }
        }

        public int Surchare
        {
            get
            {
                return surchare;
            }

            set
            {
                surchare = value;
            }
        }
    }
}
