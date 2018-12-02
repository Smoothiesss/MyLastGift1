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
    public class RoomDB:DataProvider
    {
        DataProvider dp;
        SqlDataAdapter da;
        SqlCommand cmd;
        public RoomDB()
        {
            dp = new DataProvider();
        }
        public DataTable getAll()
        {

            //creat sql 
            String sql = "select * from Room";

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
        public DataTable getByID(string ID)
        {

            //creat sql 
            String sql = "select * from Room where roomid = '" + ID +"'";

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
        public bool insert(Room g)
        {
            string sql = "insert into Room values (@ID, @status,@num,@type)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@ID", SqlDbType.Char).Value = g.RoomID;
                cmd.Parameters.Add("@status", SqlDbType.Char).Value = g.Status;
                cmd.Parameters.Add("@num", SqlDbType.Char).Value = g.NumPerson;
                cmd.Parameters.Add("@type", SqlDbType.Char).Value = g.RoomType;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }

        public bool delete(Room g)
        {
            string sql = "Delete Room where RoomID = @id";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = g.RoomID;

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public DataTable getByRoomTypeID(string ID)
        {

            //creat sql 
            String sql = "select * from Room where roomtypeid = '" + ID + "'";

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
