using NTTData.Com.Common;
using NTTData.Com.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PetStore
{
    public partial class Catalog : Form
    {
        #region Private Fields

        private Cart cart;
        private List<CartItem> cartItemList;
        private Item item;

        #endregion Private Fields

        #region Public Constructors

        public Catalog()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int.Parse(textBoxCategID.Text) >= 100) && (int.Parse(textBoxProdID.Text) >= 2000)
                    && (int.Parse(textBoxItemID.Text) >= 6000))
                {
                    item = PetStoreService.GetItem(int.Parse(textBoxCategID.Text),
                        int.Parse(textBoxProdID.Text), int.Parse(textBoxItemID.Text));
                    CartItem ci = null;
                    try
                    {
                        ci = new CartItem(item, int.Parse(textBoxQuantity.Text));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Input a number in the Quantity field",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    cartItemList.Add(ci);
                    MessageBox.Show("Item added to cart!");
                }
                else
                {
                    MessageBox.Show("Enter a valid Category ID/Product ID/Item ID", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input a number in the Category ID/Product ID/Item ID field(s)",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            List<Category> catList = new List<Category>();
            try { catList = PetStoreService.GetCategories(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            StringBuilder str = new StringBuilder();
            str.Append("Categories: \nID | Name | Description\n");
            foreach (Category cat in catList) { str.Append(cat.toString()).Append("\n"); }
            richTextBoxDisplay.Text = str.ToString();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            cart = new Cart(HomeForm.CustID, cartItemList);
            int orderID = PetStoreService.PlaceOrder(cart);
            MessageBox.Show("Order placed! Your Order ID: " + orderID);
            cartItemList = new List<CartItem>();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxCategID.Text) >= 100 && (int.Parse(textBoxProdID.Text) >= 2000))
                {
                    List<Item> itemList = new List<Item>();
                    try { itemList = PetStoreService.GetItemList(int.Parse(textBoxCategID.Text), int.Parse(textBoxProdID.Text)); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    StringBuilder str = new StringBuilder();
                    str.Append("Items: \nItem ID | Categ ID | Prod ID | Name | Description | Price\n");
                    foreach (Item item in itemList) { str.Append(item.toString()).Append("\n"); }
                    richTextBoxDisplay.Text = str.ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid Category ID/Product ID", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input a number in the Category ID/Product ID field(s)",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxCategID.Text) >= 100)
                {
                    List<Product> prodList = new List<Product>();
                    try { prodList = PetStoreService.GetProductList(int.Parse(textBoxCategID.Text)); }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    StringBuilder str = new StringBuilder();
                    str.Append("Products: \nProd ID | Categ ID | Name | Description\n");
                    foreach (Product prod in prodList) { str.Append(prod.toString()).Append("\n"); }
                    richTextBoxDisplay.Text = str.ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid Category ID", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Input a number in the Category ID field",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            cartItemList = new List<CartItem>();
            List<Category> catList = new List<Category>();
            try { catList = PetStoreService.GetCategories(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            StringBuilder str = new StringBuilder();
            str.Append("Categories: \nID | Name | Description\n");
            foreach (Category cat in catList) { str.Append(cat.toString()).Append("\n"); }
            richTextBoxDisplay.Text = str.ToString();
        }

        #endregion Private Methods
    }
}