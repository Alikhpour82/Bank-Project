using System;

namespace Entity.Contracts
{
    public interface ICustomer
    {
        #region Fields
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime BirthDate { get; set; }
        string NationalID { get; set; }
        string MobileNumber { get; set; }
        string Address { get; set; }
        string EmailAddress { get; set; }
        string Nationality { get; set; }
        #endregion
    }
}
