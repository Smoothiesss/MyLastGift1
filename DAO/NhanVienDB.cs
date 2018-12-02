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
    public class NhanVienDB : DataProvider
    {
        DataProvider dp;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NhanVienDB()
        {
            dp = new DataProvider();
        }
        public DataTable getAccount(String account)
        {

            //creat sql 
            String sql = "from NHANVIEN select * where Account == " + account;

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

        public bool insert(NhanVien nv)
        {
            string sql = "insert into NHANVIEN values (@maNV,@tenNV,@startdate,@roles , @account, @password)";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = nv.NhanVienID;
                cmd.Parameters.Add("@tenNV", SqlDbType.Char).Value = nv.TenNv;
                cmd.Parameters.Add("@startdate", SqlDbType.Char).Value = nv.StartDate;
                cmd.Parameters.Add("@roles", SqlDbType.Char).Value = nv.Roles;
                cmd.Parameters.Add("@account", SqlDbType.Char).Value = nv.Account;
                cmd.Parameters.Add("@password", SqlDbType.Char).Value = nv.Password;
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception e)
            {

                return false;
            }
            return true;
        }

        public bool CheckLogin(string account, string pass)
        {

            //creat sql 
            String sql = "select * from NHANVIEN where Account = '" + account + "' and Password ='" + pass + "'";

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
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        public bool delete(NhanVien nv)
        {
            string sql = "Delete NHANVIEN where NhanVienID = @maNV";
            SqlConnection conn = dp.getConnection();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add("@maNV", SqlDbType.Char).Value = nv.NhanVienID;

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
