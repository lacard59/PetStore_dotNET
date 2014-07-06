using NTTData.Com.DataLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetStore
{
    public partial class CatalogDatabase : Form
    {
        #region Public Constructors

        public CatalogDatabase()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PS_Categories";
            SqlConnection conn;
            SqlDataAdapter adapter;
            DataSet records = new DataSet();
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }

            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(records);
            dataGridViewCatalog.DataSource = records.Tables[0].DefaultView;
            try { DBConnection.CloseConnection(conn); }
            catch (Exception exceptionOne) { throw exceptionOne; }
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int.Parse(textBoxCategID.Text) >= 100) && int.Parse(textBoxProdID.Text) >= 2000)
                {
                    string query = "SELECT * FROM Product_Line_Items WHERE CategID = " + textBoxCategID.Text + " AND ProdID = " + textBoxProdID.Text;
                    SqlConnection conn;
                    SqlDataAdapter adapter;
                    DataSet records = new DataSet();
                    try { conn = DBConnection.OpenConnection(); }
                    catch (Exception exceptionOne) { throw exceptionOne; }

                    adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(records);
                    dataGridViewCatalog.DataSource = records.Tables[0].DefaultView;
                    try { DBConnection.CloseConnection(conn); }
                    catch (Exception exceptionOne) { throw exceptionOne; }
                }
                else { MessageBox.Show("Enter a valid Category ID/Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (FormatException) { MessageBox.Show("Input a number in the Category ID/Product ID field(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBoxCategID.Text) >= 100)
                {
                    string query = "SELECT * FROM Category_Products WHERE CategID = " + textBoxCategID.Text;
                    SqlConnection conn;
                    SqlDataAdapter adapter;
                    DataSet records = new DataSet();
                    try { conn = DBConnection.OpenConnection(); }
                    catch (Exception exceptionOne) { throw exceptionOne; }

                    adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(records);
                    dataGridViewCatalog.DataSource = records.Tables[0].DefaultView;
                    try { DBConnection.CloseConnection(conn); }
                    catch (Exception exceptionOne) { throw exceptionOne; }
                }
                else { MessageBox.Show("Enter a valid Category ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (FormatException) { MessageBox.Show("Input a number in the Category ID field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PS_Categories";
            SqlConnection conn;
            SqlDataAdapter adapter;
            DataSet records = new DataSet();
            try { conn = DBConnection.OpenConnection(); }
            catch (Exception exceptionOne) { throw exceptionOne; }

            adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(records);
            dataGridViewCatalog.DataSource = records.Tables[0].DefaultView;
            try { DBConnection.CloseConnection(conn); }
            catch (Exception exceptionOne) { throw exceptionOne; }
        }

        #endregion Private Methods
    }
}