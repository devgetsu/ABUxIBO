using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.Repository.ShopCRUD
{
    public interface IShopCRUD
    {
        public string Create(Shop shop);
        public IEnumerable<Shop> GetAll();
        public Shop GetByID(int id);
        public string DeleteByID(int id);
        public Shop Update(int id, Shop product);
    }
}
