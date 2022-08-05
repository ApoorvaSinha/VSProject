using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Honda : Icar
    {
        public string GetCarDetails()
        {
            return "Honda";
        }
    }
    class Maruti : Icar
    {
        public string GetCarDetails()
        {
            return "Maruti";
        }
    }
    class KIA : Icar
    {
        public string GetCarDetails()
        {
            return "KIA";
        }
    }
}
