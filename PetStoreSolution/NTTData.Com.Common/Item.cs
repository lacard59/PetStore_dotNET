using System.Text;

namespace NTTData.Com.Common
{
    public class Item
    {
        #region Fields

        private int categoryID;
        private string itemDescription;
        private int itemID;
        private string itemName;
        private float itemPrice;
        private int productID;

        #endregion Fields

        #region Constructors

        public Item(int itemID, int categoryID, int productID, string itemName, string itemDescription, float itemPrice)
        {
            this.categoryID = categoryID;
            this.itemDescription = itemDescription;
            this.itemID = itemID;
            this.itemName = itemName;
            this.itemPrice = itemPrice;
            this.productID = productID;
        }

        public Item()
        {
        }

        #endregion Constructors

        #region Properties

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public string ItemDescription
        {
            get { return itemDescription; }
            set { itemDescription = value; }
        }

        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public float ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        #endregion Properties

        #region Public Methods

        public string toString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(itemID).Append(" | \t").Append(categoryID).Append(" | \t")
                .Append(productID).Append(" | \t").Append(itemName).Append(" | \t")
                .Append(itemDescription).Append(" | \t").Append(itemPrice);
            return str.ToString();
        }

        #endregion Public Methods
    }
}