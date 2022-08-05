using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HondaFactory : CarFactory
    {
        protected override Icar MakeProduct()
        {
            Icar product = new Honda();
            return product;
        }
    }
    public class MarutiFactory : CarFactory
    {
        protected override Icar MakeProduct()
        {
            Icar product = new Maruti();
            return product;
        }
    }
    public class KIAFactory : CarFactory
    {
        protected override Icar MakeProduct()
        {
            Icar product = new KIA();
            return product;
        }
    }
}
