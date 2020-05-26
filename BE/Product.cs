using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
namespace BE
{
    public class Product
    {

        public int id { get; set; }
        public String name { get; set; }
        public float adminRate;
        public void AdminRate(float t)
        {
            if (t > 5 || t < 0)
            {
                throw new Exception();
            }
            this.adminRate = t;

        }
        public float AdminRate()
        {
            return this.adminRate;
        }

        // List<Image> adminImage { get; set; }
        public int idForAnalysis { get; set; }



        public NutritionalValues nutritionalValues { get; set; }

        public Product(int id , string name, float adminRate, int idForAnalysis) {

            this.id = id;
            this.name = name;
            this.AdminRate(adminRate);
            this.idForAnalysis = idForAnalysis;

        }



        public Product(Product t) {
            this.id = t.id;
            this.name = t.name;
            this.AdminRate(t.adminRate);
            this.idForAnalysis = t.idForAnalysis;
            this.nutritionalValues = t.nutritionalValues;
        }



        public Product() {

            this.id = 0;
            this.name = "";
            this.AdminRate(0);
            this.idForAnalysis = 0;
            NutritionalValues nutritionalValues = new NutritionalValues();
            nutritionalValues.energy = 0;
            nutritionalValues.fats = 0;
            nutritionalValues.protein = 0;
            this.nutritionalValues = nutritionalValues;

        }





    }
}
