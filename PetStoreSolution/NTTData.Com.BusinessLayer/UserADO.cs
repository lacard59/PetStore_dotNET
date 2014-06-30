using NTTData.Com.Common;

namespace NTTData.Com.BusinessLayer
{
    public static class UserADO
    {
        #region Methods

        public static Customer RegisterUser(Customer customerObj)
        {
            Customer test = customerObj;
            return test;
        }

        public static bool ValidateUser(string userID, string password)
        {
            return false;
        }

        #endregion Methods
    }
}