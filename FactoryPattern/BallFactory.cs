using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class BallFactory
    {
        public const string BaseballConst = "baseball";
        public const string BasketballConst = "basketball";
        /// <summary>
        /// Factory method, objects returned by a factory method are often referred to as products.
        /// </summary>
        /// <param name="BallType">this condition can be a number or other data type that the user can 
        /// type in the console, for example a number that represent how much money do you have</param>
        /// <returns></returns>
        public static IBall GetBall(string BallType)
        {
            switch (BallType)
            {
                case BaseballConst:
                        return new BaseballBall();
                case BasketballConst:
                        return new BasketballBall();
                default:
                    return null;
            }
        }
    }
}
