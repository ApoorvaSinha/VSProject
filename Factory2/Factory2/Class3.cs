using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class CarFactory
    {
        protected abstract Icar MakeProduct();
        public Icar CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
