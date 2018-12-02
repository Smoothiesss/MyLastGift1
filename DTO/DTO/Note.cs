using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Note
    {
        public Note(int id, int bookingID, string context,int nvID)
        {
            this.noteID = id;
            this.bookingID = bookingID;
            this.context = context;
            this.NhanVienID = nvID;
        }

        private int noteID;
        private int bookingID;
        private string context;
        private int nhanVienID;
        public int NoteID
        {
            get
            {
                return noteID;
            }

            set
            {
                noteID = value;
            }
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

        public string Context
        {
            get
            {
                return context;
            }

            set
            {
                context = value;
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
    }
}
