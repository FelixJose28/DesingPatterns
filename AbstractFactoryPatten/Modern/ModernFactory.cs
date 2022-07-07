using AbstractFactoryPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Modern
{
    public class ModernFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICofeeTable CreateCofeeTable()
        {
            return new ModernCofeeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
