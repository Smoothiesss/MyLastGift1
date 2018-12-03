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
using DevExpress.XtraScheduler.Drawing;
using DTO;
using BUS;


namespace MyLastGift
{
    public partial class ScheduleTab : UserControl
    {
        
        BookingBUS bBUS;
        
        public ScheduleTab()
        {
            InitializeComponent();
            setSchedule();
            bookingInformation1.buttonClose.Visible = false;
            this.schedulerControl1.MouseClick += SchedulerControl1_MouseClick;
        }

        public void setSchedule()
        {
            DateTime date = DateTime.Now;
            bBUS = new BookingBUS();

            List<DTO.Booking> list =  bBUS.getList(date);
            
            foreach (DTO.Booking b in list)
            {
                LoadSchedule(b);
            }

            //schedulerControl1.DayView.TimeRulers.Clear();
            schedulerControl1.DayView.TimeSlots.Add(new TimeSlot(TimeSpan.FromHours(10),"5 hours"));
            schedulerControl1.DayView.TimeScale = TimeSpan.FromHours(10);
            //schedulerStorage1.Appointments.Mappings
            schedulerControl1.DayView.DayCount = 3;
            schedulerControl1.Views.DayView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
            schedulerControl1.Views.DayView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never;
        }

        private void SchedulerControl1_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime date = DateTime.Now;
            bBUS = new BookingBUS();
            List<DTO.Booking> list = bBUS.getList(date);

            SchedulerHitInfo hitInfo = schedulerControl1.ActiveView.ViewInfo.CalcHitInfo(e.Location, false);

            
            
                if (hitInfo.HitTest == SchedulerHitTest.AppointmentContent)
                {
                foreach (DTO.Booking b in list)
                {
                    foreach (Appointment myAppt in schedulerControl1.SelectedAppointments)
                    {
                        //MessageBox.Show(myAppt.Description);
                        loadInfo(b);
                    }
                }
                }
            
            
        }
        public void setInfo()
        {
            DateTime date = new DateTime(2018,10,30);
            bBUS = new BookingBUS();
            List<DTO.Booking> list = bBUS.getList(date);

            foreach (DTO.Booking b in list)
            {
                loadInfo(b);
            }
        }


        public void LoadSchedule(DTO.Booking b)
        {
            BookingBUS bBus = new BookingBUS();
            GuestBUS gBUS = new GuestBUS();
            RoomBUS rBUS = new RoomBUS();
            string id = b.BookingID.ToString();
            Guest g = gBUS.getGuestByID(b.GuestID);
            Room r = rBUS.getRoomByID(b.RoomID);
            RoomType rt = rBUS.getRoomTypeByID(r.RoomType);

            schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Month;
            schedulerControl1.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            String roomID = b.RoomID;
            String name = g.FullName.Trim();

            DateTime checkin = b.CheckIn;
            DateTime checkout = b.CheckOut;

            Appointment app = schedulerStorage1.CreateAppointment(AppointmentType.Normal);
            DateTime start = checkin;
            DateTime end = checkout;
            app.Start = start;
            app.End = end;
            app.AllDay = false;
            app.LabelKey = 3;
            app.StatusKey = 1;
            app.Subject = "Room " + roomID + " - " + name;
            app.SetId(id);
            schedulerStorage1.Appointments.Add(app);
        }

        public void loadInfo(DTO.Booking b)
        {
            Appointment app = schedulerStorage1.CreateAppointment(AppointmentType.Normal);
            BookingBUS bBus = new BookingBUS();
            GuestBUS gBUS = new GuestBUS();
            RoomBUS rBUS = new RoomBUS();
            string id = b.BookingID.ToString();
            Guest g = gBUS.getGuestByID(b.GuestID);
            Room r = rBUS.getRoomByID(b.RoomID);
            RoomType rt = rBUS.getRoomTypeByID(r.RoomType);

            String roomID = b.RoomID;
            String name = g.FullName.Trim();
            int bookID = b.BookingID;
            string typeID = r.RoomType;
            //Console.WriteLine(g.FullName);

            string guestID = b.GuestID;
            int status = r.Status;
            string bookType = b.BookingTypeID.Trim();
            DateTime checkIn = app.Start;
            DateTime checkOut = b.CheckOut;
            int price = rt.Price;
           
                


            editGuestInfo edit = new editGuestInfo();
            edit = editGuestInfo1;
            edit.guestNameTextBox.Text = name;
            edit.guestIdTextBox.Text = guestID;
            edit.nationTextBox.Text = g.Nationality;

            BookingInformation bookInfo = new BookingInformation();

            bookInfo = bookingInformation1;
            bookInfo.daysLabel.Text = bookInfo.getDays(checkIn, checkOut);
            bookInfo.bookID.Text = bookID.ToString();
            bookInfo.nationTB.Text = g.Nationality;
            bookInfo.roomTypeComboBox.Text = typeID;


            bookInfo.guestNameLabel.Text = name;
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
             bookInfo.priceLabel.Text = price.ToString();

            

        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            MyLastGift.OutlookAppointmentForm form = new MyLastGift.OutlookAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        
    }


    }

