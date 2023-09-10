using System;
using Entity.Contracts;
using Entity.Enums;

namespace Entity
{
    public class Card : ICard
    {
        #region Fields
        public int ID { get; set; }
        public string CardPAN { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CVV2 { get; set; }
        public Customer Owner { get; set; }
        public Account Account { get; set; }
        public CardType Type { get; set; }
        public CardState State { get; set; }
        #endregion

        #region Constructor
        public Card(int id, string cardPAN, string password, DateTime createDate, DateTime expirationDate,
                    string cvv2, Customer owner, Account account, CardType type, CardState state)
        {
            ID = id;
            CardPAN = cardPAN;
            Password = password;
            CreateDate = createDate;
            ExpirationDate = expirationDate;
            CVV2 = cvv2;
            Owner = owner;
            Account = account;
            Type = type;
            State = state;
        }
        #endregion

    }
}
