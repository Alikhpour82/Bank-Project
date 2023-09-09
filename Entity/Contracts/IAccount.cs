using System;
using System.Collections.Generic;

namespace Entity.Contracts
{
    public interface IAccount
    {
        #region Fields
        int ID { get; set; }
        string AccountNumber { get; set; }
        DateTime OpeningDate { get; set; }
        long Balance { get; set; }
        List<Customer> Owners { get; set; }
        int MinAmount { get; set; }
        #endregion
    }
}
