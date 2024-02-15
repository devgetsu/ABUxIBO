using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.Repository.ShopCRUD;

namespace Online.Marketplace.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly IShopCRUD _shopRepo;

        public ShopController(IShopCRUD shop)
        {
            _shopRepo = shop;
        }

        [HttpPost]
        public string Create(ShopsDTO shps)
        {
            var res = _shopRepo.Create(shps);
            return res;
        }
        [HttpGet]
        public Shops GetById(int id)
        {
            var x = _shopRepo.GetByID(id);
            return x;
        }
        [HttpGet]
        public IEnumerable<Shops> GetAll()
        {
            var x = _shopRepo.GetAll();
            return x;
        }
        [HttpDelete]
        public string DeleteById(int id)
        {
            var x = _shopRepo.DeleteByID(id);
            return x;
        }
        [HttpPut]
        public string Update(int id, ShopsDTO shops)
        {
            var x = _shopRepo.Update(id, shops);
            return x;
        }
    }
}
