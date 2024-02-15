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
                        "values(@name,@price,@sh_id,@ct_id,@cs_id);";

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
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(int id, ProductDTO product)
        {
            throw new NotImplementedException();
        }

    }
}