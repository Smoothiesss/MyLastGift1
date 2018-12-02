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
    public partial class DateNavigator : UserControl
    {
        public DateNavigator()
        {
            InitializeComponent();
            dateTimePicker.Visible = false;
            dateTimePicker.ValueChanged += navDateTimePicker_ValueChanged;
            //btnLeft.Click += btnLeft_Click;
            //btnRight.Click += btnRight_Click;
            dateTimePicker.Value = DateTime.Today;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = this.dateTimePicker.Value.AddDays(-1);
        }

        private void navDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.dateLabel.Text = this.dateTimePicker.Value.ToString("dd.MM.yyyy");
            if (this.dateTimePicker.Value == DateTime.Today)
            {
                this.dateLabel.Text += " Today";
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
        }

        public DateTime CurrentDate
        {
            get
            {
                return this.dateTimePicker.Value;
            }
        }

        public Button LeftNavigationButton
        {
            get
            {
                return this.btnLeft;
            }
        }

        public Button RightNavigationButton
        {
            get
            {
                return this.btnRight;
            }
        }
    }
}
