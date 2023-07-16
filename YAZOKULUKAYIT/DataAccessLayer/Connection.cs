using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connection
    {
        public static SqlConnection sqlConn = new SqlConnection(@"Data Source=DESKTOP-7GNS0OU\SQLEXPRESS;
        Initial Catalog=dbo_YazOkuluKayit;Integrated Security=True");
    }
}