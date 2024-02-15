using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Dapper;
using Npgsql;

namespace Online.Marketplace.Repository.ProductCRUd
{
    public class ProductCRUD : IProductCRUD
    {
        public IConfiguration _config;
        public ProductCRUD(IConfiguration config)
        {
            _config = config;
        }
        public string Create(ProductDTO product)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "insert into products(product_name,price,shop_id,category_id,customer_id) " +
                        "values(@Product_name,@Price,@Shop_id,@Category_id,@Customer_id);";

                    var parameters = new ProductDTO
                    {
                        Product_name = product.Product_name,
                        Price = product.Price,
                        Shop_id = product.Shop_id,
                        Category_id = product.Category_id,
                        Customer_id = product.Customer_id
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

        public IEnumerable<Product> GetAll()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
            {
                string query = "select * from products";

                var responce = con.Query<Product>(query);

                return responce;
            }
        }

        public Product GetByID(int id)
        {
            try
            {

                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "select * from products where id = @aydi";

                    var responce = con.Query<Product>(query, new { aydi = id }).ToList();

                    return responce[0];
                }
            }
            catch
            {
                return new Product() { };
            }
        }

        public string Update(int id, ProductDTO product)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "update products set product_name = @name,price = @pr,shop_id = @shp_id,category_id = @ct_id,customer_id = @cs_id where id = @aydi";

                    con.Execute(query, new {
                        name = product.Product_name,
                        pr = product.Price,
                        shp_id = product.Shop_id,
                        ct_id = product.Category_id,
                        cs_id = product.Customer_id,
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