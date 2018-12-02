using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        public NhanVienDB nvDB;

        public NhanVienBUS()
        {
            nvDB = new NhanVienDB();
        }

        public bool checkLogin(string acc, string pass)
        {
            return nvDB.CheckLogin(acc, pass);
        }
    }
}
