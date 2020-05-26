using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BE
{
    public class Shop
    {

        public int id { set; get; }
        public string name { set; get; }
        public Address address { set; get; }
        public  Image image { get; set; }
        public string phone { get; set; }
        public string webSite { get; set; }
        public string faceBook { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// if to make map insted list
        public List<int> products { get; set; }

        public Shop() {
            this.id = 0;
            Address address = new Address();
            address.city = "";
            address.street = "";
            address.num = 0;
            this.address = address;
            this.phone = "";
            this.webSite = "";
            this.faceBook = "";
            this.name = "";
            this.products = new List<int>();
            
        }
        public Shop(Shop t)
        {
            this.image = t.image;
            this.id = t.id;
            Address address = new Address();
            address.city = t.address.city;
            address.street = t.address.street;
            address.num = t.address.num;
            this.address = address;
            this.phone = t.phone;
            this.webSite = t.webSite;
            this.faceBook = t.faceBook;
            this.products = new List<int>(t.products);
            this.name = t.name;

        }


        public Shop(int id ,string name, Address address, string phone, string webSite, string facebook) {

            this.id = id;
            this.address = address;
            this.phone = phone;
            this.webSite = webSite;
            this.faceBook = facebook;
            this.name = name;


        }

    }
}
