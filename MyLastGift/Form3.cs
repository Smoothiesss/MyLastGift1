﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace MyLastGift
{
    public partial class Form3 : Form
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
            }
        }

        public Form3(NhanVien nv)
        {
            InitializeComponent();
            SidePanel.Width = btnOverview.Width;
            SidePanel.Left = btnOverview.Left;
            overview11.BringToFront();
            this.nv = nv;
            overview11.Nv = nv;
            MessageBox.Show(nv.NhanVienID.ToString());
            booking1.Nv = nv;

        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            SidePanel.Width = btnOverview.Width;
            SidePanel.Left = btnOverview.Left;
            overview11.BringToFront();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            SidePanel.Width = btnBooking.Width;
            SidePanel.Left = btnBooking.Left;
            booking1.BringToFront();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            SidePanel.Width = btnSchedule.Width;
            SidePanel.Left = btnSchedule.Left;
            scheduleTab1.BringToFront();
        }

        

        private void btnReport_Click(object sender, EventArgs e)
        {
            SidePanel.Width = btnReport.Width;
            SidePanel.Left = btnReport.Left;
            admin1.BringToFront();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
