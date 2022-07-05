using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BaseballBall : IBall
    {
        public int BallSize()
        {
            return 10;
        }

        public int Pounds()
        {
            return 5;
        }
    }
}
