using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DO_AN2
{
    class SqlServer
    {
        public SqlConnection conn;
        public void MoKetNoi()
        {
            conn = new SqlConnection("server=UCHINKA\\SQLEXPRESS;database=SHOP_QUAN_AO;integrated security=SSPI");
            conn.Open();
        }
        public void DongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
