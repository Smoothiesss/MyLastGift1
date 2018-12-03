using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class BookingBUS
    {
        BookingDB bDB;

        public BookingBUS()
        {
            bDB = new BookingDB();
        }

        public DataTable getBookingbyDate(DateTime d)
        {
            return bDB.getByDate(d);

        }

        public bool edit(Booking b)
        {
            if (bDB.delete(b))
                return bDB.insert(b);
            else
                return false;
        }

        public bool checkAvaiable(string roomID, DateTime din, DateTime dout)
        {
            DataTable dt = bDB.getStatusFromDate(roomID, din, dout);
            if (dt.Rows.Count != 0)
                return false;
            return true; 
        }

        public Booking getBookingByID(string ID, string typeID)
        {
            DataTable dt = bDB.getbyID(ID, typeID);
            Booking ans = new Booking();
            foreach (DataRow dr in dt.Rows)
            {
                int bID = (int)dr["BookingID"];  // Beware of the possible conversion errors due to type mismatches
                string roomID = (dr["roomID"]).ToString();
                string idInfo = (dr["IDinfo"]).ToString();
                string bookingTypeID = (dr["bookingtypeID"]).ToString();
                int nhanVienID = (int)(dr["nhanvienID"]);
                DateTime date = (DateTime)dr["date"];
                DateTime checkIn = (DateTime)dr["checkin"];
                DateTime checkOut = (DateTime)dr["checkOut"];
                bool breakfast = (bool)dr["breakfast"];

                ans = new Booking(bID, roomID, idInfo, bookingTypeID, nhanVienID, date, checkIn, checkOut, breakfast);
            }
            return ans;


        }
        public List<Booking> getList(DateTime d)
        {
            DataTable dt = bDB.getList(d);
            List<Booking> ans = new List<Booking>();
            foreach (DataRow dr in dt.Rows)
            {
                int bID = (int)dr["BookingID"];  // Beware of the possible conversion errors due to type mismatches
                string roomID = (dr["roomID"]).ToString();
                string idInfo = (dr["IDinfo"]).ToString();
                string bookingTypeID = (dr["bookingtypeID"]).ToString();
                int nhanVienID = (int)(dr["nhanvienID"]);
                DateTime date = (DateTime)dr["date"];
                DateTime checkIn = (DateTime)dr["checkin"];
                DateTime checkOut = (DateTime)dr["checkOut"];
                bool breakfast = (bool)dr["breakfast"];

                ans.Add(new Booking(bID, roomID, idInfo, bookingTypeID, nhanVienID, date, checkIn, checkOut, breakfast));
            }
            return ans;


        }
        public bool InsertBooking(Booking b)
        {
            if (b.BookingTypeID.Trim() == "003")
            {
                b.BookingID = bDB.updateBookingID();
            }
            bool ans = bDB.insert(b);
            return ans;

        }
    }
}


