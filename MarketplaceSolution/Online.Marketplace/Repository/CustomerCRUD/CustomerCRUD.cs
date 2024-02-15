using Dapper;
using Npgsql;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.Repository.CustomerCRUD
{
    public class CustomerCRUD : ICustomerCRUD
    {
        public IConfiguration _config;
        public CustomerCRUD(IConfiguration config)
        {
            _config = config;
        }
        public string Create(Customers customer)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "insert into customer(full_name,age) " +
                        "values(@full_name,@age);";

                    CustomersDTO? parameters = new CustomersDTO
                    {
                        Full_Name = customer.full_Name,
                        Age = customer.Age
                    };

                    con.Execute(query, parameters);

                    return "Succesfully";
                }
            }
            catch
            {
                return "ERROR";
            }
        }

        public string DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customers> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customers GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Customers Update(int id, CustomersDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
