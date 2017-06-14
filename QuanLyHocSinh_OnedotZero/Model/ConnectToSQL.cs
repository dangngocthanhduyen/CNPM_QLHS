using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh_OnedotZero
{
    class ConnectToSQL
    {
        public static SqlConnection conn;
        public ConnectToSQL()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-037FTRO\SQLEXPRESS;Initial Catalog=QLHS_1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

