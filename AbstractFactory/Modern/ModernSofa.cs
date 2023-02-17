using AbstractFactoryPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Modern
{
    public class ModernSofa : ISofa
    {
        public string Legs()
        {
            return "Has ModernSofa style";
        }
    }
}
