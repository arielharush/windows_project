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

        public List<Product> getProductsListByListOfId(List<int> ids)
        {
            List<Product> temp = new List<Product>();
            for (int i = 0; i < ids.Count; i++)
            {
                temp.Add(getProductById(ids[i]));
            }
            return temp;
        }

        public Shop getShopByID(int id)
        {
            return Dal.shop_by_id(id);
        }

        public List<Shop> getShopsByName(string txt)
        {
            List<Shop> temp = new List<Shop>();
            for (int i = 0; i < getShopsList().Count; i++)
            {
                if (getShopsList()[i].name.ToLower().Contains(txt.ToLower()) == true) {

                    temp.Add(getShopsList()[i]);
                }
            }
            return temp;
        }

        public List<Shop> getShopsList()
        {
            return Dal.getShopsList();
        }

        public List<Shop> getShopsThatHaveProduct(int id)
        {
            List<Shop> temp = new List<Shop>();
            for (int i = 0; i < getShopsList().Count; i++)
            {
                if (getShopsList()[i].products != null)
                {
                    if (getShopsList()[i].products.Any((x) => x == id) == true)
                    {

                        temp.Add(getShopsList()[i]);
                    }
                }
            }
            return temp;
        }

        public List<Product> productsByName(string txt)
        {
            List<Product> temp = new List<Product>();
            for (int i = 0; i < getProductsList().Count; i++)
            {
                if (getProductsList()[i].name.ToLower().Contains(txt.ToLower()) == true) {

                    temp.Add(getProductsList()[i]);
                }

            }

            return temp;
        }

        

        public void updateProduct(Product product)
        {
            Dal.updateProduct(product);
        }

        public void updateShop(Shop shop)
        {
            Dal.updateShop(shop);
        }
    }
}
