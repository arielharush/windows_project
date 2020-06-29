using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Dal_imp : Idal
    {
        public void addProduct(Product product)
        {
            
            DS.DataSource.Products.Add(product);
        }




        public void addShop(Shop shop)
        {
            DS.DataSource.shops.Add(shop);
        }




        public void deleteShop(Shop shop)
        {
            bool flag = DS.DataSource.shops.Remove(shop);
            if (!flag)
            {
                throw new Exception("Shop not exists");
            }
        }



        public void deletProduct(Product product)
        {
            bool flag = DS.DataSource.Products.Remove(product);
            if (!flag)
            {
                throw new Exception("Product not exists");
            }
        }




        public List<Product> getProductsList()
        {
            return new List<Product>(DS.DataSource.Products);

        }

        public List<Shop> getShopsList()
        {
            return new List<Shop>(DS.DataSource.shops);

        }

        public Shop shop_by_id(int id)
        {
            var shop = from t in getShopsList()
                         where t.id == id
                         select t;
            if (shop.Count() == 0)
                throw new Exception("No exist this Shop");
            Shop final = new Shop();
            foreach (var item in shop)
            {
                final = item;
            }
            return final;
        }

        public Product product_by_id(int id)
        {
            var product = from t in getProductsList()
                       where t.id == id
                       select t;
            if (product.Count() == 0)
                throw new Exception("No exist this product");
            Product final = new Product();
            foreach (var item in product)
            {
                final = item;
            }
            return final;
        }

        public void updateProduct(Product product)
        {
            for (int i = 0; i < DS.DataSource.Products.Count; i++)
            {
                if (DS.DataSource.Products[i].id == product.id)
                {
                    Product temp = new Product(product);
                 
                    DS.DataSource.Products[i] = temp;

                    return;
                }
            }


            throw new Exception("Product not exists");

        }

        public void updateShop(Shop shop)
        {
            for (int i = 0; i < DS.DataSource.shops.Count; i++)
            {
                if (DS.DataSource.shops[i].id == shop.id)
                {
                    Shop temp = new Shop(shop);

                    DS.DataSource.shops[i] = temp;

                    return;
                }
            }


            throw new Exception("Shop not exists");

        }
    }
}
