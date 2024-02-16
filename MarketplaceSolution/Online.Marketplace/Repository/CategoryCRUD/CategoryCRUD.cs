using Dapper;
using Npgsql;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.Repository.CategoryCRUD
{
    public class CategoryCRUD : ICategoryCRUD
    {
        public IConfiguration _config;
        public CategoryCRUD(IConfiguration config)
        {
            _config = config;
        }
        public string Create(CategoryDTO category)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "insert into category(category_name) " +
                        "values(@Category_name);";

                    var parameters = new CategoryDTO
                    {
                        Category_name = category.Category_name
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
                    string query = "delete from category where id = @aydi";

                    con.Execute(query, new { aydi = id });

                    return "Succesfully";
                }
            }
            catch
            {
                return "ERROR";
            }
        }

        public IEnumerable<Category> GetAll()
        {
            try
            {

                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "select * from category;";

                    var responce = con.Query<Category>(query);

                    return responce;
                }
            }
            catch
            {
                return Enumerable.Empty<Category>();
            }
        }

        public Category GetByID(int id)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "select * from category where id = @aydi";

                    var responce = con.Query<Category>(query, new { aydi = id }).ToList();

                    return responce[0];
                }
            }
            catch
            {
                return new Category() { };
            }
        }

        public string Update(int id, CategoryDTO category)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(_config.GetConnectionString("Postgres")))
                {
                    string query = "update category set category_name = @name where id = @aydi";

                    con.Execute(query, new
                    {
                        name = category.Category_name,
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
