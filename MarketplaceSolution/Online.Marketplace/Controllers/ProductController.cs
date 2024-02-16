using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.MyServices.IServices;
using Online.Marketplace.Repository.ProductCRUd;

namespace Online.Marketplace.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productSer;
        public ProductController(IProductService ser)
        {
            _productSer = ser;
        }

        [HttpPost]
        public string Create(ProductDTO product)
        {
            string? res = _productSer.Create(product);
            return res;
        }
        [HttpGet]
        public Product GetById(int id)
        {
            Product? x = _productSer.GetByID(id);
            return x;
        }
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            IEnumerable<Product>? x = _productSer.GetAll();
            return x;
        }
        [HttpDelete]
        public string DeleteById(int id)
        {
            string? x = _productSer.DeleteByID(id);
            return x;
        }
        [HttpPut]
        public string Update(int id, ProductDTO product)
        {
            string? x = _productSer.Update(id, product);
            return x;
        }

    }
}
