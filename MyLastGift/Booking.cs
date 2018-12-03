using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DTO;
using BUS;
using DAO;
using DevExpress.XtraGrid.Views.Grid;

namespace MyLastGift
{
    public partial class Booking : UserControl
    {


        NhanVien nv;

        public NhanVien Nv
        {
            get
            {
                return nv;
            }

            set
            {
                nv = value;
                newBooking1.Nv = nv;
                
            }
        }

        public Booking()
        {
            InitializeComponent();
            this.bookingInformation1.Visible = false;

            //LoadBooking();
            //LoadGuest();
            LoadGrid();
            //LoadBookingInfo();
            //LoadGuestInfo();
            bookingInformation1.extraBtn.Click += extraBtn_Click;
            gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
        }

        private void extraBtn_Click(object sender, EventArgs e)
        {
            extra1.Visible = true;
        }
        void LoadGrid()
        {
            BookingBUS b = new BookingBUS();
            DateTime d = DateTime.Now;
            DataTable dt = b.getBookingbyDate(d);
            MessageBox.Show(dt.Rows.Count.ToString() + " " + d.ToString("M/d/yyyy HH:mm:ss"));
            gridControl1.BindingContext = this.BindingContext;
            gridControl1.DataSource = dt;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            //Console.WriteLine("2");
            //gridView1.OptionsBehavior.EditorShowMode += gridControl1.MouseDown;
            //gridView1.RowCellClick += LoadBookInf(gridView1);
          
            
            //colCHECKIN.
            //gridControl1.DataSource = dt;
            //foreach (DataRow dr in dt.Rows)
               //gridView1.AddNewRow(dr);
        }

       
       



        #region
        void LoadGuest()
        {
            GuestBUS gdb = new GuestBUS();
            List<Guest> guestList = gdb.getAllGuestStay();

            editGuestInfo edit = new editGuestInfo();
            edit = editGuestInfo1;
            edit.setEditGuestInfo("Nguyen Cuong", 225677720, "Agoda", "VN", "0928 526 240");

            /*foreach(Guest item in guestList){
                 editGuestInfo edit = new editGuestInfo();
                 edit = editGuestInfo1;
               
            }*/
        }

        void LoadBooking()
        {
//            List<DTO.Booking> bookList = BookDAO.Instance.LoadBookList();

            BookingInformation bookInfo = new BookingInformation();
            DateTime from = DateTime.Now;
            DateTime to = from.AddDays(4);
            bookInfo = bookingInformation1;
            bookInfo.setBookingInfo(17, "103", 123, 1, "Nguyen Cuong", 400, from, to);
            bookInfo.getDays(from, to);

            /*foreach(Booking item in bookList){
                BookingInformation bookInfo = new bookingInformation();
                bookInfo = bookingInformation1;
               
            }*/
        }
        #endregion

        /*void LoadBookingInfo(DTO.Booking book, RoomType type, Guest guest, Room room)
        {
            //DTO.Booking bookID, RoomType typeID, Guest guestName, Room roomID, Room status, DateTime from, DateTime to
            BookingInformation bookInfo = new BookingInformation();

            int bookID = book.BookingID;
            string typeID = type.RoomTypeID.Trim();
            String guestName = guest.FullName.Trim();
            String roomID = room.RoomID;
            int status = room.Status;
            DateTime checkIn = book.CheckIn;
            DateTime checkOut = book.CheckOut;
            int price = type.Price;
  
            bookInfo = bookingInformation1;
            bookInfo.bookID.Text = bookID.ToString();
 
            bookInfo.roomTypeComboBox.Text = typeID;


            bookInfo.guestNameLabel.Text = guestName;
            bookInfo.roomIdLabel.Text = "Room" + roomID;

            switch (status)
            {
                case 1:
                    bookInfo.statusComboBox.Text = "Reserved";
                    break;
                case 2:
                    bookInfo.statusComboBox.Text = "Occupied";
                    break;
                case 3:
                    bookInfo.statusComboBox.Text = "Checked-out";
                    break;
                default:
                    bookInfo.statusComboBox.Text = "Available";
                    break;
            }

            bookInfo.fromDateLabel.Text = checkIn.ToString("dd.MM.yyyy");
            bookInfo.toDayLabel.Text = checkOut.ToString("dd.MM.yyyy");
            bookInfo.priceLabel.Text = price.ToString();
        }

        /*for ()
        {
        loadbooking(Guest[i],ref[int])
        }

        void Loadbooking(Guest g, Room r, )
        {
            string id = g.GuestID;
            string name = g.FirstName;

            int roomNumber = r.RoomID;

            

        }
        */
        
