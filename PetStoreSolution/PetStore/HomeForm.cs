using NTTData.Com.BusinessLayer;
using NTTData.Com.Common;
using NTTData.Com.ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore
{
    public delegate void DisplayDelegate();
    public partial class HomeForm : Form
    {
        
        public HomeForm()
        {
            InitializeComponent();
        }

        public void DisableLogin()
        {            
            registerLoginToolStripMenuItem.Enabled = false;
            catalogCategoriesToolStripMenuItem.Enabled = true;
        }
                
        private void registerLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayDelegate dis = new DisplayDelegate(this.DisableLogin);
            DialogResult result = MessageBox.Show("Are you an Existing Customer?", "Login/Register", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                Login form = new Login(dis);
                form.ShowInTaskbar = false;
                form.MdiParent = this;
                form.Show(); 
            }
            else if (result == DialogResult.No) 
            {
                Register form = new Register(dis);
                form.ShowInTaskbar = false;
                form.MdiParent = this;
                form.Show(); 
            }
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories form = new Categories();
            form.ShowInTaskbar = false;
            form.MdiParent = this;
            form.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products form = new Products();
            form.ShowInTaskbar = false;
            form.MdiParent = this;
            form.Show();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Items form = new Items();
            form.ShowInTaskbar = false;
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #region [Function Tests]
        //private void TestBtn_Click(object sender, EventArgs e)
        //{
            #region [ValidateUser Test]

        //    //bool var = false;
        //    //try { var = PetStoreService.ValidateUser("lennin", "op"); }
        //    //catch (Exception exceptionOne) { MessageBox.Show(exceptionOne.Message); }

        //    //if (var == true)
        //    //{
        //    //    MessageBox.Show("User Works!");
        //    //}
        //    //else { MessageBox.Show("Fail-sauce!!! - Validate User"); }

            #endregion [ValidateUser Test]

            #region [RegisterUser Test]

        //    //Customer test = new Customer("lazer", "op", "Larz", "Lazer", new DateTime(1988, 10, 9), "9876 Smith Ave.", 0987, "7890", "VISA", new DateTime(2018, 7, 30));
        //    //bool var = false;
        //    //try { var = PetStoreService.RegisterUser(test); }
        //    //catch (Exception exceptionOne) { MessageBox.Show(exceptionOne.Message); }

        //    //if (var == true)
        //    //{
        //    //    MessageBox.Show("Store Procedure Works!\n" + PetStoreService.GetMessage());
        //    //}
        //    //else { MessageBox.Show("Fail-sauce!!! - Register User/Store Procedure!!!\n" + PetStoreService.GetMessage()); }

            #endregion [RegisterUser Test]

            #region [GetCategories Test]

        //    //try
        //    //{
        //    //    List<Category> test = PetStoreService.GetCategories();
        //    //    StringBuilder str = new StringBuilder();
        //    //    foreach (Category c in test)
        //    //    {
        //    //        str.Append(c.CategoryName).Append(" ").Append(c.CategoryID).Append(" ").Append(c.CategoryDescription).Append("\n");
        //    //    }
        //    //    MessageBox.Show(str.ToString());
        //    //}
        //    //catch (Exception exceptionOne) { MessageBox.Show(exceptionOne.Message); }

            #endregion [GetCategories Test]

            #region [GetCategoryByID Test]

        //    //try
        //    //{
        //    //    Category test = PetStoreService.GetCatByID(101);
        //    //    StringBuilder str = new StringBuilder();
        //    //    str.Append(test.CategoryName).Append(" ").Append(test.CategoryID).Append(" ").Append(test.CategoryDescription).Append("\n");
        //    //    MessageBox.Show(str.ToString());
        //    //}
        //    //catch (Exception exceptionOne) { MessageBox.Show(exceptionOne.Message); }

            #endregion [GetCategoryByID Test]

            #region [GetProductList Test]

        //    //try
        //    //{
        //    //    List<Product> test = PetStoreService.GetProductList(int.Parse(textBoxTest1.Text));
        //    //    StringBuilder str = new StringBuilder();
        //    //    foreach (Product p in test)
        //    //    {
        //    //        str.Append(p.ProductID).Append(" ").Append(p.CategoryID).Append(" ").Append(p.ProductName)
        //    //            .Append(" ").Append(p.ProductDescription).Append("\n");
        //    //    }
        //    //    MessageBox.Show(str.ToString());
        //    //}
        //    //catch (Exception exceptionOne) { MessageBox.Show(exceptionOne.Message); }

            #endregion [GetProductList Test]

            #region [GetProduct Test]

        //    //try
        //    //{
        //    //    Product test = PetStoreService.GetProduct(int.Parse(textBoxTest1.Text), int.Parse(textBoxTest2.Text));
        //    //    StringBuilder str = new StringBuilder();
        //    //    str.Append(test.ProductID).Append(" ").Append(test.CategoryID).Append(" ").Append(test.ProductName)
        //    //        .Append(" ").Append(test.ProductDescription).Append("\n");
        //    //    MessageBox.Show(str.ToString());
        //    //}
        //    //catch (Exception exceptionTwo) { MessageBox.Show(exceptionTwo.Message); }

            #endregion [GetProduct Test]

            #region [GetItemList Test]

        //    //try
        //    //{
        //    //    List<Item> test = PetStoreService.GetItemList(int.Parse(textBoxTest1.Text), int.Parse(textBoxTest2.Text));
        //    //    StringBuilder str = new StringBuilder();
        //    //    foreach (Item it in test)
        //    //    {
        //    //        str.Append(it.ItemID).Append(" ").Append(it.CategoryID).Append(" ")
        //    //            .Append(it.ProductID).Append(" ").Append(it.ItemName).Append(" ")
        //    //            .Append(it.ItemDescription).Append(" ").Append(it.ItemPrice).Append("\n");
        //    //    }
        //    //    MessageBox.Show(str.ToString());
        //    //}
        //    //catch (Exception exceptionTwo) { MessageBox.Show(exceptionTwo.Message); }

            #endregion [GetItemList Test]

            #region [GetItem Test]

        //    //try
        //    //{
        //    //    Item test = PetStoreService.GetItem(int.Parse(textBoxTest1.Text), int.Parse(textBoxTest2.Text), int.Parse(textBoxTest3.Text));
        //    //    StringBuilder str = new StringBuilder();
        //    //    str.Append(test.ItemID).Append(" ").Append(test.CategoryID).Append(" ").Append(test.ProductID).Append(" ")
        //    //        .Append(test.ItemName).Append(" ").Append(test.ItemDescription).Append(" ").Append(test.ItemPrice).Append("\n");
        //    //    MessageBox.Show(str.ToString());
        //    //}
        //    //catch (Exception exceptionTwo) { MessageBox.Show(exceptionTwo.Message); }

            #endregion [GetItem Test]

            #region [GetPurchaseDetails Test]

        //    //try
        //    //{
        //    //    Cart test = (Cart)PetStoreService.GetPurchaseDetails(int.Parse(textBoxTest1.Text));
        //    //    StringBuilder str = new StringBuilder();
        //    //    foreach (CartItem ci in test.CartItems)
        //    //    {
        //    //        str.Append(ci.Item.ItemName).Append(" ").Append(test.CustID).Append(" ").Append(test.OrderID).Append("\n");
        //    //    }
        //    //    MessageBox.Show(str.ToString());
        //    //}
        //    //catch (Exception exceptionTwo) { MessageBox.Show(exceptionTwo.Message); }

            #endregion [GetPurchaseDetails Test]

            #region [PlaceOrder Test]

        //    Item testitem;
        //    List<CartItem> testList = new List<CartItem>();
        //    testitem = new Item(6000, 100, 2001, "1", "2", 20);
        //    testList.Add(new CartItem(testitem, 2));
        //    testitem = new Item(6001, 100, 2001, "1", "2", 10);
        //    testList.Add(new CartItem(testitem, 5));
        //    testitem = new Item(6003, 103, 2007, "1", "2", 12.50f);
        //    testList.Add(new CartItem(testitem, 8));
        //    Cart test = new Cart(textBoxTest1.Text, testList);
        //    int orderID = 0;
        //    try
        //    {
        //        orderID = (int)PetStoreService.PlaceOrder(test);
        //        MessageBox.Show("Order created, son!. Order Number is " + orderID);
        //    }
        //    catch (Exception exceptionTwo) { MessageBox.Show(exceptionTwo.Message); }

            #endregion [PlaceOrder Test]
        //} 
        #endregion [Function Tests]
    }
}