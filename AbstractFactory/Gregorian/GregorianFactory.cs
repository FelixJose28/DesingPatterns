using AbstractFactoryPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Gregorian
{
    public class GregorianFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new GregorianChair();
        }

        public ICofeeTable CreateCofeeTable()
        {
            return new GregorianCofeeTable();
        }

        public ISofa CreateSofa()
        {
            return new GregorianSofa();
        }
    }
}
