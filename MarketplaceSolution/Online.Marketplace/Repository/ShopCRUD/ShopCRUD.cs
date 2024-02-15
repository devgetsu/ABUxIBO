using Dapper;
using Npgsql;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.Repository.ShopCRUD
{
    public class ShopCRUD : IShopCRUD
    {
        public IConfiguration _config;
        public ShopCRUD(IConfiguration config)
        {
            _config = config;
        }
        public string Create(ShopsDTO shop)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "insert into Shops(shop_name) " +
                        "values(@Shop_Name);";

                    ShopsDTO? parameters = new ShopsDTO
                    {
                        Shop_Name = shop.Shop_Name,
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
                    string query = "delete from shops where id = @aydi";

                    con.Execute(query, new { aydi = id });

                    return "Succesfully";
                }
            }
            catch
            {
                return "ERROR";
            }
        }

        public IEnumerable<Shops> GetAll()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
            {
                string query = "select * from shops";

                IEnumerable<Shops>? responce = con.Query<Shops>(query);

                return responce;
            }
        }

        public Shops GetByID(int id)
        {
            try
            {

                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "select * from shops where id = @aydi";

                    List<Shops>? responce = con.Query<Shops>(query, new { aydi = id }).ToList();

                    return responce[0];
                }
            }
            catch
            {
                return new Shops() { };
            }
        }

        public string Update(int id, ShopsDTO shops)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "update shops set shop_name=@shop_name where id = @aydi";

                    con.Execute(query, new
                    {
                        shop_name=shops.Shop_Name,
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
