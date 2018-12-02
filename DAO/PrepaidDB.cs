using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PrepaidDB
    {
        DataProvider dp;
        SqlDataAdapter da;
        SqlCommand cmd;

        public PrepaidDB()
        {
            dp = new DataProvider();
        }

        public DataTable getByID(string ID, string typeID)
        {
            //creat sql 
            String sql = "select * from Prepaid where bookingID = " + ID + " and  bookingTypeID = '" + typeID + "'";

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


        public bool insertNew(Booking g)
        {
            string sql = "insert into Prepaid(bookingid,bookingtypeID) values (@ID,@bookingTypeID)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = g.BookingID;
                cmd.Parameters.Add("@bookingTypeID", SqlDbType.Char).Value = g.BookingTypeID;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }
        public bool delete(Prepaid g)
        {
            string sql = "delete Prepaid where bookingID = @ID and BookingTypeID = @bookingTypeID";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = g.BookingID;
                cmd.Parameters.Add("@bookingTypeID", SqlDbType.Char).Value = g.BookingTypeID;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }
        public bool delete(Booking g)
        {
            string sql = "delete Consume where bookingID = @ID and BookingTypeID = @bookingTypeID";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = g.BookingID;
                cmd.Parameters.Add("@bookingTypeID", SqlDbType.Char).Value = g.BookingTypeID;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }

        public bool insert(Prepaid g)
        {
            string sql = "insert into Consume values (@ID,@bookingTypeID,@amount,@Dates,@nvID)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = g.BookingID;
                cmd.Parameters.Add("@bookingTypeID", SqlDbType.Char).Value = g.BookingTypeID;
                cmd.Parameters.Add("@amount", SqlDbType.Char).Value = g.Amount;
                cmd.Parameters.Add("@Dates", SqlDbType.Char).Value = g.DateReceive;
                cmd.Parameters.Add("@nvID", SqlDbType.Char).Value = g.NhanvienID;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }
    }
}


