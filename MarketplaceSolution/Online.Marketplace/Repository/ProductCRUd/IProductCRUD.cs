using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using System.Globalization;

namespace Online.Marketplace.Repository.ProductCRUd
{
    public interface IProductCRUD
    {
        public string Create(ProductDTO product);
        public IEnumerable<Product> GetAll();
        public Product GetByID(int id);
        public string DeleteByID(int id);
        public Product Update(int id,ProductDTO product);

    }
}
