using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BasketballBall : IBall
    {
        public int BallSize()
        {
            return 23;
        }

        public int Pounds()
        {
            return 11;
        }
    }
}
