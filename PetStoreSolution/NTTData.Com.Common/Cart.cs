using System.Collections.Generic;

namespace NTTData.Com.Common
{
    public class Cart
    {
        #region Fields

        private List<CartItem> cartItems;
        private string custID;
        private int orderID;

        #endregion Fields

        #region Constructors

        public Cart(int orderID, string custID, List<CartItem> cartItems)
        {
            this.orderID = orderID;
            this.custID = custID;
            this.cartItems = cartItems;
        }

        public Cart(string custID, List<CartItem> cartItems)
        {
            this.custID = custID;
            this.cartItems = cartItems;
        }

        public Cart()
        {
        }

        #endregion Constructors

        #region Properties

        public List<CartItem> CartItems
        {
            get { return cartItems; }
            set { cartItems = value; }
        }

        public string CustID
        {
            get { return custID; }
            set { custID = value; }
        }

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        #endregion Properties
    }
}