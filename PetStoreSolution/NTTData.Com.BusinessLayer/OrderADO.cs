using NTTData.Com.Common;
using NTTData.Com.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NTTData.Com.BusinessLayer
{
    public class OrderADO
    {
        #region Methods

        public static object GetPurchaseDetails(int orderID)
        {
            Cart cart = null;
            CartItem cartItem = null;
            Item item = null;
            List<CartItem> cartItemList = new List<CartItem>();

            string query = @"SELECT PD.ItemID, PD.CategID,PD.ProdID, LI.ItemName, LI.ItemDesc,
                        LI.Price, PD.Quantity, PD.OrderID,  PO.custID FROM PS_ORDERS PO
                        JOIN Purchase_Detail PD ON PO.OrderID = PD.OrderID
                        JOIN Product_Line_Items LI ON LI.ItemID = PD.ItemID AND PO.OrderID = " + orderID;
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
                    {
                        {
                            {
                                item = new Item(int.Parse(reader.GetDecimal(0).ToString()), int.Parse(reader.GetDecimal(1).ToString()),
                                    int.Parse(reader.GetDecimal(2).ToString()), reader.GetString(3), reader.GetString(4),
                                    float.Parse(reader.GetDecimal(5).ToString()));
                            }

                            cartItem = new CartItem(item, int.Parse(reader.GetDecimal(6).ToString()));
                        }

                        cartItemList.Add(cartItem);
                    }
                    cart = new Cart(int.Parse(reader.GetDecimal(7).ToString()), reader.GetString(8), cartItemList);
                }

                DBConnection.CloseConnection(conn);
            }
            catch (Exception exceptionOne) { throw exceptionOne; }
            finally { DBConnection.CloseConnection(conn); }

            return cart;
        }

        public static object PlaceOrder(Cart shoppingCart)
        {
            List<string> result = new List<string>();

            List<CartItem> cartItemList = shoppingCart.CartItems;
            int OrderID = 0;
            string procedure = "PR_InsertOrder";
            SqlConnection conn;
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }

            SqlCommand command = new SqlCommand(procedure, conn);

            #region [SQL Parameters | Insert Order]

            SqlParameter custID = new SqlParameter();
            SqlParameter success_insert = new SqlParameter();
            SqlParameter errMsg_insert = new SqlParameter();

            #endregion [SQL Parameters | Insert Order]

            #region [Add Parameters | Insert Order]

            AddParameter(command, custID, "@cust_id", SqlDbType.VarChar, shoppingCart.CustID, ParameterDirection.Input);
            AddParameter(command, success_insert, "@success", SqlDbType.VarChar, null, ParameterDirection.Output);
            AddParameter(command, errMsg_insert, "@error_msg", SqlDbType.VarChar, null, ParameterDirection.Output);
            command.CommandType = CommandType.StoredProcedure;

            #endregion [Add Parameters | Insert Order]

            try

            {
                command.ExecuteNonQuery();
                result.Add(command.Parameters["@success"].Value.ToString());
                result.Add(command.Parameters["@error_msg"].Value.ToString());
            }
            catch (Exception exceptionOne) { DBConnection.CloseConnection(conn); throw exceptionOne; }

            procedure = "PR_PlaceOrder";
            command = new SqlCommand(procedure, conn);
            command.CommandType = CommandType.StoredProcedure;

            #region [SQL Parameters | Place Order]

            SqlParameter itemID = new SqlParameter();
            SqlParameter prodID = new SqlParameter();
            SqlParameter categID = new SqlParameter();
            SqlParameter quantity = new SqlParameter();
            SqlParameter success_place = new SqlParameter();
            SqlParameter errMsg_place = new SqlParameter();
            SqlParameter outOrderID = new SqlParameter();

            #endregion [SQL Parameters | Place Order]

            foreach (CartItem it in cartItemList)

            {
                command = new SqlCommand(procedure, conn);
                command.CommandType = CommandType.StoredProcedure;

                #region [Add Parameters | Place Order]

                AddParameter(command, itemID, "@item_id", SqlDbType.BigInt, it.Item.ItemID, ParameterDirection.Input);
                AddParameter(command, prodID, "@prod_id", SqlDbType.BigInt, it.Item.ProductID, ParameterDirection.Input);
                AddParameter(command, categID, "@categ_id", SqlDbType.BigInt, it.Item.CategoryID, ParameterDirection.Input);
                AddParameter(command, quantity, "@quantity", SqlDbType.BigInt, it.Quantity, ParameterDirection.Input);
                AddParameter(command, success_place, "@success", SqlDbType.VarChar, null, ParameterDirection.Output);
                AddParameter(command, errMsg_place, "@error_msg", SqlDbType.VarChar, null, ParameterDirection.Output);
                AddParameter(command, outOrderID, "@outOrder_id", SqlDbType.BigInt, null, ParameterDirection.Output);

                #endregion [Add Parameters | Place Order]

                try

                {
                    command.ExecuteNonQuery();
                    result.Add(command.Parameters["@success"].Value.ToString());
                    result.Add(command.Parameters["@error_msg"].Value.ToString());
                    OrderID = int.Parse(command.Parameters["@outOrder_id"].Value.ToString());
                }
                catch (Exception exceptionOne) { DBConnection.CloseConnection(conn); throw exceptionOne; }
            }

            try { DBConnection.CloseConnection(conn); }
            catch (Exception exceptionOne) { throw exceptionOne; }

            return OrderID;
        }

        private static void AddParameter(SqlCommand command, SqlParameter parameter, string pName, SqlDbType type, object val, ParameterDirection dir)
        {
            parameter = new SqlParameter();
            parameter.ParameterName = pName;
            parameter.SqlDbType = type;
            parameter.Value = val;
            parameter.Direction = dir;
            parameter.Size = 100;
            command.Parameters.Add(parameter);
        }

        #endregion Methods
    }
}