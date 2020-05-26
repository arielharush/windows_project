using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FactoryBL
    {
        protected FactoryBL() { }
        private static BL_imp Instance = null;


        public static IBL getBL()
        {
            if (Instance == null)
            {
                Instance = new BL_imp();
            }
            return Instance;
        }



    }
}
