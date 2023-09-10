using System;
using Entity.Contracts;

namespace Entity
{
    public class Customer : ICustomer
    {
        #region Fields
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string NationalID { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Nationality { get; set; }
        #endregion

        #region Constructor
        public Customer(int id, string firstName, string lastName, DateTime birthDate, string nationalID,
                        string mobileNumber, string address, string emailAddress, string nationality)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            NationalID = nationalID;
            MobileNumber = mobileNumber;
            Address = address;
            EmailAddress = emailAddress;
            Nationality = nationality;
        }
        #endregion
    }
}
