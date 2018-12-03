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
    public class NhanVienBUS
    {
        public NhanVienDB nvDB;

        public NhanVienBUS()
        {
            nvDB = new NhanVienDB();
        }
        private NhanVien dataTableToNhanVien(DataRow dr)
        {
            int ID = (int)(dr["NhanVienID"]);  // Beware of the possible conversion errors due to type mismatches
            string fullName = (dr["tenNV"]).ToString();
            DateTime date = (DateTime)dr["startdate"];
            bool roles = (bool)dr["roles"];
            string account = dr["account"].ToString();
            string password = dr["password"].ToString();
            Console.WriteLine(ID);
            return new NhanVien(ID, fullName, date, roles, account, password);
        }
        public NhanVien checkLogin(string acc, string pass)
        {
            DataTable dt =  nvDB.CheckLogin(acc, pass);
            foreach (DataRow dr in dt.Rows)
            {
                return dataTableToNhanVien(dr);
            }
            return null;
        }
    }
}
