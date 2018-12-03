namespace MyLastGift
{
    partial class Booking
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.dateNavigator1 = new MyLastGift.DateNavigator();
            this.bOOKINGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.extra1 = new MyLastGift.Extra();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colROOMID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHECKIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHECKOUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.occupiedLabel = new System.Windows.Forms.Label();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.newBooking1 = new MyLastGift.newBooking();
            this.bookingInformation1 = new MyLastGift.BookingInformation();
            this.newEditGuest1 = new MyLastGift.newEditGuest();
            this.editGuestInfo1 = new MyLastGift.editGuestInfo();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.btnLoad);
            this.panel5.Controls.Add(this.btnBook);
            this.panel5.Controls.Add(this.materialDivider1);
            this.panel5.Controls.Add(this.dateNavigator1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1550, 60);
            this.panel5.TabIndex = 7;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBook.Location = new System.Drawing.Point(380, 13);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(111, 38);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
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
            // bOOKINGBindingSource
            // 
            this.bOOKINGBindingSource.DataMember = "BOOKING";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Check Out";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Check Out";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 6;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Check Out";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // extra1
            // 
            this.extra1.Dock = System.Windows.Forms.DockStyle.Left;
            this.extra1.Location = new System.Drawing.Point(0, 60);
            this.extra1.Name = "extra1";
            this.extra1.Size = new System.Drawing.Size(380, 875);
            this.extra1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.RightPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(380, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 875);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Controls.Add(this.occupiedLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 875);
            this.panel3.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridControl1.Location = new System.Drawing.Point(0, 50);
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 825);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colROOMID,
            this.colCHECKIN,
            this.colCHECKOUT,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colROOMID
            // 
            this.colROOMID.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.colROOMID.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.colROOMID.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colROOMID.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colROOMID.AppearanceHeader.Options.UseBackColor = true;
            this.colROOMID.AppearanceHeader.Options.UseBorderColor = true;
            this.colROOMID.AppearanceHeader.Options.UseFont = true;
            this.colROOMID.AppearanceHeader.Options.UseForeColor = true;
            this.colROOMID.Caption = "Room ID";
            this.colROOMID.FieldName = "RoomID";
            this.colROOMID.Name = "colROOMID";
            this.colROOMID.Visible = true;
            this.colROOMID.VisibleIndex = 0;
            // 
            // colCHECKIN
            // 
            this.colCHECKIN.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.colCHECKIN.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.colCHECKIN.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colCHECKIN.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colCHECKIN.AppearanceHeader.Options.UseBackColor = true;
            this.colCHECKIN.AppearanceHeader.Options.UseBorderColor = true;
            this.colCHECKIN.AppearanceHeader.Options.UseFont = true;
            this.colCHECKIN.AppearanceHeader.Options.UseForeColor = true;
            this.colCHECKIN.Caption = "Check in";
            this.colCHECKIN.FieldName = "Checkin";
            this.colCHECKIN.Name = "colCHECKIN";
            this.colCHECKIN.Visible = true;
            this.colCHECKIN.VisibleIndex = 3;
            // 
            // colCHECKOUT
            // 
            this.colCHECKOUT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.colCHECKOUT.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.colCHECKOUT.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colCHECKOUT.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colCHECKOUT.AppearanceHeader.Options.UseBackColor = true;
            this.colCHECKOUT.AppearanceHeader.Options.UseBorderColor = true;
            this.colCHECKOUT.AppearanceHeader.Options.UseFont = true;
            this.colCHECKOUT.AppearanceHeader.Options.UseForeColor = true;
            this.colCHECKOUT.Caption = "Check Out";
            this.colCHECKOUT.FieldName = "checkout";
            this.colCHECKOUT.Name = "colCHECKOUT";
            this.colCHECKOUT.Visible = true;
            this.colCHECKOUT.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.gridColumn1.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.Caption = "Room Type";
            this.gridColumn1.FieldName = "ROOMTYPEID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.gridColumn2.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn2.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn2.Caption = "Full name";
            this.gridColumn2.FieldName = "fullname";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.gridColumn6.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.gridColumn6.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn6.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gridColumn6.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn6.AppearanceHeader.Options.UseFont = true;
            this.gridColumn6.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn6.Caption = "Booking ID";
            this.gridColumn6.FieldName = "bookingID";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.gridColumn7.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn7.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.gridColumn7.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn7.AppearanceHeader.Options.UseBorderColor = true;
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn7.Caption = "Book Type ID";
            this.gridColumn7.FieldName = "bookingTypeID";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.occupiedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.occupiedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.occupiedLabel.Location = new System.Drawing.Point(0, 0);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.Size = new System.Drawing.Size(790, 50);
            this.occupiedLabel.TabIndex = 10;
            this.occupiedLabel.Text = "Occupied by";
            this.occupiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.Controls.Add(this.newBooking1);
            this.RightPanel.Controls.Add(this.bookingInformation1);
            this.RightPanel.Controls.Add(this.newEditGuest1);
            this.RightPanel.Controls.Add(this.editGuestInfo1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(790, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(380, 875);
            this.RightPanel.TabIndex = 2;
            // 
            // newBooking1
            // 
            this.newBooking1.BackColor = System.Drawing.Color.White;
            this.newBooking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newBooking1.Location = new System.Drawing.Point(0, 0);
            this.newBooking1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newBooking1.Name = "newBooking1";
            this.newBooking1.Nv = null;
            this.newBooking1.Size = new System.Drawing.Size(380, 875);
            this.newBooking1.TabIndex = 4;
            // 
            // bookingInformation1
            // 
            this.bookingInformation1.BackColor = System.Drawing.Color.White;
            this.bookingInformation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookingInformation1.Location = new System.Drawing.Point(0, 0);
            this.bookingInformation1.Name = "bookingInformation1";
            this.bookingInformation1.Size = new System.Drawing.Size(380, 875);
            this.bookingInformation1.TabIndex = 2;
            // 
            // newEditGuest1
            // 
            this.newEditGuest1.BackColor = System.Drawing.Color.White;
            this.newEditGuest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newEditGuest1.Location = new System.Drawing.Point(0, 0);
            this.newEditGuest1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newEditGuest1.Name = "newEditGuest1";
            this.newEditGuest1.Size = new System.Drawing.Size(380, 875);
            this.newEditGuest1.TabIndex = 12;
            this.newEditGuest1.Visible = false;
            // 
            // editGuestInfo1
            // 
            this.editGuestInfo1.BackColor = System.Drawing.Color.White;
            this.editGuestInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editGuestInfo1.Location = new System.Drawing.Point(0, 0);
            this.editGuestInfo1.Name = "editGuestInfo1";
            this.editGuestInfo1.Size = new System.Drawing.Size(380, 875);
            this.editGuestInfo1.TabIndex = 0;
            this.editGuestInfo1.Visible = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoad.Location = new System.Drawing.Point(520, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(111, 38);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.extra1);
            this.Controls.Add(this.panel5);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(1550, 935);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKINGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private DateNavigator dateNavigator1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.BindingSource bOOKINGBindingSource;
       
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private Extra extra1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colROOMID;
        private DevExpress.XtraGrid.Columns.GridColumn colCHECKIN;
        private DevExpress.XtraGrid.Columns.GridColumn colCHECKOUT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.Label occupiedLabel;
        private System.Windows.Forms.Panel RightPanel;
        private newBooking newBooking1;
        private BookingInformation bookingInformation1;
        private newEditGuest newEditGuest1;
        private editGuestInfo editGuestInfo1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Button btnLoad;
    }
}
