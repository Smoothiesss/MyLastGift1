using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        string connect;

        public DataProvider()
        {
            // connect = "Data Source=DESKTOP-KPSI5PK;Initial Catalog=QLKS;Integrated Security=True";
            //connect = "Data Source=DESKTOP-APSODNG;Initial Catalog=QLKS;Integrated Security=True";
            connect = "Data Source=DESKTOP-HQT2KUE\\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";

        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(connect);
        }


    }
}
