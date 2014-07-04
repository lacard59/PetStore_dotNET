using System;
using System.Data.SqlClient;

namespace NTTData.Com.DataLayer
{
    public static class DBConnection
    {
        #region Private Fields

        private static string db = "PetStore";
        private static string pass = "Adm!n321";
        private static string serv = "RODNEALPC\\SQLEXPRESS";
        private static string uid = "sa";
        private static string _connectionString = "Server=" + serv + ";Database=" + db + ";uid=" + uid + ";password=" + pass;

        #endregion Private Fields

        #region Public Methods

        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            try { connection.Open(); }
            catch (SqlException exceptionOne) { throw exceptionOne; }
            catch (Exception exceptionTwo) { throw exceptionTwo; }
            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try { connection.Close(); }
            catch (SqlException exceptionOne) { throw exceptionOne; }
            catch (Exception exceptionTwo) { throw exceptionTwo; }
        }

        #endregion Public Methods
    }
}