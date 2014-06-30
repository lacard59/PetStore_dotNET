using System.Collections.Generic;
using NTTData.Com.BusinessLayer;
using NTTData.Com.Common;

namespace NTTData.Com.ServiceLayer
{
    internal class PetStoreService
    {
        #region Methods

        public Category GetCatByID(int categID)
        {
            return ProductADO.GetCatByID(categID)[0];
        }

        public List<Category> GetCategories()
        {
            return ProductADO.GetCategories();
        }

        public Item GetItem(int categID, int prodID, int itemID)
        {
            return ProductADO.GetItem(categID, prodID, itemID)[0];
        }

        public List<Item> GetItemList(int categID, int prodID)
        {
            return ProductADO.GetItemList(categID, prodID);
        }

        public Product GetProduct(int categID, int prodID)
        {
            return ProductADO.GetProduct(categID, prodID)[0];
        }

        public List<Product> GetProductList(int categID)
        {
            return ProductADO.GetProductList(categID);
        }

        public object GetPurchaseDetails(int orderID)
        {
            return OrderADO.GetPurchaseDetails(orderID);
        }

        public int PlaceOrder(Cart shoppingCart)
        {
            return (int)OrderADO.PlaceOrder(shoppingCart);
        }

        public bool RegisterUser(Customer customerObject)
        {
            UserADO.RegisterUser(customerObject);
            // Do proccess to obtain object, cast it to a List obj, Verify insert
            // has occured in DB and return true or false accordingly
            return false;
        }

        public bool ValidateUser(string userID, string password)
        {
            return UserADO.ValidateUser(userID, password);
        }

        #endregion Methods
    }
}