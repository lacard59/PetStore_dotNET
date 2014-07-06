using System.Text;

namespace NTTData.Com.Common
{
    public class Category
    {
        #region Fields

        private string categoryDescription;
        private string categoryID;
        private string categoryName;

        #endregion Fields

        #region Constructors

        public Category()
        {
        }

        public Category(string categoryID, string categoryName, string categoryDescription)
        {
            this.categoryDescription = categoryDescription;
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }

        #endregion Constructors

        #region Properties

        public string CategoryDescription
        {
            get { return categoryDescription; }
            set { categoryDescription = value; }
        }

        public string CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        #endregion Properties

        #region Public Methods

        public string toString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(categoryID).Append(" | \t").Append(categoryName)
                .Append(" | \t").Append(CategoryDescription);
            return str.ToString();
        }

        #endregion Public Methods
    }
}