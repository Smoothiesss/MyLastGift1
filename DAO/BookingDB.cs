using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class BookingDB : DataProvider
    {

        DataProvider dp;
        SqlDataAdapter da;
        SqlCommand cmd;

        public BookingDB()
        {
            dp = new DataProvider();
        }
        public DataTable getbyID(String ID, string typeID)
        {

            //creat sql 
            String sql = "select * from Booking where bookingID = " + ID + " and  bookingTypeID = '" + typeID + "'";

            // make connection to database
            SqlConnection conn = dp.getConnection();

            //Make sql adapeter
            da = new SqlDataAdapter(sql, conn);

            //open connect
            conn.Open();

            //get dataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public bool insert(Booking g)
        {
            string sql = "insert into Booking values (@ID, @roomID, @guestID,@bookingTypeID,@NhanVienID,@Date,@checkIn,@checkOut,@breakfast)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                int tmp = 0;
                if (g.BreakFast)
                    tmp = 1;
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = g.BookingID;
                cmd.Parameters.Add("@roomID", SqlDbType.Char).Value = g.RoomID;
                cmd.Parameters.Add("@guestID", SqlDbType.Char).Value = g.GuestID;
                cmd.Parameters.Add("@bookingTypeID", SqlDbType.Char).Value = g.BookingTypeID;
                cmd.Parameters.Add("@NhanVienID", SqlDbType.Int).Value = g.NhanVienID;
                cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = g.Date;
                cmd.Parameters.Add("@checkIn", SqlDbType.DateTime).Value = g.CheckIn;
                cmd.Parameters.Add("@checkOut", SqlDbType.DateTime).Value = g.CheckOut;
                cmd.Parameters.Add("@breakfast", SqlDbType.Bit).Value = tmp;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
            ConsumeDB cDB = new ConsumeDB();
            return cDB.insertNew(g);
        }

        public bool delete(Booking g)
        {
            string sql = "Delete Booking where BookingID = @id and bookngTypeID = @typeID";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = g.BookingID;
                cmd.Parameters.Add("@typeid", SqlDbType.Char).Value = g.BookingTypeID;
                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception)
            {
                return false;
            }
            ConsumeDB cDB = new ConsumeDB();
            return cDB.delete(g);
        }

        public DataTable getStatus(string id, DateTime d)
        {
            string stringD = d.ToString("M/d/yyyy HH:mm:ss");
            //creat sql 
            String sql = "select * from booking where Roomid = '" + id + "'and checkin <= '" + stringD + "' and CHECKOUT > '" + stringD + "'";
            // make connection to database
            SqlConnection conn = dp.getConnection();

            //Make sql adapeter
            da = new SqlDataAdapter(sql, conn);

            //open connect
            conn.Open();

            //get dataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public DataTable getByDate(DateTime date)
        {
            string dates = date.ToString("M/d/yyyy HH:mm:ss");
            //creat sql 
            String sql = @"select  bookingID,fullname , booking.RoomID ,ROOMTYPEID,Checkin,checkout,bookingTypeID 
from (Booking left join GUEST on booking.idinfo = guest.idinfo) left join room on booking.ROOMID = ROOM.ROOMID
where checkin <= '"+ dates +"' and CHECKOUT >= '"+ dates+"'";
            Console.WriteLine(sql);
            // make connection to database
            SqlConnection conn = dp.getConnection();

            //Make sql adapeter
            da = new SqlDataAdapter(sql, conn);

            //open connect
            conn.Open();

            //get dataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public int updateBookingID()
        {

            //creat sql 
            String sql = "select * from Booking where bookingTypeID = '003'";

            // make connection to database
            SqlConnection conn = dp.getConnection();

            //Make sql adapeter
            da = new SqlDataAdapter(sql, conn);

            //open connect
            conn.Open();

            //get dataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            return dt.Rows.Count;
        }

        public DataTable getList(DateTime d)
        {
            DateTime bgin = d.AddDays(-15);
            DateTime end = d.AddDays(+15);
            string bdates = bgin.ToString("M/d/yyyy hh:mm:ss");
            string edates = end.ToString("M/d/yyyy hh:mm:ss");
            //creat sql 
            String sql = "select * from booking where checkin >= '" + bdates + "' or CHECKOUT <= '" + edates + "'";


            // make connection to database
            SqlConnection conn = dp.getConnection();

            //Make sql adapeter
            da = new SqlDataAdapter(sql, conn);

            //open connect
            conn.Open();

            //get dataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public DataTable getStatusFromDate(string id, DateTime dIn, DateTime dOut)
        {
            string stringDin = dIn.ToString("M/d/yyyy HH:mm:ss");
            string stringDout = dOut.ToString("M/d/yyyy HH:mm:ss");
            //creat sql 
            String sql = @"select * from booking 
            where ROOMID = '"+id+@"' and 
            ((CHECKIN <= '"+stringDin + @"' AND CHECKOUT >= '" + stringDin + @"' ) 
           OR (CHECKIN < '" + stringDout + @"' AND CHECKOUT >= '" + stringDout + @"' ) 
           OR ('" + stringDin + @"' <= CHECKIN AND '" + stringDout + @"' >= CHECKIN))";
            // make connection to database
            SqlConnection conn = dp.getConnection();

            //Make sql adapeter
            da = new SqlDataAdapter(sql, conn);

            //open connect
            conn.Open();

            //get dataTable
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            return dt;
        }
    }
}
