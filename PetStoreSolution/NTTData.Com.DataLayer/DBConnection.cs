using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NTTData.Com.DataLayer
{
    public static class DBConnection
    {
        private static string serv = "NTTDATA605231";
        private static string db = "PetStore";
        private static string uid = "sa";
        private static string pass = "Adm!n321";
        private static string _connectionString = "Server=" + serv + ";Database" + db + ";uid" + uid + ";password" + pass;

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException exceptionOne)
            {
                throw exceptionOne;
            }
            catch (Exception exceptionTwo)
            {
                throw exceptionTwo;
            }
            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try
            {
                connection.Close();
            }
            catch (SqlException exceptionOne)
            {
                throw exceptionOne;
            }
            catch (Exception exceptionTwo)
            {
                throw exceptionTwo;
            }
        }

    }
}
