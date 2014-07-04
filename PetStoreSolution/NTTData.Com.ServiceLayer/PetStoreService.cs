using NTTData.Com.BusinessLayer;
using NTTData.Com.Common;
using System.Collections.Generic;

namespace NTTData.Com.ServiceLayer
{
    public static class PetStoreService
    {
        public static string message;

        #region Methods

        public static Category GetCatByID(int categID)
        {
            return ProductADO.GetCatByID(categID)[0];
        }

        public static List<Category> GetCategories()
        {
            return ProductADO.GetCategories();
        }

        public static Item GetItem(int categID, int prodID, int itemID)
        {
            return ProductADO.GetItem(categID, prodID, itemID)[0];
        }

        public static List<Item> GetItemList(int categID, int prodID)
        {
            return ProductADO.GetItemList(categID, prodID);
        }

        public static Product GetProduct(int categID, int prodID)
        {
            return ProductADO.GetProduct(categID, prodID)[0];
        }

        public static List<Product> GetProductList(int categID)
        {
            return ProductADO.GetProductList(categID);
        }

        public static object GetPurchaseDetails(int orderID)
        {
            return OrderADO.GetPurchaseDetails(orderID);
        }

        public static int PlaceOrder(Cart shoppingCart)
        {
            return (int)OrderADO.PlaceOrder(shoppingCart);
        }

        public static bool RegisterUser(Customer customerObject)
        {
            List<string> res = (List<string>)UserADO.RegisterUser(customerObject);
            message = res[1];
            return bool.Parse(res[0]);
        }

        public static bool ValidateUser(string userID, string password)
        {
            return UserADO.ValidateUser(userID, password);
        }

        public static string GetMessage()
        {
            return message;
        }

        #endregion Methods
    }
}