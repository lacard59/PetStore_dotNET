using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTTData.Com.Common
{
    class CartItem
    {
        private Item item;

        public Item Item
        {
            get { return item; }
            set { item = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public CartItem(Item item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
        }
    }
}
