using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class BL_imp : IBL
    {
        DAL.Idal Dal = DAL.FactoryDal.getDal();
        public void addProduct(Product product)
        {
            Dal.addProduct(product);
        }

        public void addShop(Shop shop)
        {
            Dal.addShop(shop);
        }

        public void deleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void deleteShop(int id)
        {
            throw new NotImplementedException();
        }

        public Product getProductById(int id)
        {
            return Dal.product_by_id(id);
        }

        public List<Product> getProductsList()
        {
            return Dal.getProductsList();
        }

        public Shop getShopByID(int id)
        {
            return Dal.shop_by_id(id);
        }

        public List<Shop> getShopsList()
        {
            return Dal.getShopsList();
        }

        public void updateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void updateShop(Shop shop)
        {
            throw new NotImplementedException();
        }
    }
}
