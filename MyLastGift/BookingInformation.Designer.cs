namespace MyLastGift
{
    partial class BookingInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookID = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.bookingIdLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.roomTypeComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.nationTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.reservationContainer = new System.Windows.Forms.Panel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.bookingTypeCombobox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.reservationLabel = new System.Windows.Forms.Label();
            this.roomIdLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.toDayLabel = new System.Windows.Forms.Label();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.extraBtn = new System.Windows.Forms.Button();
            this.btnPrepay = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.statusComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeComboBox.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.reservationContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTypeCombobox.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookID);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.bookingIdLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 60);
            this.panel1.TabIndex = 0;
            // 
            // bookID
            // 
            this.bookID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bookID.Location = new System.Drawing.Point(120, 2);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(56, 32);
            this.bookID.TabIndex = 2;
            this.bookID.Text = "13";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonClose.Location = new System.Drawing.Point(331, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(49, 60);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // bookingIdLabel
            // 
            this.bookingIdLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bookingIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bookingIdLabel.Location = new System.Drawing.Point(0, 0);
            this.bookingIdLabel.Name = "bookingIdLabel";
            this.bookingIdLabel.Size = new System.Drawing.Size(213, 60);
            this.bookingIdLabel.TabIndex = 0;
            this.bookingIdLabel.Text = "Booking #";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialDivider1);
            this.panel2.Controls.Add(this.roomTypeComboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 50);
            this.panel2.TabIndex = 2;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider1.Location = new System.Drawing.Point(107, 48);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(273, 2);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomTypeComboBox.Location = new System.Drawing.Point(113, 15);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.roomTypeComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.roomTypeComboBox.Properties.Items.AddRange(new object[] {
            "Standard",
            "Superior No Breakfast",
            "Superior With Breakfast",
            "Deluxe",
            "Premium Deluxe",
            "Family Suit"});
            this.roomTypeComboBox.Size = new System.Drawing.Size(253, 20);
            this.roomTypeComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materialDivider4);
            this.panel3.Controls.Add(this.nationTB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 61);
            this.panel3.TabIndex = 3;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(257, 53);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(120, 2);
            this.materialDivider4.TabIndex = 6;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // nationTB
            // 
            this.nationTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nationTB.Location = new System.Drawing.Point(265, 29);
            this.nationTB.Name = "nationTB";
            this.nationTB.Size = new System.Drawing.Size(100, 15);
            this.nationTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(261, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "National:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.guestNameLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 61);
            this.panel4.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(213, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(38, 61);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.AllowDrop = true;
            this.guestNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.guestNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guestNameLabel.Location = new System.Drawing.Point(0, 0);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(235, 61);
            this.guestNameLabel.TabIndex = 0;
            this.guestNameLabel.Text = "Nguyen Quoc Cuong";
            this.guestNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guestNameLabel.Click += new System.EventHandler(this.guestNameLabel_Click);
            // 
            // reservationContainer
            // 
            this.reservationContainer.Controls.Add(this.materialDivider3);
            this.reservationContainer.Controls.Add(this.bookingTypeCombobox);
            this.reservationContainer.Controls.Add(this.reservationLabel);
            this.reservationContainer.Controls.Add(this.roomIdLabel);
            this.reservationContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservationContainer.Location = new System.Drawing.Point(0, 171);
            this.reservationContainer.Name = "reservationContainer";
            this.reservationContainer.Size = new System.Drawing.Size(380, 75);
            this.reservationContainer.TabIndex = 4;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(221, 54);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(145, 2);
            this.materialDivider3.TabIndex = 3;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // bookingTypeCombobox
            // 
            this.bookingTypeCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingTypeCombobox.Location = new System.Drawing.Point(221, 28);
            this.bookingTypeCombobox.Name = "bookingTypeCombobox";
            this.bookingTypeCombobox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bookingTypeCombobox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bookingTypeCombobox.Properties.Items.AddRange(new object[] {
            "Agoda",
            "Booking.com",
            "Free"});
            this.bookingTypeCombobox.Size = new System.Drawing.Size(139, 20);
            this.bookingTypeCombobox.TabIndex = 2;
            // 
            // reservationLabel
            // 
            this.reservationLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.reservationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reservationLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reservationLabel.Location = new System.Drawing.Point(113, 0);
            this.reservationLabel.Name = "reservationLabel";
            this.reservationLabel.Size = new System.Drawing.Size(267, 75);
            this.reservationLabel.TabIndex = 1;
            this.reservationLabel.Text = "Booking type:";
            this.reservationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomIdLabel
            // 
            this.roomIdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomIdLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.roomIdLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.roomIdLabel.Location = new System.Drawing.Point(0, 0);
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(380, 75);
            this.roomIdLabel.TabIndex = 0;
            this.roomIdLabel.Text = "Room 102";
            this.roomIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomIdLabel.Click += new System.EventHandler(this.roomIdLabel_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 246);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 201);
            this.panel5.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.toDayLabel);
            this.panel9.Controls.Add(this.fromDateLabel);
            this.panel9.Controls.Add(this.daysLabel);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(380, 151);
            this.panel9.TabIndex = 1;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // toDayLabel
            // 
            this.toDayLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toDayLabel.Location = new System.Drawing.Point(62, 76);
            this.toDayLabel.Name = "toDayLabel";
            this.toDayLabel.Size = new System.Drawing.Size(100, 23);
            this.toDayLabel.TabIndex = 7;
            this.toDayLabel.Text = "04/12/2018";
            this.toDayLabel.Click += new System.EventHandler(this.toDayLabel_Click);
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fromDateLabel.Location = new System.Drawing.Point(62, 29);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(100, 23);
            this.fromDateLabel.TabIndex = 6;
            this.fromDateLabel.Text = "27/11/2018";
            this.fromDateLabel.Click += new System.EventHandler(this.fromDateLabel_Click);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.daysLabel.Location = new System.Drawing.Point(295, 29);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(19, 23);
            this.daysLabel.TabIndex = 5;
            this.daysLabel.Text = "1";
            this.daysLabel.Click += new System.EventHandler(this.daysLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(3, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "To:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(3, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "From:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(380, 50);
            this.panel7.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(274, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Days";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Occupied";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.extraBtn);
            this.panel6.Controls.Add(this.btnPrepay);
            this.panel6.Controls.Add(this.btnBook);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 673);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(380, 202);
            this.panel6.TabIndex = 6;
            // 
            // extraBtn
            // 
            this.extraBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.extraBtn.FlatAppearance.BorderSize = 0;
            this.extraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extraBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.extraBtn.Location = new System.Drawing.Point(209, 28);
            this.extraBtn.Name = "extraBtn";
            this.extraBtn.Size = new System.Drawing.Size(157, 38);
            this.extraBtn.TabIndex = 5;
            this.extraBtn.Text = "Extra";
            this.extraBtn.UseVisualStyleBackColor = false;
            this.extraBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPrepay
            // 
            this.btnPrepay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.btnPrepay.FlatAppearance.BorderSize = 0;
            this.btnPrepay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrepay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrepay.Location = new System.Drawing.Point(7, 28);
            this.btnPrepay.Name = "btnPrepay";
            this.btnPrepay.Size = new System.Drawing.Size(145, 38);
            this.btnPrepay.TabIndex = 5;
            this.btnPrepay.Text = "Prepay";
            this.btnPrepay.UseVisualStyleBackColor = false;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBook.Location = new System.Drawing.Point(7, 84);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(359, 38);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Cash";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.priceLabel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 447);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(380, 75);
            this.panel8.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(118, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 75);
            this.label11.TabIndex = 0;
            this.label11.Text = "Payments";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priceLabel
            // 
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.priceLabel.Location = new System.Drawing.Point(0, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(118, 75);
            this.priceLabel.TabIndex = 0;
            this.priceLabel.Text = "$500";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceLabel.Click += new System.EventHandler(this.priceLabel_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.materialDivider2);
            this.panel10.Controls.Add(this.statusComboBox);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 522);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(380, 50);
            this.panel10.TabIndex = 7;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialDivider2.Location = new System.Drawing.Point(80, 48);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(300, 2);
            this.materialDivider2.TabIndex = 2;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.Location = new System.Drawing.Point(86, 15);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.statusComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusComboBox.Properties.Items.AddRange(new object[] {
            "Actual",
            "Reservation",
            "Cancelled",
            "Checked-out",
            "Check-in",
            "No Show"});
            this.statusComboBox.Size = new System.Drawing.Size(280, 20);
            this.statusComboBox.TabIndex = 1;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 50);
            this.label12.TabIndex = 0;
            this.label12.Text = "Status: ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BookingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.reservationContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BookingInformation";
            this.Size = new System.Drawing.Size(380, 875);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeComboBox.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.reservationContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingTypeCombobox.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bookingIdLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel reservationContainer;
        private System.Windows.Forms.Label reservationLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel10;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.Label label12;
        public DevExpress.XtraEditors.ComboBoxEdit roomTypeComboBox;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Label guestNameLabel;
        public System.Windows.Forms.Label roomIdLabel;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Label daysLabel;
        public DevExpress.XtraEditors.ComboBoxEdit statusComboBox;
        public System.Windows.Forms.Label toDayLabel;
        public System.Windows.Forms.Label fromDateLabel;
        public System.Windows.Forms.Label bookID;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        public DevExpress.XtraEditors.ComboBoxEdit bookingTypeCombobox;
        public System.Windows.Forms.Button btnPrepay;
        public System.Windows.Forms.Button btnBook;
        public System.Windows.Forms.Button extraBtn;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Button buttonClose;
        public System.Windows.Forms.TextBox nationTB;
    }
}
