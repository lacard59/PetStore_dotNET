using NTTData.Com.Common;
using NTTData.Com.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NTTData.Com.BusinessLayer
{
    public class ProductADO
    {
        #region Methods

        public static List<Category> GetCatByID(int categID)
        {
            List<Category> categories = new List<Category>();
            Category category;

            string query = "SELECT CategID, CategName, CategDesc FROM PS_Categories WHERE CategID = " + categID;
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            while (reader.Read())
            {
                category = new Category(reader.GetDecimal(0).ToString(), reader.GetString(1), reader.GetString(2));
                categories.Add(category);
            }

            try { DBConnection.CloseConnection(conn); }
            catch (Exception exceptionOne) { throw exceptionOne; }

            return categories;
        }

        public static List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            Category category;

            string query = "SELECT CategID, CategName, CategDesc FROM PS_Categories";
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            while (reader.Read())
            {
                category = new Category(reader.GetDecimal(0).ToString(), reader.GetString(1), reader.GetString(2));
                categories.Add(category);
            }

            try { DBConnection.CloseConnection(conn); }
            catch (Exception exceptionOne) { throw exceptionOne; }

            return categories;
        }

        public static List<Item> GetItem(int categID, int productID, int itemID)
        {
            List<Item> items = new List<Item>();
            Item item;

            string query = "SELECT ItemID, CategID, ProdID, ItemName, ItemDesc, Price FROM Product_Line_Items WHERE CategID = "
                + categID + " AND ProdID = " + productID + " AND ItemID = " + itemID;
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            try
            {
                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)
                    {
                        item = new Item(int.Parse(reader.GetDecimal(0).ToString()),
                            int.Parse(reader.GetDecimal(1).ToString()),
                            int.Parse(reader.GetDecimal(2).ToString()),
                            reader.GetString(3), reader.GetString(4),
                            float.Parse(reader.GetDecimal(5).ToString()));
                        items.Add(item);
                    }
                }
                DBConnection.CloseConnection(conn);
            }
            catch (Exception exceptionOne) { throw exceptionOne; }
            finally { DBConnection.CloseConnection(conn); }

            return items;
        }

        public static List<Item> GetItemList(int categID, int productID)
        {
            List<Item> items = new List<Item>();
            Item item;

            string query = "SELECT ItemID, CategID, ProdID, ItemName, ItemDesc, Price FROM Product_Line_Items WHERE CategID = "
                + categID + " AND ProdID = " + productID;
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            try
            {
                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)
                    {
                        #region [variables test]
                        //int test1 = int.Parse(reader.GetDecimal(0).ToString());
                        //int test2 = int.Parse(reader.GetDecimal(1).ToString());
                        //int test3 = int.Parse(reader.GetDecimal(2).ToString());
                        //string test4 = reader.GetString(3);
                        //string test5 = reader.GetString(4);
                        //float test6 = float.Parse(reader.GetDecimal(5).ToString()); 
                        #endregion
                        item = new Item(int.Parse(reader.GetDecimal(0).ToString()), 
                            int.Parse(reader.GetDecimal(1).ToString()),
                            int.Parse(reader.GetDecimal(2).ToString()), 
                            reader.GetString(3), reader.GetString(4), 
                            float.Parse(reader.GetDecimal(5).ToString()));
                        items.Add(item);
                    }
                }
                DBConnection.CloseConnection(conn);
            }
            catch (Exception exceptionOne) { throw exceptionOne; }
            finally { DBConnection.CloseConnection(conn); }

            return items;

        }

        public static List<Product> GetProduct(int categID, int productID)
        {
            List<Product> products = new List<Product>();
            Product product;

            string query = "SELECT ProdID, CategID, ProdName, ProdDesc FROM Category_Products WHERE CategID = " 
                + categID + " AND ProdID = " + productID;
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            try
            {
                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)
                    { 
                        product = new Product(reader.GetDecimal(0).ToString(), reader.GetDecimal(1).ToString(), reader.GetString(2), reader.GetString(3));
                        products.Add(product);
                    }
                }
                DBConnection.CloseConnection(conn);
            }
            catch (Exception exceptionOne) { throw exceptionOne; }
            finally { DBConnection.CloseConnection(conn); }

            return products;
        }

        public static List<Product> GetProductList(int categID)
        {
            List<Product> products = new List<Product>();
            Product product;

            string query = "SELECT ProdID, CategID, ProdName, ProdDesc FROM Category_Products WHERE CategID = " + categID;
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader;
            try { reader = command.ExecuteReader(); }
            catch (Exception exceptionOne) { throw exceptionOne; }
            try 
            {
                while (reader.Read())
                {
                    product = new Product(reader.GetDecimal(0).ToString(), reader.GetDecimal(1).ToString(), reader.GetString(2), reader.GetString(3));
                    products.Add(product);                     
                }
                DBConnection.CloseConnection(conn);
            }            
            catch (Exception exceptionOne) { throw exceptionOne; }
            finally { DBConnection.CloseConnection(conn); }

            return products;
        }

        #endregion Methods
    }
}