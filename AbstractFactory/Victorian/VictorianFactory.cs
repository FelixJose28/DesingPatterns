using AbstractFactoryPatten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Victorian
{
    public class VictorianFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICofeeTable CreateCofeeTable()
        {
            return new VictorianCofeeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
