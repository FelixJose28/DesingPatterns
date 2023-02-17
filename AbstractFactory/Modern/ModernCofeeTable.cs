using AbstractFactoryPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Modern
{
    public class ModernCofeeTable : ICofeeTable
    {
        public string Legs()
        {
            return "Has ModernCofeeTable style";
        }
    }
}
