using System.Text;

namespace NTTData.Com.Common
{
    public class Product
    {
        #region Fields

        private string categoryID;
        private string productDescription;
        private string productID;
        private string productName;

        #endregion Fields

        #region Constructors

        public Product()
        {
        }

        public Product(string productID, string categoryID, string productName, string productDescription)
        {
            this.categoryID = categoryID;
            this.productDescription = productDescription;
            this.productID = productID;
            this.productName = productName;
        }

        #endregion Constructors

        #region Properties

        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        #endregion Properties

        #region Public Methods

        public string toString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(productID).Append(" | \t").Append(categoryID)
                .Append(" | \t").Append(productName).Append(" | \t")
                .Append(productDescription);
            return str.ToString();
        }

        #endregion Public Methods
    }
}