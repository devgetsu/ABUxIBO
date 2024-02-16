using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.MyServices.IServices;
using Online.Marketplace.Repository.CategoryCRUD;

namespace Online.Marketplace.MyServices.Services
{
    public class CategoryService : ICategoryService
    {
        public ICategoryCRUD _cr;
        public CategoryService(ICategoryCRUD cr)
        {
            _cr = cr;
        }

        public string Create(CategoryDTO category)
        {
            if (category.Category_name == null || category.Category_name == "")
            {
                return "Service error name is null";
            }
            try
            {
                return _cr.Create(category);
            }
            catch
            {
                return "Error in service";
            }

        }

        public string DeleteByID(int id)
        {
            if(id < 0)
            {
                return "Id should be greater than or equal to 0";
            }
            try
            {
                return _cr.DeleteByID(id);
            }
            catch
            {
                return "Error in service";
            }
        }

        public IEnumerable<Category> GetAll()
        {
            try
            {
                return _cr.GetAll();
            }
            catch
            {
                return Enumerable.Empty<Category>();
            }
        }

        public Category GetByID(int id)
        {
            if (id < 0)
            {
                return new Category();
            }
            try
            {
                return _cr.GetByID(id);
            }
            catch
            {
                return new Category();
            }
        }

        public string Update(int id, CategoryDTO category)
        {
            if (id < 0)
            {
                return "Id should be greater than or equal to 0";
            }
            if (category.Category_name == null || category.Category_name == "")
            {
                return "Service error name is null";
            }
            try
            {
                return _cr.Update(id, category);
            }
            catch
            {
                return "Error in service";
            }
        }
    }
}
