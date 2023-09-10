
using Entity;
using System.Collections.Generic;

namespace DataBase
{
    public class Data
    {
        #region Fields
        public static List<Customer> customers;
        #endregion


        #region Constructor
        static Data()
        {
            customers = new List<Customer>();
        }
        #endregion

    }
}
