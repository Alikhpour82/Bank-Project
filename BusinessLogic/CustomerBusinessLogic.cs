using System;
using Entity;
using DataBase;
using BusinessLogic.Contracts;

namespace BusinessLogic
{
    public class CustomerBusinessLogic : ICustomerBusinessLogic
    {
        #region Fields
        private static int _customerID;
        #endregion

        #region Methods
        public void AddCustomer()
        {
            int customerID = GenerateCustomerID();
            Console.WriteLine($"Customer ID: {customerID}");

            Console.Write("Enter customer first name: ");
            string customerFirstName = Console.ReadLine();

            Console.Write("Enter customer last name: ");
            string customerLastName = Console.ReadLine();

            Console.Write("Enter customer birth date: ");
            DateTime customerBirthDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Enter customer national ID: ");
            string customerNationalID = Console.ReadLine();

            Console.Write("Enter customer mobile number: ");
            string customerMobileNumber = Console.ReadLine();

            Console.Write("Enter customer address: ");
            string customerAddress = Console.ReadLine();

            Console.Write("Enter customer emailAddress: ");
            string customerEmailAddress = Console.ReadLine();

            Console.Write("Enter customer nationality: ");
            string customerNationality = Console.ReadLine();


            Data.customers.Add(new Customer(
                customerID,
                customerFirstName,
                customerLastName,
                customerBirthDate,
                customerNationalID,
                customerMobileNumber,
                customerAddress,
                customerEmailAddress,
                customerNationality));
        }

        public Customer FindByID(int id)
        {
            foreach (Customer customer in Data.customers)
            {
                if (customer.ID == id)
                {
                    return customer;
                }
            }
            return null;
        }

        public int GenerateCustomerID()
        {
            _customerID++;
            return _customerID;
        }
        #endregion

        #region Constroctor
        static CustomerBusinessLogic()
        {
            _customerID = 0;
        }
        #endregion
    }
}
