using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.MyServices.IServices;
using Online.Marketplace.Repository.CustomerCRUD;

namespace Online.Marketplace.MyServices.Services
{
    public class CustomerService : ICustomerService
    {
        public ICustomerCRUD _cs;

        public CustomerService(ICustomerCRUD cs)
        {
            _cs = cs;
        }
        public string Create(CustomersDTO customer)
        {
            if(customer.Full_Name == "" ||  customer.Full_Name == null)
            {
                return "Name isn't null";
            }
            if(customer.Age > 11)
            {
                try
                {
                    return _cs.Create(customer);
                }
                catch
                {
                    return "Error in service";
                }
            }
            else
            {
                return "You aren't old enough to be customer";
            }
        }

        public string DeleteByID(int id)
        {
            if(id < 0) 
            {
                return "Id should be greater than or equal to 0";
            }
            try
            {
                return _cs.DeleteByID(id);
            }
            catch
            {
                return "Error in Service";
            }
        }

        public IEnumerable<Customers> GetAll()
        {
            try
            {
                return _cs.GetAll();
            }
            catch
            {
                return Enumerable.Empty<Customers>();
            }
        }

        public Customers GetByID(int id)
        {
            if (id < 0)
            {
                return new Customers();
            }
            try
            {
                return _cs.GetByID(id);
            }
            catch
            {
                return new Customers();
            }
        }

        public string Update(int id, CustomersDTO customer)
        {
            if (id < 0)
            {
                return "Id should be greater than or equal to 0";
            }
            if (customer.Full_Name == "" || customer.Full_Name == null)
            {
                return "Name isn't null";
            }
            if(customer.Age > 11)
            {
                try
                {
                    return _cs.Update(id, customer);
                }
                catch
                {
                    return "Error in Service";
                }
            }
            else
            {
                return "The age is small";
            }
        }
    }
}
