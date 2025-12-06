using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }

        public object GetAdminPassword(string username)
        {
            // Queries the password for the given username
            string query = "";// TODO:: DO the query After Making the DataBase
            return dbMan.ExecuteScalar(query);
        }
        public int addUser(string username , string Email, string name , string password)
        {
            string query = "";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getShows(string username,string list)
        {
            string query = "";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateRating(string show,string rating,string username)
        {
            string query = "";
             return dbMan.ExecuteNonQuery(query);
        }
        public DataTable getAllist(string username)
        {
            string query = "";
            return dbMan.ExecuteReader(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

    }
}
