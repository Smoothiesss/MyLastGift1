using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace MyLastGift
{
    
    public partial class overview1 : UserControl
    {
        RoomBUS rbus;
        NhanVien nv;
        bool visible = true;
        int reserve = 0;
        int occupied = 0;
        int available = 0;
        int checkout = 0;
        int standard = 0;
        int superior = 0;
        int deluxe = 0;
        int premium = 0;
        int familyDeluxe = 0;
        int familySuite = 0;

        private List<roomIcon> ri = new List<roomIcon>();
 
        roomListView standarList = new roomListView();
        roomListView superiorList = new roomListView();
        roomListView deluxeList = new roomListView();
        roomListView premiumDeluxeList = new roomListView();
        roomListView familyDeluxeList = new roomListView();
        roomListView familySuiteList = new roomListView();

        public List<roomIcon> Ri
        {
            get
            {
                return ri;
            }

            set
            {
                ri = value;
            }
            
        }

        public NhanVien Nv
        {
            get
            {
                return nv;
            }

            set
            {
                nv = value;
            }
        }

        public overview1()
        {
            InitializeComponent();
            setOverview();
            MaterialSkin.MaterialSkinManager skin = MaterialSkin.MaterialSkinManager.Instance;
            skin.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.WHITE);

            this.reservedNum.Text = reserve.ToString();
            this.occupiedNum.Text = occupied.ToString();
            this.availableNum.Text = available.ToString();
            this.checkoutNum.Text = checkout.ToString();

            this.standardNum.Text = standard.ToString();
            this.superiorNum.Text = superior.ToString();
            this.deluxeNum.Text = deluxe.ToString();
            this.premiumNum.Text = premium.ToString();
            this.familyDeluxeNum.Text = familyDeluxe.ToString();
            this.familySuiteNum.Text = familySuite.ToString();
        }

        public void setOverview()
        {
            
            rbus = new RoomBUS();
            List<Room> r = rbus.getAllRoom();
            foreach (Room aRoom in r)
            {
                LoadRoomList(aRoom);
            }
            standarList.updateHeight();
            superiorList.updateHeight();
            deluxeList.updateHeight();
            premiumDeluxeList.updateHeight();
            familyDeluxeList.updateHeight();
            familySuiteList.updateHeight();

            standarList.Dock = DockStyle.Top;
            superiorList.Dock = DockStyle.Top;
            deluxeList.Dock = DockStyle.Top;
            premiumDeluxeList.Dock = DockStyle.Top;
            familyDeluxeList.Dock = DockStyle.Top;
            familySuiteList.Dock = DockStyle.Top;
        }

        void LoadRoomFooter(DTO.Booking book)
        {
            TimeSpan date = book.CheckIn - book.CheckOut;
            String type = book.BookingTypeID;
            roomIcon icon = new roomIcon();
            icon.occupiedLabel.Text = date.Days.ToString();
            icon.bookTypeLabel.Text = type;
        }
        void LoadRoomList(Room room)
        {
            String id = room.RoomID;
            int num = room.NumPerson;
            int status = room.Status;
            string type = room.RoomType.Trim();

            roomIcon icon = new roomIcon();

            standarList.roomTypeLabel.Text = "Standar";
            superiorList.roomTypeLabel.Text = "Superior";
            deluxeList.roomTypeLabel.Text = "Deluxe";
            premiumDeluxeList.roomTypeLabel.Text = "Premium Deluxe";
            familyDeluxeList.roomTypeLabel.Text = "Family Deluxe";
            familySuiteList.roomTypeLabel.Text = "Family Suite";

            icon.roomIdLabel.Text = id;
            icon.mainLabel.Text = type;
            switch (status)
            {
                case 1:
                    icon.statusLabel.Text = "Reserved";
                    reserve += 1;
                    break;
                case 2:
                    icon.statusLabel.Text = "Occupied";
                    occupied += 1;
                    break;
                case 3:
                    icon.statusLabel.Text = "Checked-out";
                    checkout += 1;
                    break;
                default:
                    icon.statusLabel.Text = "Available";
                    available += 1;
                    break;
            }


            Ri.Add(icon);
            //Neu room type id = 1 -> la single room
            if (type.Equals("Standard".ToUpper()))
            {
                standarList.flowLayoutRoomList.Controls.Add(icon);
                standarList.numroomIcon += 1;
                standard += 1;
            }
            else if (type.Equals("Superior".ToUpper()))
            {
                superiorList.flowLayoutRoomList.Controls.Add(icon);
                superiorList.numroomIcon += 1;
                superior += 1;
            }
            else if (type.Equals("Deluxe".ToUpper()))
            {
                deluxeList.flowLayoutRoomList.Controls.Add(icon);
                deluxeList.numroomIcon += 1;
                deluxe += 1;
            }
            else if (type.Equals("Premium Deluxe".ToUpper()))
            {
                premiumDeluxeList.flowLayoutRoomList.Controls.Add(icon);
                premiumDeluxeList.numroomIcon += 1;
                premium += 1;
            }
            else if (type.Equals("Family Deluxe".ToUpper()))
            {
                familyDeluxeList.flowLayoutRoomList.Controls.Add(icon);
                familyDeluxeList.numroomIcon += 1;
                familyDeluxe += 1;
            }
            else
            {
                familySuiteList.flowLayoutRoomList.Controls.Add(icon);
                familySuiteList.numroomIcon += 1;
                familySuite += 1;
            }

            
            roomListPanel.Controls.Add(familySuiteList);
            roomListPanel.Controls.Add(familyDeluxeList);
            roomListPanel.Controls.Add(premiumDeluxeList);
            roomListPanel.Controls.Add(deluxeList);
            roomListPanel.Controls.Add(superiorList);
            roomListPanel.Controls.Add(standarList);

            


        }
        void CheckBoxOnCheckedChanged(object obj, EventArgs ea)
        {
            visible = ((CheckBox)obj).Checked;
            Invalidate(false);
        }

        private void cbStandard_CheckedChanged(object sender, EventArgs e)
        {
            if(cbStandard.Checked == false)
            {
                standarList.Visible = false;
            }
            else
            {
                standarList.Visible = true;
            }
        }

        private void cbSuperior_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSuperior.Checked == false)
            {
                superiorList.Visible = false;
            }
            else
            {
                superiorList.Visible = true;
            }
        }

        private void cbDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDeluxe.Checked == false)
            {
                deluxeList.Visible = false;
            }
            else
            {
                deluxeList.Visible = true;
            }
        }

        private void cbPreDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPreDeluxe.Checked == false)
            {
                premiumDeluxeList.Visible = false;
            }
            else
            {
                premiumDeluxeList.Visible = true;
            }
        }

        private void cbFamDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFamDeluxe.Checked == false)
            {
                familyDeluxeList.Visible = false;
            }
            else
            {
                familyDeluxeList.Visible = true;
            }
        }

        private void cbFamSuite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFamSuite.Checked == false)
            {
                familySuiteList.Visible = false;
            }
            else
            {
                familySuiteList.Visible = true;
            }
        }

        private void cbReserved_CheckedChanged(object sender, EventArgs e)
        {
            if(cbReserved.Checked == false)
            {
                foreach (roomIcon aRoom in Ri)
                {
                    if(aRoom.statusLabel.Text == "Reserved")
                    {
                        aRoom.Visible = false;
                    }
                    else
                    {
                        aRoom.Visible = true;
                    }
                }
            }
            else
            {
                foreach (roomIcon aRoom in Ri)
                {
                    
                        aRoom.Visible = true;
                }
            }
        }

        private void cbOccupied_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOccupied.Checked == false)
            {
                foreach (roomIcon aRoom in Ri)
                {
                    if (aRoom.statusLabel.Text == "Occupied")
                    {
                        aRoom.Visible = false;
                    }
                    else
                    {
                        aRoom.Visible = true;
                    }
                }
            }
            else
            {
                foreach (roomIcon aRoom in Ri)
                {

                    aRoom.Visible = true;
                }
            }
        }

        private void cbAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAvailable.Checked == false)
            {
                foreach (roomIcon aRoom in Ri)
                {
                    if (aRoom.statusLabel.Text == "Available")
                    {
                        aRoom.Visible = false;
                    }
                    else
                    {
                        aRoom.Visible = true;
                    }
                }
            }
            else
            {
                foreach (roomIcon aRoom in Ri)
                {

                    aRoom.Visible = true;
                }
            }
        }

        private void cbCheckout_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheckout.Checked == false)
            {
                foreach (roomIcon aRoom in Ri)
                {
                    if (aRoom.statusLabel.Text == "Check-out")
                    {
                        aRoom.Visible = false;
                    }
                    else
                    {
                        aRoom.Visible = true;
                    }
                }
            }
            else
            {
                foreach (roomIcon aRoom in Ri)
                {

                    aRoom.Visible = true;
                }
            }
        }
    }
}
