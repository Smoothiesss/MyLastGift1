using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Data;

namespace BUS
{
    public class PayBUS
    {
        BookingBUS bBUS;
        RoomBUS rBUS;
        GuestBUS gBUS;
        ConsumeBUS cBUS;
        PrepaidDB pDB;


        public PayBUS()
        {
            bBUS = new BookingBUS();
            rBUS = new RoomBUS();
            gBUS = new GuestBUS();
            cBUS = new ConsumeBUS();
            pDB = new PrepaidDB();
        }
        private Prepaid dataTableToPrepaid(DataRow dr)
        {
            int ID = (int)(dr["bookingID"]);  // Beware of the possible conversion errors due to type mismatches
            string bookingType = (dr["bookingtypeid"]).ToString();
            int amount = (int)(dr["AMOUNT"]);
            DateTime dates = (DateTime)(dr["dateRecive"]);
            int nhanvien = (int)(dr["nhanvienid"]);
            Console.WriteLine(ID);
            return new Prepaid(ID, bookingType,amount,dates,nhanvien);
        }

        public Prepaid getPrepaid(Booking b)
        {
            DataTable dt = pDB.getByID(b.BookingID.ToString(),b.BookingTypeID);
            Prepaid ans = new Prepaid();
            foreach (DataRow dr in dt.Rows)
            {

                ans = dataTableToPrepaid(dr);
            }
            return ans;
        }

        public void PayingSheet(Booking b)
        {
            Room r = rBUS.getRoomByID(b.RoomID);
            RoomType rt= rBUS.getRoomTypeByID(r.RoomType);
            Guest g = gBUS.getGuestByID(b.GuestID);
            Consume c = cBUS.getConsumeByID(b.BookingID.ToString(), b.BookingTypeID);
            Prepaid p = getPrepaid(b);
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
            xlRange.Cells[12, 5].Value2 = c.Surchare.ToString();
            xlRange.Cells[13, 5].Value2 = c.CoCaCola.ToString();
            xlRange.Cells[14, 5].Value2 = c.Lavie.ToString();
            xlRange.Cells[15, 5].Value2 = c.Snack.ToString();
            xlRange.Cells[16, 5].Value2 = c.InstantNoodle.ToString();
            xlRange.Cells[17, 5].Value2 = c.ExtraBed.ToString();
            xlRange.Cells[19, 7].Value2 = p.Amount.ToString();
            string sNewFileName = Path.Combine(Path.GetDirectoryName(@"C:\Users\ZunNie\Desktop\"),
                string.Concat(r.RoomID, "_", DateTime.Today.ToString("ddmmyyyy"), ".xlsx"));
            xlWorkbook.SaveAs(sNewFileName);
            xlApp.Quit();
        }
    }
}
