namespace MyLastGift
{
    partial class ScheduleTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScale15Minutes timeScale15Minutes1 = new DevExpress.XtraScheduler.TimeScale15Minutes();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.panel5 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.dateNavigator1 = new MyLastGift.DateNavigator();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookingInformation1 = new MyLastGift.BookingInformation();
            this.editGuestInfo1 = new MyLastGift.editGuestInfo();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.materialDivider1);
            this.panel5.Controls.Add(this.dateNavigator1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1550, 60);
            this.panel5.TabIndex = 9;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.Location = new System.Drawing.Point(0, 57);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1550, 3);
            this.materialDivider1.TabIndex = 1;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.Size = new System.Drawing.Size(360, 60);
            this.dateNavigator1.TabIndex = 0;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(377, 60);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(3, 875);
            this.materialDivider4.TabIndex = 12;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1550, 875);
            this.panel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 875);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.schedulerControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1170, 875);
            this.panel4.TabIndex = 4;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Appearance.Appointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.schedulerControl1.Appearance.Appointment.Options.UseFont = true;
            this.schedulerControl1.DataStorage = this.schedulerStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            timeScaleYear1.Enabled = false;
            timeScaleQuarter1.Enabled = false;
            timeScaleMonth1.Enabled = false;
            timeScaleHour1.Enabled = false;
            timeScaleHour1.Visible = false;
            timeScale15Minutes1.Enabled = false;
            this.schedulerControl1.OptionsRangeControl.Scales.Add(timeScaleYear1);
            this.schedulerControl1.OptionsRangeControl.Scales.Add(timeScaleQuarter1);
            this.schedulerControl1.OptionsRangeControl.Scales.Add(timeScaleMonth1);
            this.schedulerControl1.OptionsRangeControl.Scales.Add(timeScaleWeek1);
            this.schedulerControl1.OptionsRangeControl.Scales.Add(timeScaleDay1);
            this.schedulerControl1.OptionsRangeControl.Scales.Add(timeScaleHour1);
            this.schedulerControl1.OptionsRangeControl.Scales.Add(timeScale15Minutes1);
            this.schedulerControl1.Size = new System.Drawing.Size(1170, 875);
            this.schedulerControl1.Start = new System.DateTime(2018, 11, 25, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bookingInformation1);
            this.panel3.Controls.Add(this.editGuestInfo1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1170, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 875);
            this.panel3.TabIndex = 3;
            // 
            // bookingInformation1
            // 
            this.bookingInformation1.BackColor = System.Drawing.Color.White;
            this.bookingInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingInformation1.Location = new System.Drawing.Point(0, 0);
            this.bookingInformation1.Name = "bookingInformation1";
            this.bookingInformation1.Size = new System.Drawing.Size(380, 875);
            this.bookingInformation1.TabIndex = 0;
            // 
            // editGuestInfo1
            // 
            this.editGuestInfo1.BackColor = System.Drawing.Color.White;
            this.editGuestInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGuestInfo1.Location = new System.Drawing.Point(0, 0);
            this.editGuestInfo1.Name = "editGuestInfo1";
            this.editGuestInfo1.Size = new System.Drawing.Size(380, 875);
            this.editGuestInfo1.TabIndex = 2;
            this.editGuestInfo1.Visible = false;
            // 
            // ScheduleTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialDivider4);
            this.Controls.Add(this.panel5);
            this.Name = "ScheduleTab";
            this.Size = new System.Drawing.Size(1550, 935);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private DateNavigator dateNavigator1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private System.Windows.Forms.Panel panel3;
        private BookingInformation bookingInformation1;
        private editGuestInfo editGuestInfo1;
    }
}
