using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

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
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
