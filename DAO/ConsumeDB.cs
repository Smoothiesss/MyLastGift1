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
    public class ConsumeDB
    {
        DataProvider dp;
        SqlDataAdapter da;
        SqlCommand cmd;

        public ConsumeDB()
        {
            dp = new DataProvider();
        }

        public DataTable getByID(string ID, string typeID)
        {
            //creat sql 
            String sql = "select * from Consume where bookingID = " + ID + " and  bookingTypeID = '" + typeID + "'";

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
            string sql = "insert into Consume values (@ID,@bookingTypeID,0,0,0,0,0,0)";
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
        public bool delete(Consume g)
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

        public bool insert(Consume g)
        {
            string sql = "insert into Consume values (@ID,@bookingTypeID,@surchare,@coca,@lavie,@snack,@noodle,@extrabed)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = g.BookingID;
                cmd.Parameters.Add("@bookingTypeID", SqlDbType.Char).Value = g.BookingTypeID;
                cmd.Parameters.Add("@surchare", SqlDbType.Char).Value = g.Surchare;
                cmd.Parameters.Add("@coca", SqlDbType.Char).Value = g.CoCaCola;
                cmd.Parameters.Add("@lavie", SqlDbType.Char).Value = g.Lavie;
                cmd.Parameters.Add("@snack", SqlDbType.Char).Value = g.Snack;
                cmd.Parameters.Add("@noodle", SqlDbType.Char).Value = g.InstantNoodle;
                cmd.Parameters.Add("@extrabed", SqlDbType.Char).Value = g.ExtraBed;
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
