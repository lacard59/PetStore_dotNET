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
    }
}