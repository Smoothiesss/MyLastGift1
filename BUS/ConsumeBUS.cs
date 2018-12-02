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
        private Consume dataTableToConsume(DataRow dr)
        {
            int ID = (int)(dr["bookingID"]);  // Beware of the possible conversion errors due to type mismatches
            string bookingType = (dr["bookingtypeid"]).ToString();
            int surchare = (int)(dr["surchare"]);
            int cocacola = (int)(dr["cocacola"]);
            int lavie = (int)(dr["lavie"]);
            int snack = (int)(dr["snack"]);
            int noodle = (int)(dr["instantnoodle"]);
            int extrabed = (int)(dr["extrabed"]);


            return new Consume(ID, bookingType,surchare,cocacola,noodle,lavie,snack,extrabed);
        }
        public Consume getConsumeByID(string ID, string typeID)
        {
            DataTable dt = cDB.getByID(ID,typeID);
            Consume ans = new Consume();
            foreach (DataRow dr in dt.Rows)
            {

                ans = dataTableToConsume(dr);
            }
            return ans;
        }

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
