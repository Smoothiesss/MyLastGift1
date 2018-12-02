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
    public class BookingTypeDB : DataProvider
    {
        DataProvider dp;
        SqlDataAdapter da;
        SqlCommand cmd;

        public BookingTypeDB()
        {
            dp = new DataProvider();
        }
        public DataTable getByID(String ID)
        {

            //creat sql 
            String sql = "from Guest select * where ID ='" + ID + "'";

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

        public bool insert(BookingType g)
        {
            string sql = "insert into Guest values (@ID, @source)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = g.BookingTypeID;
                cmd.Parameters.Add("@source", SqlDbType.Char).Value = g.Source;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }

        public bool delete(BookingType g)
        {
            string sql = "Delete Guest where GuestID = @id";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = g.BookingTypeID;

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

