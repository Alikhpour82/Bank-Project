using Entity;

namespace BusinessLogic.Contracts
{
    public interface ICustomerBusinessLogic
    {
        #region Methods
        void AddCustomer();
        Customer FindByID(int id);
        int GenerateCustomerID();
        #endregion
    }
}
