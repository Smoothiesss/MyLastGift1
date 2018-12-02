using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookingType
    {
       
        public BookingType(string bookingTypeID, string source)
        {
            this.bookingTypeID = bookingTypeID;
            this.source = source;
        }
        private string bookingTypeID;
        private string source;

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

        public string Source
        {
            get
            {
                return source;
            }

            set
            {
                source = value;
            }
        }
    }
}
