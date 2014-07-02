using NTTData.Com.Common;

namespace NTTData.Com.BusinessLayer
{
    public static class UserADO
    {
        #region Methods

        public static object RegisterUser(Customer customerObj)
        {
            object test = customerObj;
            return test;
        }

        public static bool ValidateUser(string userID, string password)
        {
            return false;
        }

        #endregion Methods
    }
}