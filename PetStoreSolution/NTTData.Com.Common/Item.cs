using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTTData.Com.Common
{
    public class Item
    {
        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        private string itemDescription;

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }

        private int itemID;

        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        private float itemPrice;

        public float ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        private int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public Item(int itemID, int productID, int categoryID, string itemName, string itemDescription, float itemPrice)
        {
            this.categoryID = categoryID;
            this.itemDescription = itemDescription;
            this.itemID = itemID;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.productID = productID;
        }

        public Item() { }
    }
}
