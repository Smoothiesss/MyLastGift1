using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLastGift
{
    public partial class reportTab : UserControl
    {
        private String roomID;
        private int roomTypeID;
        private int status;
        private int guestID;
        private String guestName;
        private int price;
        private int bookingID;
        private string bookingTypeID;

        DTO.Room roomDTO;
        DTO.RoomType typeRoomDTO;
        DTO.Guest guestDTO;
        DTO.Booking bookingDTO;

        public reportTab()
        {
            InitializeComponent();
        }


    }
}
