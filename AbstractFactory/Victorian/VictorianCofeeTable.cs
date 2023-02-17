using AbstractFactoryPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Victorian
{
    public class VictorianCofeeTable : ICofeeTable
    {
        public string Legs()
        {
            return "Has VictorianCofeeTable style";
        }
    }
}
