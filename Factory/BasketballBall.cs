namespace Factory
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
