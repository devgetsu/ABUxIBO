using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.Repository.ShopCRUD
{
    public interface IShopCRUD
    {
        public string Create(Shops shop);
        public IEnumerable<Shops> GetAll();
        public Shops GetByID(int id);
        public string DeleteByID(int id);
        public Shops Update(int id, Shops product);
    }
}
