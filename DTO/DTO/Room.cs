using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room
    {

        public Room()
        {

        }
        public Room(string id , int status,int num,string roomType)
        {
            this.roomID = id;
            this.status = status;
            this.numPerson = num;
            this.RoomType = roomType;
        }

        private string roomID;
        private int status;
        private int numPerson;
        private string roomType;

        public string RoomID
        {
            get
            {
                return roomID;
            }

            set
            {
                roomID = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int NumPerson
        {
            get
            {
                return numPerson;
            }

            set
            {
                numPerson = value;
            }
        }

        public string RoomType
        {
            get
            {
                return roomType;
            }

            set
            {
                roomType = value;
            }
        }
    }
}
