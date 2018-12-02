using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomType
    {
        public RoomType()
        { }
        public RoomType(string id, int price)
        {
            this.roomTypeID = id;
            this.price = price;
        }

        private string roomTypeID;
        private int price;

       

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }


        public string RoomTypeID
        {
            get
            {
                return roomTypeID;
            }

            set
            {
                roomTypeID = value;
            }
        }
    }
}
