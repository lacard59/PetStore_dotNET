using NTTData.Com.ServiceLayer;
using System;
using System.Windows.Forms;

namespace PetStore
{
    public partial class Login : Form
    {
        #region Private Fields

        private DisplayDelegate d;

        #endregion Private Fields

        #region Public Constructors

        public Login(DisplayDelegate del)
        {
            InitializeComponent();
            d = del;
        }

        #endregion Public Constructors

        #region Private Methods

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool var = false;
            try
            {
                var = PetStoreService.ValidateUser(textBoxCustID.Text, textBoxPassword.Text);
                if (var)
                {
                    d();
                    MessageBox.Show("Successful Login!");
                    HomeForm.CustID = textBoxCustID.Text;
                    this.Hide();
                }
                else { MessageBox.Show("You Fail!"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        #endregion Private Methods
    }
}