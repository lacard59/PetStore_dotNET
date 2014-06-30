namespace NTTData.Com.Common
{
    public class CartItem
    {
        #region Fields

        private Item item;
        private int quantity;

        #endregion Fields

        #region Constructors

        public CartItem(Item item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }

        public CartItem()
        {
        }

        #endregion Constructors

        #region Properties

        public Item Item
        {
            get { return item; }
            set { item = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        #endregion Properties
    }
}