        /*void LoadGuestInfo(Guest guest, DTO.Booking book)
        {
            //string guestName, int guestID, string bookingTypeID, string nation,  string guestInfo
            string guestName = guest.FullName.Trim();
            string bookingTypeID = book.BookingTypeID;
            string nation = guest.Nationality;
            string guestInfo = guest.InfoID;

            editGuestInfo edit = new editGuestInfo();
            edit = editGuestInfo1;

            edit.guestNameTextBox.Text = guestName;
            edit.bookingTypeComboBox.Text = bookingTypeID;
            edit.nationTextBox.Text = nation;
            edit.phoneNumTextBox.Text = guestInfo;
        }*/



        private void btnBook_Click(object sender, EventArgs e)
        {
            /*
            bookingInformation1.bookID.ResetText();
            bookingInformation1.roomTypeComboBox.ResetText();
            bookingInformation1.ResetText();
            bookingInformation1.guestNameLabel.ResetText() ;
            bookingInformation1.roomIdLabel.ResetText();
            bookingInformation1.fromDateLabel.ResetText();
            bookingInformation1.toDayLabel.ResetText();
            bookingInformation1.priceLabel.ResetText();
            bookingInformation1.daysLabel.ResetText();
            */
            newBooking1.Nv = nv;
            newBooking1.Visible = true;
            

        }
       
       

       

        private void gridControl1_Click(object sender, EventArgs e)
        {
            bookingInformation1.Visible = true;
            newBooking1.Visible = false;
            if (gridView1.GetFocusedRowCellValue("bookingID") != null)
            {
                string id = gridView1.GetFocusedRowCellValue("bookingID").ToString();
                string typeid = gridView1.GetFocusedRowCellValue("bookingTypeID").ToString();
                BookingBUS bBus = new BookingBUS();
                GuestBUS gBUS = new GuestBUS();
                RoomBUS rBUS = new RoomBUS();
                DTO.Booking b = bBus.getBookingByID(id, typeid);
                Guest g = gBUS.getGuestByID(b.GuestID);
                Room r = rBUS.getRoomByID(b.RoomID);
                RoomType rt = rBUS.getRoomTypeByID(r.RoomType);

                int bookID = b.BookingID;
                string guestID = b.GuestID;
                string typeID = r.RoomType;
                String guestName = g.FullName.Trim();
                String roomID = b.RoomID;
                int status = r.Status;
                string bookType = b.BookingTypeID.Trim();
                DateTime checkIn = b.CheckIn;
                DateTime checkOut = b.CheckOut;
                int price = rt.Price;
                string roomType = r.RoomType;


                editGuestInfo edit = new editGuestInfo();
                edit = editGuestInfo1;
                edit.guestNameTextBox.Text = guestName;
                edit.guestIdTextBox.Text = guestID;
                edit.nationTextBox.Text = g.Nationality;

                BookingInformation bookInfo = new BookingInformation();

                bookInfo = bookingInformation1;
                bookInfo.daysLabel.Text = bookInfo.getDays(checkIn, checkOut);
                bookInfo.bookID.Text = bookID.ToString();
                bookInfo.nationTB.Text = g.Nationality;
                bookInfo.roomTypeComboBox.Text = typeID;


                bookInfo.guestNameLabel.Text = guestName;
                bookInfo.roomIdLabel.Text = "Room" + roomID;

                if (bookType.Equals("001"))
                {
                    bookInfo.bookingTypeCombobox.Text = "AGODA";
                }
                else if (bookType.Equals("002"))
                {
                    bookInfo.bookingTypeCombobox.Text = "BOOKING";
                }
                else
                {
                    bookInfo.bookingTypeCombobox.Text = "FREE";
                }
                //bookInfo.bookingTypeCombobox.Text 

                switch (status)
                {
                    case 1:
                        bookInfo.statusComboBox.Text = "Reserved";
                        break;
                    case 2:
                        bookInfo.statusComboBox.Text = "Occupied";
                        break;
                    case 3:
                        bookInfo.statusComboBox.Text = "Checked-out";
                        break;
                    default:
                        bookInfo.statusComboBox.Text = "Available";
                        break;
                }

                bookInfo.fromDateLabel.Text = checkIn.ToString("dd.MM.yyyy");
                bookInfo.toDayLabel.Text = checkOut.ToString("dd.MM.yyyy");
                PayBUS pBUS = new PayBUS();
                bookInfo.priceLabel.Text = pBUS.getTotalPrice(b).ToString();


            }
        }

        void Consume(Consume c)
        {
            Extra extra = new Extra();
            extra = extra1;

            extra1.calculate1.textBox1.Text = c.InstantNoodle.ToString();
            extra1.calculate2.textBox1.Text = c.CoCaCola.ToString();
            extra1.calculate3.textBox1.Text = c.Lavie.ToString();
            extra1.calculate4.textBox1.Text = c.ExtraBed.ToString();
            extra1.calculate5.textBox1.Text = c.Snack.ToString();
        }
        
    }
}
