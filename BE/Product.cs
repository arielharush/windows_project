using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Drawing;


namespace BE
{
    public class Product
    {
        private String url = "https://api.nal.usda.gov/fdc/v1/foods/search?api_key=QHuWgZVzW7SOdzqAhnPgWymmotZ9FCwcZp24MBjj";
        public int id { get; set; }
        public String name { get; set; }
        public float adminRate;
        public Image image { get; set; }
        public IList<Nutrients> nutritionalValues { get; set; }
        public string ingredients { get; set; }
        public string description { get; set; }
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



        

        public Product(int id , string name, float adminRate, int idForAnalysis) {

            this.id = id;
            this.name = name;
            this.AdminRate(adminRate);
            nutrients_api();
            

        }


        public Product(string name, float adminRate,Image image,int id)
        {

            this.id = id;
            this.name = name;
            this.AdminRate(adminRate);
            this.idForAnalysis = 0;
            this.image = image;
            nutrients_api();
        }




        public Product(Product t) {
            this.id = t.id;
            this.name = t.name;
            this.AdminRate(t.adminRate);
            nutrients_api();
        }



        public Product() {

            this.id = 0;
            this.name = "";
            this.AdminRate(0);
            this.idForAnalysis = 0;
            
            

        }


        void nutrients_api()
        {
            String query = Uri.EscapeUriString(this.name);
            this.url += "&query=" + query;
            var answer = Request.Get(url); //send the url to get function in web request
            var j = (JArray)JObject.Parse(answer)["foods"];
            var i = JsonConvert.DeserializeObject<List<Food>>(j.ToString());
            Food temp = i[0];
            this.nutritionalValues = temp.foodNutrients;
            this.ingredients = temp.ingredients;
            this.idForAnalysis = temp.fdcId;

        }


    }
}
