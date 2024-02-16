using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.MyServices.IServices
{
    public interface IShopService
    {
        public string Create(ShopsDTO shop);
        public IEnumerable<Shops> GetAll();
        public Shops GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id, ShopsDTO shop);
    }
}
