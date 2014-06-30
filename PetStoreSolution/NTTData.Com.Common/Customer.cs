using System;

namespace NTTData.Com.Common
{
    public class Customer
    {
        #region [Fields]

        private string address;
        private DateTime cardExpiryDate;
        private string cardType;
        private int contactNumber;
        private string creditCardNo;
        private string custID;
        private DateTime dateOfBirth;
        private string firstName;
        private string lastName;
        private string password;

        #endregion [Fields]

        #region [Constructors]

        public Customer(string custID, string password, string firstName, string lastName, DateTime dateOfBirth,
            string address, int contactNumber, string creditCardNo, string cardType, DateTime cardExpiryDate)
        {
            this.address = address;
            this.cardExpiryDate = cardExpiryDate;
            this.cardType = cardType;
            this.contactNumber = contactNumber;
            this.creditCardNo = creditCardNo;
            this.custID = custID;
            this.dateOfBirth = dateOfBirth;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
        }

        #endregion [Constructors]

        #region [Properties]

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime CardExpiryDate
        {
            get { return cardExpiryDate; }
            set { cardExpiryDate = value; }
        }

        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }

        public int ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string CreditCardNo
        {
            get { return creditCardNo; }
            set { creditCardNo = value; }
        }

        public string CustID
        {
            get { return custID; }
            set { custID = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string FistName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        #endregion [Properties]
    }
}