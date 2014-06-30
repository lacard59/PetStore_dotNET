using System.Collections.Generic;
using NTTData.Com.Common;

namespace NTTData.Com.BusinessLayer
{
    public class ProductADO
    {
        #region Methods

        public static List<Category> GetCatByID(int categID)
        {
            List<Category> test = new List<Category>();
            return test;
        }

        public static List<Category> GetCategories()
        {
            List<Category> test = new List<Category>();
            return test;
        }

        public static List<Item> GetItem(int categID, int productID, int itemID)
        {
            List<Item> test = new List<Item>();
            return test;
        }

        public static List<Item> GetItemList(int categID, int productID)
        {
            List<Item> test = new List<Item>();
            return test;
        }

        public static List<Product> GetProduct(int categID, int productID)
        {
            List<Product> test = new List<Product>();
            return test;
        }

        public static List<Product> GetProductList(int categID)
        {
            List<Product> test = new List<Product>();
            return test;
        }

        #endregion Methods
    }
}