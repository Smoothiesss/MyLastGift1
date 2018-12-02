using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DTO;
namespace MyLastGift
{
    public partial class HouseBookingTab : UserControl
    {
        private String roomID;
        private int roomTypeID;
        private int status;
        private int guestID;
        private String guestName;
        private int price;
        private int bookingID;
        private string nation, guestInfo;
        private string bookingTypeID;
        private DateTime dateFrom, dateTo;

        Room roomDTO;
        RoomType typeRoomDTO;
        Guest guestDTO;
        DTO.Booking bookingDTO;

        LeftView leftView;

        public HouseBookingTab()
        {
            InitializeComponent();
        }

    }


}
