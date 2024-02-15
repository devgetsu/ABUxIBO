using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.Repository.CategoryCRUD;

namespace Online.Marketplace.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        private readonly ICategoryCRUD _categoryRepo;
        public MarketController(ICategoryCRUD categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            var x = _categoryRepo.GetAll();
            return x;
        }
        [HttpGet]
        public Category GetById(int id)
        {
            var x = _categoryRepo.GetByID(id);
            return x;
        }
        [HttpPost]
        public string Create(CategoryDTO category)
        {
            var x = _categoryRepo.Create(category);
            return x;
        }
        [HttpDelete]
        public string Delete(int id)
        {
            var x = _categoryRepo.DeleteByID(id);
            return x;
        }
        [HttpPut]
        public string Update(int id,CategoryDTO category)
        {
            var x = _categoryRepo.Update(id, category);
            return x;
        }
    }
}
