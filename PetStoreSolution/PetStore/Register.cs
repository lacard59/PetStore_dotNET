using NTTData.Com.Common;
using NTTData.Com.ServiceLayer;
using System;
using System.Windows.Forms;

namespace PetStore
{
    public partial class Register : Form
    {
        #region Private Fields

        private DisplayDelegate d;

        #endregion Private Fields

        #region Public Constructors

        public Register(DisplayDelegate del)
        {
            InitializeComponent();
            d = del;
        }

        #endregion Public Constructors

        #region Private Methods

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if ((textBoxCreditCardNum.Text.Length >= 1) && (textBoxUserID.Text.Length >= 1))
            {
                DateTime dt1 = dateTimePickerCardExpDate.Value;
                DateTime dt2 = dateTimePickerDOB.Value;
                Customer cust = new Customer(textBoxUserID.Text, textBoxPassword.Text, textBoxFirstName.Text,
                    textBoxLastName.Text, dateTimePickerDOB.Value, richTextBoxAddress.Text,
                    int.Parse(textBoxPhoneNum.Text), textBoxCreditCardNum.Text, comboBoxCardType.Text,
                    dateTimePickerCardExpDate.Value);

                bool var = false;
                try { var = PetStoreService.RegisterUser(cust); }
                catch (Exception exceptionOne) { MessageBox.Show(exceptionOne.Message); }

                if (var == true)
                {
                    d();
                    MessageBox.Show("User Successfully Registered!");
                    HomeForm.CustID = textBoxUserID.Text;
                    this.Hide();
                }
                else { MessageBox.Show("Fail-sauce!!!" + PetStoreService.GetMessage()); }
            }
            else { MessageBox.Show("Please, enter something in the Credit Card Number box and User ID box!"); }
        }

        #endregion Private Methods
    }
}