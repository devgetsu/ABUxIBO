using Online.Marketplace.Entities.DTOs;
using Online.Marketplace.Models;
using Online.Marketplace.MyServices.IServices;
using Online.Marketplace.Repository.ShopCRUD;

namespace Online.Marketplace.MyServices.Services
{
    public class ShopService : IShopService
    {
        public IShopCRUD _shp;
        public ShopService(IShopCRUD shopCRUD)
        {
            _shp = shopCRUD;
        }
        public string Create(ShopsDTO shop)
        {
            if (shop.Shop_Name == null || shop.Shop_Name == "")
            {
                return "Service error name null error";
            }
            try
            {
                return _shp.Create(shop);
            }
            catch
            {
                return "Error in service";
            }
        }

        public string DeleteByID(int id)
        {
            if (id < 0)
            {
                return "Id should be greater then or equal to 0";
            }
            try
            {
                return _shp.DeleteByID(id);
            }
            catch
            {
                return "Error in service";
            }
        }

        public IEnumerable<Shops> GetAll()
        {
            try
            {
                return _shp.GetAll();
            }
            catch
            {
                return Enumerable.Empty<Shops>();
            }
        }

        public Shops GetByID(int id)
        {
            if (id < 0)
            {
                return new Shops();
            }
            try
            {
                return _shp.GetByID(id);
            }
            catch
            {
                return new Shops();
            }
        }

        public string Update(int id, ShopsDTO shop)
        {
            if (id < 0)
            {
                return "Id should be greater then or equal to 0";
            }
            if (shop.Shop_Name == null || shop.Shop_Name == "")
            {
                return "Service error name null error";
            }
            try
            {
                return _shp.Update(id, shop);
            }
            catch
            {
                return "Error in Services";
            }
        }
    }
}
