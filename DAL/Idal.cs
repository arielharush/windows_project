using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface Idal
    {
       
        void addShop(BE.Shop shop);
       
        void deleteShop(BE.Shop shop);

        void updateShop(BE.Shop shop);


       
        void addProduct(BE.Product product);
      
        void deletProduct(BE.Product product);
     
        void updateProduct(BE.Product product);


      
    

        BE.Shop shop_by_id(int id);
       
        BE.Product product_by_id(int id);
       
        
        List<BE.Product> getProductsList();
  
        List<BE.Shop> getShopsList();
      
       
    }
}
