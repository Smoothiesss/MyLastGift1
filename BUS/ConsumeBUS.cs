using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class ConsumeBUS
    {
        private ConsumeDB cDB;

        public ConsumeBUS()
        {
            cDB = new ConsumeDB();
        }
        /*
        private Guest dataTableToGuest(DataRow dr)
        {
            string ID = (dr["bookingID"]).ToString();  // Beware of the possible conversion errors due to type mismatches
            string bookingType = (dr["bookingtypeid"]).ToString();
            string surchare = (dr["surchare"]).ToString();
            DateTime dt = (DateTime)dr["DOB"];

            return new Guest(ID, fullName, nationality, dt);
        }
        public Consume getConsumeByID(string ID, string typeID)
        {

        }*/

        public bool delete(Consume c)
        {
            return cDB.delete(c);
        }

        public bool add(Consume c)
        {
            return cDB.insert(c);
        }

        public bool edit(Consume c)
        {
            if (cDB.delete(c))
                return cDB.insert(c);
            else
                return false;
        }
    }
}
