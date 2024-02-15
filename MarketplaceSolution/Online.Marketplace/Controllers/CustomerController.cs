using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.Repository.CustomerCRUD;
using Online.Marketplace.Repository.ShopCRUD;

namespace Online.Marketplace.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerCRUD _cusRepo;

        public CustomerController(ICustomerCRUD cus)
        {
            _cusRepo = cus;
        }

        [HttpPost]
        public string Create(CustomersDTO cs)
        {
            var res = _cusRepo.Create(cs);
            return res;
        }
        [HttpGet]
        public Customers GetById(int id)
        {
            var x = _cusRepo.GetByID(id);
            return x;
        }
        [HttpGet]
        public IEnumerable<Customers> GetAll()
        {
            var x = _cusRepo.GetAll();
            return x;
        }
        [HttpDelete]
        public string DeleteById(int id)
        {
            var x = _cusRepo.DeleteByID(id);
            return x;
        }
        [HttpPut]
        public string Update(int id, CustomersDTO css)
        {
            var x = _cusRepo.Update(id, css);
            return x;
        }
    }
}
