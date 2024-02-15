using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.Repository.ProductCRUd;

namespace Online.Marketplace.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductCRUD _productRepo;
        public ProductController(IProductCRUD repo)
        {
            _productRepo = repo;
        }

        [HttpPost]
        public string Create(ProductDTO product)
        {
            var res = _productRepo.Create(product);
            return res;
        }
        [HttpGet]
        public Product GetById(int id)
        {
            var x = _productRepo.GetByID(id);
            return x;
        }
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            var x = _productRepo.GetAll();
            return x;
        }
        [HttpDelete]
        public string DeleteById(int id)
        {
            var x = _productRepo.DeleteByID(id);
            return x;
        }
        [HttpPut]
        public string Update(int id, ProductDTO product)
        {
            var x = _productRepo.Update(id, product);
            return x;
        }

    }
}
