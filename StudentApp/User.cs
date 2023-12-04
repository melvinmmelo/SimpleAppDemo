using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class User
    {
        DB db = new DB();
        public string errMsg = "";

        public bool save(string lname, string fname, string uname, string gender, string email, string address, string password, string registered_at)
        {
            try
            {
                db.cmd = new OleDbCommand("insert into users (last_name, first_name, user_name, gender, email, address, pass_word, registered_at) values (?,?,?,?,?,?,?,?)", db.conn);
                db.connect();

                db.cmd.Parameters.AddWithValue("last_name", lname);
                db.cmd.Parameters.AddWithValue("first_name", fname);
                db.cmd.Parameters.AddWithValue("user_name", uname);
                db.cmd.Parameters.AddWithValue("gender", gender);
                db.cmd.Parameters.AddWithValue("email", email);
                db.cmd.Parameters.AddWithValue("address", address);
                db.cmd.Parameters.AddWithValue("pass_word", password);
                db.cmd.Parameters.AddWithValue("registered_at", registered_at);

                db.cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                errMsg = ex.ToString();
                return false;
            }
        }
    }
}
