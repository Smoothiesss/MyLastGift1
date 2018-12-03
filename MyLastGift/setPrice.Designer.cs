namespace MyLastGift
{
    partial class setPrice
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
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Standard"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Superior"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Premium"}, 2, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Family Deluxe"}, 3, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Family Suite"}, 4, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setPrice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.largeImage = new System.Windows.Forms.ImageList(this.components);
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.newPriceLabel = new System.Windows.Forms.Label();
            this.newPriceTextBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.materialDivider1);
            this.panel1.Controls.Add(this.newPriceLabel);
            this.panel1.Controls.Add(this.newPriceTextBox);
            this.panel1.Controls.Add(this.materialDivider5);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 300);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.listView1.LargeImageList = this.largeImage;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1235, 575);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // largeImage
            // 
            this.largeImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImage.ImageStream")));
            this.largeImage.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImage.Images.SetKeyName(0, "standardPNG.PNG");
            this.largeImage.Images.SetKeyName(1, "superior.PNG");
            this.largeImage.Images.SetKeyName(2, "premium.PNG");
            this.largeImage.Images.SetKeyName(3, "famDeluxe.PNG");
            this.largeImage.Images.SetKeyName(4, "famSuite.PNG");
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(117, 75);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(300, 2);
            this.materialDivider5.TabIndex = 11;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.priceLabel.Location = new System.Drawing.Point(12, 49);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(99, 23);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price: ";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Location = new System.Drawing.Point(117, 54);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(300, 15);
            this.priceTextBox.TabIndex = 9;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(117, 143);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(300, 2);
            this.materialDivider1.TabIndex = 14;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // newPriceLabel
            // 
            this.newPriceLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.newPriceLabel.Location = new System.Drawing.Point(12, 117);
            this.newPriceLabel.Name = "newPriceLabel";
            this.newPriceLabel.Size = new System.Drawing.Size(99, 23);
            this.newPriceLabel.TabIndex = 13;
            this.newPriceLabel.Text = "New Price:";
            // 
            // newPriceTextBox
            // 
            this.newPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPriceTextBox.Location = new System.Drawing.Point(117, 122);
            this.newPriceTextBox.Name = "newPriceTextBox";
            this.newPriceTextBox.Size = new System.Drawing.Size(300, 15);
            this.newPriceTextBox.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Location = new System.Drawing.Point(117, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 38);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // setPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "setPrice";
            this.Size = new System.Drawing.Size(1235, 875);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList largeImage;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label newPriceLabel;
        private System.Windows.Forms.TextBox newPriceTextBox;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button btnAdd;
    }
}
