namespace MyLastGift
{
    partial class currentStatus
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2018, 11, 19, 0, 0, 0, 0), new object[] {
            ((object)(5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2018, 11, 20, 0, 0, 0, 0), new object[] {
            ((object)(8D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2018, 11, 21, 0, 0, 0, 0), new object[] {
            ((object)(7D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2018, 11, 22, 0, 0, 0, 0), new object[] {
            ((object)(9D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2018, 11, 23, 0, 0, 0, 0), new object[] {
            ((object)(2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2018, 11, 24, 0, 0, 0, 0), new object[] {
            ((object)(4D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2018, 11, 25, 0, 0, 0, 0), new object[] {
            ((object)(2D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint(new System.DateTime(2018, 11, 26, 0, 0, 0, 0), new object[] {
            ((object)(3D))});
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartOccupied = new DevExpress.XtraCharts.ChartControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupied)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartOccupied
            // 
            this.chartOccupied.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartOccupied.DataBindings = null;
            xyDiagram1.AxisX.AutoScaleBreaks.Enabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "11/23/2018 00:00:00.000";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "11/19/2018 00:00:00.000";
            xyDiagram1.AxisX.VisualRange.SideMarginsValue = 0.5D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartOccupied.Diagram = xyDiagram1;
            this.chartOccupied.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartOccupied.Legend.Name = "Default Legend";
            this.chartOccupied.Location = new System.Drawing.Point(0, 0);
            this.chartOccupied.Name = "chartOccupied";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.LegendName = "Default Legend";
            series1.Name = "Occupied";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8});
            sideBySideBarSeriesView1.BarWidth = 0.4D;
            series1.View = sideBySideBarSeriesView1;
            this.chartOccupied.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartOccupied.Size = new System.Drawing.Size(876, 450);
            this.chartOccupied.TabIndex = 1;
            chartTitle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            chartTitle1.Text = "Occupied per day";
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            chartTitle1.WordWrap = true;
            this.chartOccupied.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartOccupied.Click += new System.EventHandler(this.chartOccupied_Click_1);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 26;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1550, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1550, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 450);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1550, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 450);
            // 
            // currentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartOccupied);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "currentStatus";
            this.Size = new System.Drawing.Size(1550, 450);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupied)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraCharts.ChartControl chartOccupied;
    }
}
