using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Guest
    {

        public Guest()
        { }
        public Guest( string infoID, string Name, string nationality,DateTime d)
        {
            this.infoID = infoID;
            this.fullName = Name;
            this.nationality = nationality;
            this._DOB = d;
        }
        #region Variables
        private string infoID;
        private string fullName;
        private string nationality;
        private DateTime _DOB;


        public string InfoID
        {
            get
            {
                return infoID;
            }

            set
            {
                infoID = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return _DOB;
            }

            set
            {
                _DOB = value;
            }
        }
        #endregion

    }
}
