using Entity.Enums;
using System;

namespace Entity.Contracts
{
    public interface ICard
    {
        #region Fields
        int ID { get; set; }
        string CardPAN { get; set; }
        string Password { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ExpirationDate { get; set; }
        string CVV2 { get; set; }
        Customer Owner { get; set; }
        Account Account { get; set; }
        CardType  Type { get; set; }
        CardState State { get; set; }
        #endregion
    }
}
