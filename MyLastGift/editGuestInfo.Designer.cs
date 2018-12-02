namespace MyLastGift
{
    partial class editGuestInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editGuestInfo));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.guestInfoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookingTypeComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.nationTextBox = new System.Windows.Forms.TextBox();
            this.guestIdTextBox = new System.Windows.Forms.TextBox();
            this.guestNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTypeComboBox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.btnClose);
            this.headerPanel.Controls.Add(this.guestInfoLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(380, 50);
            this.headerPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(330, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guestInfoLabel
            // 
            this.guestInfoLabel.BackColor = System.Drawing.Color.White;
            this.guestInfoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.guestInfoLabel.Location = new System.Drawing.Point(0, 0);
            this.guestInfoLabel.Name = "guestInfoLabel";
            this.guestInfoLabel.Size = new System.Drawing.Size(240, 50);
            this.guestInfoLabel.TabIndex = 1;
            this.guestInfoLabel.Text = "EDIT GUEST INFORMATION";
            this.guestInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookingTypeComboBox);
            this.panel1.Controls.Add(this.materialDivider4);
            this.panel1.Controls.Add(this.materialDivider3);
            this.panel1.Controls.Add(this.materialDivider2);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.nationTextBox);
            this.panel1.Controls.Add(this.guestIdTextBox);
            this.panel1.Controls.Add(this.guestNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 509);
            this.panel1.TabIndex = 1;
            // 
            // bookingTypeComboBox
            // 
            this.bookingTypeComboBox.Location = new System.Drawing.Point(9, 193);
            this.bookingTypeComboBox.Name = "bookingTypeComboBox";
            this.bookingTypeComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bookingTypeComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bookingTypeComboBox.Properties.Items.AddRange(new object[] {
            "Agoda",
            "Booking.com",
            "Free"});
            this.bookingTypeComboBox.Size = new System.Drawing.Size(370, 20);
            this.bookingTypeComboBox.TabIndex = 4;
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(9, 295);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(365, 3);
            this.materialDivider4.TabIndex = 3;
            this.materialDivider4.Text = "materialDivider1";
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(9, 219);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(365, 3);
            this.materialDivider3.TabIndex = 3;
            this.materialDivider3.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(9, 143);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(365, 3);
            this.materialDivider2.TabIndex = 3;
            this.materialDivider2.Text = "materialDivider1";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(9, 73);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(365, 3);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // nationTextBox
            // 
            this.nationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nationTextBox.Location = new System.Drawing.Point(9, 274);
            this.nationTextBox.Name = "nationTextBox";
            this.nationTextBox.Size = new System.Drawing.Size(367, 15);
            this.nationTextBox.TabIndex = 1;
            // 
            // guestIdTextBox
            // 
            this.guestIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestIdTextBox.Location = new System.Drawing.Point(9, 122);
            this.guestIdTextBox.Name = "guestIdTextBox";
            this.guestIdTextBox.Size = new System.Drawing.Size(365, 15);
            this.guestIdTextBox.TabIndex = 1;
            // 
            // guestNameTextBox
            // 
            this.guestNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guestNameTextBox.Location = new System.Drawing.Point(9, 52);
            this.guestNameTextBox.Name = "guestNameTextBox";
            this.guestNameTextBox.Size = new System.Drawing.Size(367, 15);
            this.guestNameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nation:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Type:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nameLabel.Location = new System.Drawing.Point(0, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(290, 50);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(72, 597);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // editGuestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Name = "editGuestInfo";
            this.Size = new System.Drawing.Size(380, 675);
            this.headerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTypeComboBox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label guestInfoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox guestNameTextBox;
        public System.Windows.Forms.TextBox nationTextBox;
        public System.Windows.Forms.TextBox guestIdTextBox;
        public DevExpress.XtraEditors.ComboBoxEdit bookingTypeComboBox;
    }
}
