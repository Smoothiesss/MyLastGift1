namespace MyLastGift
{
    partial class DateNavigator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateNavigator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCalendar);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnCalendar
            // 
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.Location = new System.Drawing.Point(0, 0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(47, 60);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(280, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 60);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(320, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 60);
            this.btnRight.TabIndex = 2;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.White;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(47, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(233, 60);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(47, 22);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.TabStop = false;
            // 
            // DateNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DateNavigator";
            this.Size = new System.Drawing.Size(360, 60);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnCalendar;
    }
}
