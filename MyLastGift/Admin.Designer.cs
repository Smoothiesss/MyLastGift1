namespace MyLastGift
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportTab1 = new MyLastGift.reportTab();
            this.userManagement1 = new MyLastGift.UserManagement();
            this.adminLeftviewPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.dateNavigator1 = new MyLastGift.DateNavigator();
            this.setPrice1 = new MyLastGift.setPrice();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.adminLeftviewPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.adminLeftviewPanel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1550, 935);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.setPrice1);
            this.panel3.Controls.Add(this.reportTab1);
            this.panel3.Controls.Add(this.userManagement1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(315, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1235, 875);
            this.panel3.TabIndex = 12;
            // 
            // reportTab1
            // 
            this.reportTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportTab1.Location = new System.Drawing.Point(0, 0);
            this.reportTab1.Name = "reportTab1";
            this.reportTab1.Size = new System.Drawing.Size(1235, 875);
            this.reportTab1.TabIndex = 15;
            // 
            // userManagement1
            // 
            this.userManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userManagement1.Location = new System.Drawing.Point(0, 0);
            this.userManagement1.Name = "userManagement1";
            this.userManagement1.Size = new System.Drawing.Size(1235, 875);
            this.userManagement1.TabIndex = 14;
            // 
            // adminLeftviewPanel
            // 
            this.adminLeftviewPanel.BackColor = System.Drawing.Color.White;
            this.adminLeftviewPanel.Controls.Add(this.button1);
            this.adminLeftviewPanel.Controls.Add(this.btnPrice);
            this.adminLeftviewPanel.Controls.Add(this.btnReport);
            this.adminLeftviewPanel.Controls.Add(this.panel1);
            this.adminLeftviewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminLeftviewPanel.Location = new System.Drawing.Point(0, 60);
            this.adminLeftviewPanel.Name = "adminLeftviewPanel";
            this.adminLeftviewPanel.Size = new System.Drawing.Size(315, 875);
            this.adminLeftviewPanel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "USER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.btnPrice.FlatAppearance.BorderSize = 0;
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrice.ForeColor = System.Drawing.Color.White;
            this.btnPrice.Location = new System.Drawing.Point(3, 414);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(310, 48);
            this.btnPrice.TabIndex = 3;
            this.btnPrice.Text = "SET PRICE";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(3, 346);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(310, 48);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 245);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panel5.TabIndex = 10;
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
            // setPrice1
            // 
            this.setPrice1.BackColor = System.Drawing.Color.White;
            this.setPrice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setPrice1.Location = new System.Drawing.Point(0, 0);
            this.setPrice1.Name = "setPrice1";
            this.setPrice1.Size = new System.Drawing.Size(1235, 875);
            this.setPrice1.TabIndex = 16;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "Admin";
            this.Size = new System.Drawing.Size(1550, 935);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.adminLeftviewPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private reportTab reportTab1;
        private UserManagement userManagement1;
        private System.Windows.Forms.Panel adminLeftviewPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private DateNavigator dateNavigator1;
        private setPrice setPrice1;
    }
}
