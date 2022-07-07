using AbstractFactoryPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Gregorian
{
    public class GregorianSofa : ISofa
    {
        public string Legs()
        {
            return "Has GregorianSofa style";
        }
    }
}
