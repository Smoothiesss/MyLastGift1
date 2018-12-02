using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BUS
{
    public class PayBUS
    {
        BookingBUS bBUS;
        RoomBUS rBUS;
        GuestBUS gBUS;


        public PayBUS()
        {
            bBUS = new BookingBUS();
            rBUS = new RoomBUS();
            gBUS = new GuestBUS();
        }

        public void PayingSheet(Booking b)
        {
            Room r = rBUS.getRoomByID(b.RoomID);
            RoomType rt= rBUS.getRoomTypeByID(r.RoomType);
            Guest g = gBUS.getGuestByID(b.GuestID);
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Users\Zunnie\Desktop\MyLastGift\BUS\thanhtoan.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            xlRange.Cells[5, 3].Value2 = g.FullName;
            xlRange.Cells[5, 6].Value2 = g.DOB.ToString("MM/dd/yyyy");
            xlRange.Cells[6, 4].Value2 = g.InfoID;
            xlRange.Cells[6, 6].Value2 = g.Nationality;
            xlRange.Cells[7, 3].Value2 = "'"+b.RoomID;
            xlRange.Cells[7, 6].Value2 = rt.Price.ToString();
            xlRange.Cells[8, 4].Value2 = b.CheckIn.ToString("MM/dd/yyyy");
            xlRange.Cells[8, 7].Value2 = b.CheckIn.ToString("hh:mm");
            xlRange.Cells[9, 4].Value2 = b.CheckOut.ToString("MM/dd/yyyy");
            xlRange.Cells[9, 7].Value2 = b.CheckOut.ToString("hh:mm");
            TimeSpan span = b.CheckOut - b.CheckIn;
            double days =   Math.Ceiling((double)span.TotalHours / 24);
            xlRange.Cells[11, 5].Value2 = days.ToString();
            xlRange.Cells[11, 6].Value2 = rt.Price.ToString();
            string sNewFileName = Path.Combine(Path.GetDirectoryName(@"C:\Users\ZunNie\Desktop\"),
                string.Concat(r.RoomID, "_", DateTime.Today.ToString("ddmmyyyy"), ".xlsx"));
            xlWorkbook.SaveAs(sNewFileName);
            xlApp.Quit();
        }
    }
}
