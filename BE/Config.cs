using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace BE
{
    public struct Address
    {
        public String city { set; get; }
        public String street { set; get; }
        public int num { set; get; }
        public double latitude { set; get; }
        public double longitude { set; get; }



    }

    public struct NutritionalValues
    {
     public int energy { get; set; }
        public int protein { get; set; }
        public int fats { get; set; }
    }

    

    public static class Config
    {
        private static int shopIDS = 0;
        private static int ProductIDS = 0;


        public static int getShopId() {

            int temp = shopIDS;
            shopIDS++;
            return temp;
        }

        public static int getProductId()
        {

            int temp = ProductIDS;
            ProductIDS++;
            return temp;
        }
    }

    public struct Nutrients
    {
        [JsonProperty("nutrientName")]
        public string Name { get; set; }

        [JsonProperty("unitName")]
        public string unitName { get; set; }

        [JsonProperty("value")]
        public double value { get; set; }

    }

    public class Food
    {
        [JsonProperty("fdcId")]
        public int fdcId { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("ingredients")]
        public string ingredients { get; set; }

        [JsonProperty("foodNutrients")]
        public IList<Nutrients> foodNutrients { get; set; }






    }
}
