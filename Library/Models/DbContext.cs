using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Library.Models
{
    class DbContext
    {
        string conn_str;
        protected SqlConnection conn;

        public DbContext()
        {
            conn_str = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            conn = new SqlConnection(conn_str);
        }
    }
}
