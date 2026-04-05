using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FlowerShopManagementSystem2
{
    class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=SAMSUNGGALAXYS1\SQLEXPRESS;Initial Catalog=FlowerShopManagementSystem2;Integrated Security=True";
            return Con;
        }
    }
}
    
