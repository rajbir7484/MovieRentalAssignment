using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalAssignment.DataAccessLayer
{
    public class DataBaseConnection
    {
        private static SqlConnection dbCon = null;

        private DataBaseConnection() { }

        // Connection to database
        public static SqlConnection OpenConnection()
        {
            if (dbCon == null)
            {
                dbCon = new SqlConnection();
                dbCon.ConnectionString = @"Data Source=.\SQLEXPRESS;integrated security=true;initial catalog=MovieRentalSys";
                dbCon.Open();
            }

            return dbCon;
        }

        //Close Connection
        public static void CloseConnection()
        {
            if (dbCon != null)
            {
                dbCon.Dispose();
            }
            dbCon = null;
        }

    }
}
