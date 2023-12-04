using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class DB
    {
        string sqlcmd;
        public string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:/StudManagementSystem.mdb";
        public OleDbConnection conn;

        public OleDbCommand cmd;
        public OleDbDataAdapter da;
        public DataTable dt;

        public string errMsg;

        public DB()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = connString;
        }

        public void connect()
        {
            if (Convert.ToString(conn.State) == "Closed")
            {
                conn.Open();
            }
        }
    }
}
