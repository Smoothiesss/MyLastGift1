namespace MyLastGift
{
    partial class roomIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomIcon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookTypeLabel = new System.Windows.Forms.Label();
            this.occupiedLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.roomIdLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bookTypeLabel);
            this.panel1.Controls.Add(this.occupiedLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 34);
            this.panel1.TabIndex = 0;
            // 
            // bookTypeLabel
            // 
            this.bookTypeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bookTypeLabel.Image = ((System.Drawing.Image)(resources.GetObject("bookTypeLabel.Image")));
            this.bookTypeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookTypeLabel.Location = new System.Drawing.Point(231, 0);
            this.bookTypeLabel.Name = "bookTypeLabel";
            this.bookTypeLabel.Size = new System.Drawing.Size(119, 34);
            this.bookTypeLabel.TabIndex = 2;
            this.bookTypeLabel.Text = "Type";
            this.bookTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.occupiedLabel.Image = ((System.Drawing.Image)(resources.GetObject("occupiedLabel.Image")));
            this.occupiedLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.occupiedLabel.Location = new System.Drawing.Point(0, 0);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.Size = new System.Drawing.Size(134, 34);
            this.occupiedLabel.TabIndex = 0;
            this.occupiedLabel.Text = "0 days";
            this.occupiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.mainPanel.Controls.Add(this.roomTypeLabel);
            this.mainPanel.Controls.Add(this.mainLabel);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(350, 166);
            this.mainPanel.TabIndex = 2;
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.roomTypeLabel.Image = ((System.Drawing.Image)(resources.GetObject("roomTypeLabel.Image")));
            this.roomTypeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roomTypeLabel.Location = new System.Drawing.Point(0, 35);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(77, 131);
            this.roomTypeLabel.TabIndex = 2;
            // 
            // mainLabel
            // 
            this.mainLabel.AllowDrop = true;
            this.mainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mainLabel.Location = new System.Drawing.Point(60, 35);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(247, 128);
            this.mainLabel.TabIndex = 1;
            this.mainLabel.Text = "Family Deluxe";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.roomIdLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 35);
            this.panel2.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(250, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 35);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "available";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roomIdLabel
            // 
            this.roomIdLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.roomIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.roomIdLabel.ForeColor = System.Drawing.Color.White;
            this.roomIdLabel.Location = new System.Drawing.Point(0, 0);
            this.roomIdLabel.Name = "roomIdLabel";
            this.roomIdLabel.Size = new System.Drawing.Size(105, 35);
            this.roomIdLabel.TabIndex = 2;
            this.roomIdLabel.Text = "Room 102";
            // 
            // roomIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.Name = "roomIcon";
            this.Size = new System.Drawing.Size(350, 200);
            this.panel1.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label occupiedLabel;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label statusLabel;
        public System.Windows.Forms.Label roomIdLabel;
        public System.Windows.Forms.Label mainLabel;
        public System.Windows.Forms.Label roomTypeLabel;
        public System.Windows.Forms.Label bookTypeLabel;
    }
}
