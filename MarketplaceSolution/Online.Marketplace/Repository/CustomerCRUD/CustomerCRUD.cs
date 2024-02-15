using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.Repository.CustomerCRUD
{
    public class CustomerCRUD : ICustomerCRUD
    {
        string ICustomerCRUD.Create(Customers customer)
        {
            throw new NotImplementedException();
        }

        string ICustomerCRUD.DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customers> ICustomerCRUD.GetAll()
        {
            throw new NotImplementedException();
        }

        Customers ICustomerCRUD.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        Customers ICustomerCRUD.Update(int id, CustomersDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
