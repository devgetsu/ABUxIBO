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
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "delete from products where id = @aydi";

                    con.Execute(query, new { aydi = id });

                    return "Succesfully";
                }
            }
            catch
            {
                return "ERROR";
            }
        }

        public IEnumerable<Customers> GetAll()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
            {
                string query = "select * from customer";

                IEnumerable<Customers>? responce = con.Query<Customers>(query);

                return responce;
            }
        }

        public Customers GetByID(int id)
        {
            try
            {

                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "select * from customer where id = @aydi";

                    List<Customers>? responce = con.Query<Customers>(query, new { aydi = id }).ToList();

                    return responce[0];
                }
            }
            catch
            {
                return new Customers() { };
            }
        }

        public string Update(int id, CustomersDTO customer)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "update customer set full_name = @full_name,age=@age where id = @aydi";

                    con.Execute(query, new
                    {
                        full_name=customer.Full_Name,
                        age=customer.Age,
                        aydi = id
                    });

                    return "Succesfully";
                }
            }
            catch
            {
                return "ERROR";
            }
        }
    }
}
