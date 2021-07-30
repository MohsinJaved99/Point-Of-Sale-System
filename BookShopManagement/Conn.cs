using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Odbc;

namespace BookShopManagement
{
    class Conn
    {
        public static MySqlConnection ConnectionString { get; set; }
        public Conn()
        {
            ConnectionString = new MySqlConnection("SERVER=23.111.150.106;PORT=3306;DATABASE=makkahel_software;UID=makkahel;PASSWORD=7yisHT(3GY0z+3;");
        }

        public string checkConnection()
        {
             string MyConString = "DRIVER={MySQL ODBC 5.2 ANSI Driver};" +
             "SERVER=23.111.150.106;" +
             "DATABASE=makkahel_software;" +
             "UID=makkahel;" +
             "PASSWORD=7yisHT(3GY0z+3;";

                //Connect to MySQL using Connector/ODBC
                OdbcConnection MyConnection = new OdbcConnection(MyConString);

                MyConnection.Open();
             ConnectionString.Open();

            var temp = ConnectionString.State.ToString();
            if (ConnectionString.State == ConnectionState.Open && temp == "Open")
            {
                return "Connection working.";
            }
            else
            {
                return "Please check connection string";

            }
        }
    }
}