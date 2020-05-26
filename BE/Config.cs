using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public struct Address
    {
        public String city { set; get; }
        public String street { set; get; }
        public int num { set; get; }

       
    }

    public struct NutritionalValues
    {
     public int energy { get; set; }
        public int protein { get; set; }
        public int fats { get; set; }
    }


    public class Config
    {

    }
}
