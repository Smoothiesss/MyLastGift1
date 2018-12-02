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
    public class RoomTypeDB:DataProvider
    {

        DataProvider dp;
        SqlDataAdapter da;
        SqlCommand cmd;
        public RoomTypeDB()
        {
            dp = new DataProvider();
        }
        public DataTable getByID(String ID)
        {

            //creat sql 
            String sql = "select * from RoomType where RoomtypeID = '" + ID + "'";

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

        public bool insert(RoomType g)
        {
            string sql = "insert into RoomType values (@ID, @price)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = g.RoomTypeID;
                cmd.Parameters.Add("@price", SqlDbType.Char).Value = g.Price;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }

        public bool delete(RoomType g)
        {
            string sql = "Delete RoomType where RoomTypeID = @id";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = g.RoomTypeID;

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public int getPrice(string roomTypeID)
        {
            string sql = "select price from roomType where roomTypeID = @id";
            int ans = 0;
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = roomTypeID;

                ans = (int)cmd.ExecuteScalar();

                conn.Close();

            }
            catch(Exception)
            {
                return ans;
            }
            return ans;
        }
    }
}
