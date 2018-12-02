using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public NhanVien(int ID, string ten, DateTime start, bool roles, string acc, string pwd)
        {
            this.nhanVienID = ID;
            this.tenNv = ten;
            this.startDate = start;
            this.roles = roles;
            this.account = acc;
            this.password = pwd;
        }

        private int nhanVienID;
        private string tenNv;
        private DateTime startDate;
        private bool roles;
        private string account;
        private string password;

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

        public string TenNv
        {
            get
            {
                return tenNv;
            }

            set
            {
                tenNv = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public bool Roles
        {
            get
            {
                return roles;
            }

            set
            {
                roles = value;
            }
        }

        public string Account
        {
            get
            {
                return account;
            }

            set
            {
                account = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }


}
