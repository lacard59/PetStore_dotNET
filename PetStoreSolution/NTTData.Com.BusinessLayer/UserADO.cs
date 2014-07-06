using NTTData.Com.Common;
using NTTData.Com.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NTTData.Com.BusinessLayer
{
    public static class UserADO
    {
        #region Methods

        public static void AddParameter(SqlCommand command, SqlParameter parameter, string pName, SqlDbType type, object val, ParameterDirection dir)
        {
            parameter = new SqlParameter();
            parameter.ParameterName = pName;
            parameter.SqlDbType = type;
            parameter.Value = val;
            parameter.Direction = dir;
            parameter.Size = 100;
            command.Parameters.Add(parameter);
        }

        public static object RegisterUser(Customer customerObj)
        {
            List<string> result = new List<string>();

            string procedure = "PR_RegisterUserProc";
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }

            SqlCommand command = new SqlCommand(procedure, conn);

            #region [SQL Parameters]

            SqlParameter custID = new SqlParameter();
            SqlParameter pass = new SqlParameter();
            SqlParameter fname = new SqlParameter();
            SqlParameter lname = new SqlParameter();
            SqlParameter dob = new SqlParameter();
            SqlParameter address = new SqlParameter();
            SqlParameter contactNum = new SqlParameter();
            SqlParameter cc_num = new SqlParameter();
            SqlParameter cardType = new SqlParameter();
            SqlParameter expDate = new SqlParameter();
            SqlParameter success = new SqlParameter();
            SqlParameter errMsg = new SqlParameter();

            #endregion [SQL Parameters]

            #region [Add SQL Parameters]

            AddParameter(command, custID, "@cust_id", SqlDbType.VarChar, customerObj.CustID, ParameterDirection.Input);
            AddParameter(command, pass, "@password", SqlDbType.VarChar, customerObj.Password, ParameterDirection.Input);
            AddParameter(command, fname, "@fname", SqlDbType.VarChar, customerObj.FistName, ParameterDirection.Input);
            AddParameter(command, lname, "@lname", SqlDbType.VarChar, customerObj.LastName, ParameterDirection.Input);
            AddParameter(command, dob, "@DOB", SqlDbType.DateTime, customerObj.DateOfBirth, ParameterDirection.Input);
            AddParameter(command, address, "@address", SqlDbType.VarChar, customerObj.Address, ParameterDirection.Input);
            AddParameter(command, contactNum, "@contact_num", SqlDbType.BigInt, customerObj.ContactNumber, ParameterDirection.Input);
            AddParameter(command, cc_num, "@CC_num", SqlDbType.BigInt, Int64.Parse(customerObj.CreditCardNo), ParameterDirection.Input);
            AddParameter(command, cardType, "@card_type", SqlDbType.VarChar, customerObj.CardType, ParameterDirection.Input);
            AddParameter(command, expDate, "@ex_date", SqlDbType.DateTime, customerObj.CardExpiryDate, ParameterDirection.Input);
            AddParameter(command, success, "@success", SqlDbType.VarChar, null, ParameterDirection.Output);
            AddParameter(command, errMsg, "@error_msg", SqlDbType.VarChar, null, ParameterDirection.Output);

            #endregion [Add SQL Parameters]

            command.CommandType = CommandType.StoredProcedure;

            try
            {
                command.ExecuteNonQuery();
                result.Add(command.Parameters["@success"].Value.ToString());
                result.Add(command.Parameters["@error_msg"].Value.ToString());
            }
            catch (Exception exceptionOne) { throw exceptionOne; }
            finally { DBConnection.CloseConnection(conn); }

            return result;
        }

        public static bool ValidateUser(string userID, string password)
        {
            string query = "SELECT count(*) FROM PS_User WHERE PS_User.CustID='" +
                userID + "' AND PS_User.Password='" + password + "'";
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            SqlCommand command = new SqlCommand(query, conn);

            int result = 0;
            try { result = int.Parse(command.ExecuteScalar().ToString()); DBConnection.CloseConnection(conn); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            finally { DBConnection.CloseConnection(conn); }

            if (result > 0) { return true; }
            else { return false; }
        }
        #endregion Methods
    }
}