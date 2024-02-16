using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.MyServices.IServices;
using Online.Marketplace.Repository.CustomerCRUD;
using Online.Marketplace.Repository.ShopCRUD;

namespace Online.Marketplace.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _cusSer;

        public CustomerController(ICustomerService cus)
        {
            _cusSer = cus;
        }

        [HttpPost]
        public string Create(CustomersDTO cs)
        {
            string? res = _cusSer.Create(cs);
            return res;
        }
        [HttpGet]
        public Customers GetById(int id)
        {
            Customers? x = _cusSer.GetByID(id);
            return x;
        }
        [HttpGet]
        public IEnumerable<Customers> GetAll()
        {
            IEnumerable<Customers>? x = _cusSer.GetAll();
            return x;
        }
        [HttpDelete]
        public string DeleteById(int id)
        {
            string? x = _cusSer.DeleteByID(id);
            return x;
        }
        [HttpPut]
        public string Update(int id, CustomersDTO css)
        {
            string? x = _cusSer.Update(id, css);
            return x;
        }
    }
}
