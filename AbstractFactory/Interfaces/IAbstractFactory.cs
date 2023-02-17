using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatten.Interfaces
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ICofeeTable CreateCofeeTable();
        ISofa CreateSofa();
    }
}
