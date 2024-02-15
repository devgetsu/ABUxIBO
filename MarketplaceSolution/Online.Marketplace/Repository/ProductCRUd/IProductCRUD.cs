using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using System.Globalization;

namespace Online.Marketplace.Repository.ProductCRUd
{
    public interface IProductCRUD
    {
        public string Create(ProductDTO product);
        public IEnumerable<Product> GetAll();

    }
}
