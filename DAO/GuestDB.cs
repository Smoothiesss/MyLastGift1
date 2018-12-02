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
    public class GuestDB:DataProvider
    {
        DataProvider dp;
        SqlDataAdapter da;
        SqlCommand cmd;

        public GuestDB()
        {
            dp = new DataProvider();
        }
        public DataTable getByID(String ID)
        {

            //creat sql 
            String sql = "select *  from Guest where IDinfo = '" + ID + "'";

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

        public DataTable getStayingGuest()
        {
                //creat sql 
                String sql = "select * from Guest where IDinfo in (select IDinfo from booking where checkin <= getdate() and CHECKOUT > getdate())";

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

        public bool insert(Guest g)
        {
            string sql = "insert into Guest values ( @infoID, @Name, @nationality,@DOB)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@infoID", SqlDbType.Char).Value = g.InfoID;
                cmd.Parameters.Add("@Name", SqlDbType.Char).Value = g.FullName;
                cmd.Parameters.Add("@nationality", SqlDbType.Char).Value = g.Nationality;
                cmd.Parameters.Add("@DOB", SqlDbType.Char).Value = g.DOB;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }

        public bool delete(Guest g)
        {
            string sql = "Delete Guest where IDinfo = @id";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@id", SqlDbType.Char).Value = g.InfoID;

                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool update(Guest oldG, Guest newG)
        {
            string sql = "update GUEST set IDINFO = @newID,Fullname = @newName where idinfo = @oldID";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@newID", SqlDbType.Char).Value = newG.InfoID;
                cmd.Parameters.Add("@newName", SqlDbType.Char).Value = newG.FullName;
                cmd.Parameters.Add("@oldID", SqlDbType.Char).Value = oldG.InfoID;
                cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public int getMaxUnk()
        {
            String sql = "select * from Guest where IDINFO like 'unk%%'";

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
    }
}

