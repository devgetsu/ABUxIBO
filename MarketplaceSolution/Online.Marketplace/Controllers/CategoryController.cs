using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.MyServices.IServices;
using Online.Marketplace.Repository.CategoryCRUD;

namespace Online.Marketplace.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categorySer;
        public CategoryController(ICategoryService categoryRepo)
        {
            _categorySer = categoryRepo;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            IEnumerable<Category>? x = _categorySer.GetAll();
            return x;
        }
        [HttpGet]
        public Category GetById(int id)
        {
            Category? x = _categorySer.GetByID(id);
            return x;
        }
        [HttpPost]
        public string Create(CategoryDTO category)
        {
            string? x = _categorySer.Create(category);
            return x;
        }
        [HttpDelete]
        public string Delete(int id)
        {
            string? x = _categorySer.DeleteByID(id);
            return x;
        }
        [HttpPut]
        public string Update(int id,CategoryDTO category)
        {
            string? x = _categorySer.Update(id, category);
            return x;
        }
    }
}
