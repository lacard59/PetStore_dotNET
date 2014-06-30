using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTTData.Com.Common;

namespace NTTData.Com.BusinessLayer
{
    public static class UserADO
    {
        public static Customer RegisterUser(Customer customerObj)
        {
            Customer test = customerObj;
            return test;
        }

        public static bool ValidateUser(string userID, string password)
        {
            return false;
        }
    }
}
