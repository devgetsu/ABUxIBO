using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;

namespace Online.Marketplace.Repository.ShopCRUD
{
    public interface IShopCRUD
    {
        public string Create(ShopsDTO shop);
        public IEnumerable<Shops> GetAll();
        public Shops GetByID(int id);
        public string DeleteByID(int id);
        public string Update(int id, ShopsDTO product);
    }
}
 
//hello                 