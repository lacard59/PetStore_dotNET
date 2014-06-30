using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTTData.Com.Common
{
    public class Cart
    {
        private List<CartItem> cartItems;

        public List<CartItem> CartItems
        {
            get { return cartItems; }
            set { cartItems = value; }
        }

        private string custID;

        public string CustID
        {
            get { return custID; }
            set { custID = value; }
        }

        private int orderID;

        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

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

        public Cart() { }
    }
}
