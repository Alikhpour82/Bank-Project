using System;
using System.Collections.Generic;
using Entity.Contracts;

namespace Entity
{
    public class Account : IAccount
    {
        #region Fields
        public int ID { get; set; }
        public string AccountNumber { get; set; }
        public DateTime OpeningDate { get; set; }
        public long Balance { get; set; }
        public List<Customer> Owners { get; set; }
        public int MinAmount { get; set; }
        #endregion

        #region Constructor
        public Account(int id, string accountNumber, DateTime openingDate, List<Customer> owners, int minAmount)
        {
            ID = id;
            AccountNumber = accountNumber;
            OpeningDate = openingDate;
            Balance = minAmount;
            Owners = owners;
            MinAmount = minAmount;
        }
        #endregion
    }
}
