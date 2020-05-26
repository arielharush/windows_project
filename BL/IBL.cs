using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        void addShop(Shop shop);
        void updateShop(Shop shop);
        void deleteShop(int id);



        void addProduct(Product product);
        void updateProduct(Product product);
        void deleteProduct(int id);

        List<Shop> getShopsList();
        List<Product> getProductsList();

        Shop getShopByID(int id);
        Product getProductById(int id);














    }
}
