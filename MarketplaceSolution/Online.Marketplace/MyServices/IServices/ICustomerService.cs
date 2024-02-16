using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.MyServices.IServices
{
    public interface ICustomerService
    {
        public string Create(CustomersDTO customer);
        public IEnumerable<Customers> GetAll();
        public Customers GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id, CustomersDTO customers);
    }
}
