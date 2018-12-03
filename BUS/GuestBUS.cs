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
    public class GuestBUS
    {
        public GuestDB gDb;

        public GuestBUS()
        {
            gDb = new GuestDB();
        }

        private Guest dataTableToGuest(DataRow dr)
        {
            string ID = (dr["IDINFO"]).ToString();  // Beware of the possible conversion errors due to type mismatches
            string fullName = (dr["FullName"]).ToString();
            string nationality = (dr["nationality"]).ToString();
            DateTime dt = (DateTime)dr["DOB"];
            Console.WriteLine(ID);
            return new Guest(ID, fullName, nationality,dt);
        }

        public List<Guest> getAllGuestStay()
        {
            DataTable dt = gDb.getStayingGuest();
            List<Guest> ansList = new List<Guest>() ;
            foreach (DataRow dr in dt.Rows)
            {
                ansList.Add(dataTableToGuest(dr));
            }
            return ansList;
        }

        public Guest getGuestByID(string gID)
        {
            DataTable dt = gDb.getByID(gID);
            Guest ans = new Guest();
            foreach (DataRow dr in dt.Rows)
            {

                ans = dataTableToGuest(dr);
            }
            return ans;
        }

        public bool updateGuest(Guest old, Guest newG)
        {
            return gDb.update(old, newG);
        }
        
        public Guest insertGuest(Guest g)
        {
            if (g.InfoID == null)
            {
                g.InfoID = "unk" + (int)(gDb.getMaxUnk()+1);
                Console.WriteLine("guest id" +" " +g.InfoID);
            }
            if (gDb.insert(g))
                return g;
            else return null;
        }
    }
}
