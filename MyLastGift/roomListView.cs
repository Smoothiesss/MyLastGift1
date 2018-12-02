using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace MyLastGift
{
    public partial class roomListView : UserControl
    {
        public int numroomIcon;
        public roomListView()
        {
            InitializeComponent();
            numroomIcon = 0;
        }

        public int NumroomIcon
        {
            get
            {
                return numroomIcon;
            }

            set
            {
                numroomIcon = value;
            }
        }

        public void updateHeight()
        {
            roomIcon icon = new roomIcon();
            int numRoom = numroomIcon;
            double numRow = Math.Ceiling(((double)numRoom / 4));
            Console.WriteLine(numRow +" "+icon.Height);
            double totalHeight = numRow * icon.Height;
            flowLayoutRoomList.Size = new Size(1170, (int)totalHeight);
            this.Size = new Size(1170, (int)totalHeight + 90);
            
        }
    }
}
