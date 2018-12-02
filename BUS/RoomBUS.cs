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
    public class RoomBUS
    {
        private RoomDB rDB;
        private BookingDB bDB;
        private RoomTypeDB rtDB;

        public RoomBUS()
        {
            rDB = new RoomDB();
            bDB = new BookingDB();
            rtDB = new RoomTypeDB();
        }

        public List<Room> getAllRoom()
        {
            DataTable dtInput = rDB.getAll();
            List<Room> ansList = new List<Room>();
            DateTime d = DateTime.Now;
            foreach (DataRow dr in dtInput.Rows)
            {
                string ID = (dr["roomID"]).ToString();  // Beware of the possible conversion errors due to type mismatches
                Console.WriteLine(ID);
                int status;
                if (checkStatus(ID, d))
                    status = 1;
                else status = 0;
                int num = (int)dr["numPerson"];
                string type = dr["roomtypeID"].ToString();

                ansList.Add(new Room(ID, status, num, type));
            }
            return ansList;
        }

        public bool checkStatus(string r, DateTime d)
        {
            DataTable dt = bDB.getStatus(r, d);
            Console.WriteLine(dt);
            if (dt.Rows.Count < 1)
                return true;
            else
                return false;
        }

        public Room getRoomByID(string rID)
        {
            DataTable dtInput = rDB.getByID(rID);
            Room r = new Room();
            DateTime d = DateTime.Now;
            foreach (DataRow dr in dtInput.Rows)
            {
                string ID = (dr["roomID"]).ToString();  // Beware of the possible conversion errors due to type mismatches
                int status;
                if (checkStatus(ID, d))
                    status = 1;
                else status = 0;
                int num = (int)dr["numPerson"];
                string type = dr["roomtypeID"].ToString();

                r = new Room(ID, status, num, type);
            }
            return r;
        }
        public RoomType getRoomTypeByID(string rtID)
        {
            DataTable dtInput = rtDB.getByID(rtID);
            RoomType r = new RoomType();
            DateTime d = DateTime.Now;
            foreach (DataRow dr in dtInput.Rows)
            {
                string ID = (dr["roomTypeID"]).ToString();  // Beware of the possible conversion errors due to type mismatches
                int price = (int)dr["price"];

                r = new RoomType(ID, price);
            }
            return r;
        }

        public List<Room> getRoomByRoomType(string roomType)
        {
            DataTable dtInput = rDB.getByRoomTypeID(roomType);
            List<Room> r = new List<Room>();
            DateTime d = DateTime.Now;
            foreach (DataRow dr in dtInput.Rows)
            {
                string ID = (dr["roomID"]).ToString();  // Beware of the possible conversion errors due to type mismatches
                int status;
                if (checkStatus(ID, d))
                    status = 1;
                else status = 0;
                int num = (int)dr["numPerson"];
                string type = dr["roomtypeID"].ToString();

                r.Add(new Room(ID, status, num, type));
            }
            return r;
        }


    }
}

