using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSKills
{
    class MainСlass
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionDefault"].ConnectionString;
        SqlConnection connection;
        public  string ErrorMessage;

        public void Connect()
        {
            try
            {
                connection = new SqlConnection(ConnectionString);
                connection.Open();
            }
            catch(Exception exMessage)
            {
                ErrorMessage = exMessage.ToString();
                connection.Close();
            }

        }
             
        public void SelectTable()
        {

        }
    }
}
