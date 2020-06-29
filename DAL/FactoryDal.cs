using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FactoryDal
    {
        protected FactoryDal() { }
        protected static Dal_imp instance = null;
        public static Idal getDal()
        {
            if (instance == null)
            {
                instance = new Dal_imp();
            }
            return instance;
        }

    }
}
