using AbstractFactoryPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Gregorian
{
    public class GregorianChair : IChair
    {
        public string Legs()
        {
            return "Has GregorianChair style";
        }
    }
}
