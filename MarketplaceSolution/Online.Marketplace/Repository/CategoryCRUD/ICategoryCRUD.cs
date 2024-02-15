using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.Repository.CategoryCRUD
{
    public interface ICategoryCRUD
    {
        public string Create(CategoryDTO category);
        public IEnumerable<Category> GetAll();

        public Category GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id, CategoryDTO category);
    }
}
