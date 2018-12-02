namespace MyLastGift
{
    partial class roomListView
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
            this.flowLayoutRoomList = new System.Windows.Forms.FlowLayoutPanel();
            this.roomTypeContainer = new System.Windows.Forms.Panel();
            this.roomTypeLabel = new System.Windows.Forms.Label();
            this.roomTypeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutRoomList
            // 
            this.flowLayoutRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutRoomList.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutRoomList.Name = "flowLayoutRoomList";
            this.flowLayoutRoomList.Size = new System.Drawing.Size(1170, 590);
            this.flowLayoutRoomList.TabIndex = 5;
            // 
            // roomTypeContainer
            // 
            this.roomTypeContainer.Controls.Add(this.roomTypeLabel);
            this.roomTypeContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomTypeContainer.Location = new System.Drawing.Point(0, 0);
            this.roomTypeContainer.Name = "roomTypeContainer";
            this.roomTypeContainer.Size = new System.Drawing.Size(1170, 60);
            this.roomTypeContainer.TabIndex = 4;
            // 
            // roomTypeLabel
            // 
            this.roomTypeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.roomTypeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.roomTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.roomTypeLabel.Location = new System.Drawing.Point(0, 0);
            this.roomTypeLabel.Name = "roomTypeLabel";
            this.roomTypeLabel.Size = new System.Drawing.Size(318, 60);
            this.roomTypeLabel.TabIndex = 0;
            this.roomTypeLabel.Text = "Single";
            this.roomTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutRoomList);
            this.Controls.Add(this.roomTypeContainer);
            this.Name = "roomListView";
            this.Size = new System.Drawing.Size(1170, 650);
            this.roomTypeContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutRoomList;
        public System.Windows.Forms.Panel roomTypeContainer;
        public System.Windows.Forms.Label roomTypeLabel;
    }
}
