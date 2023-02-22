namespace Builder2
{
    internal class HouseBlockBuilder : IHouseBuilder
    {
        private House house = new();

        public HouseBlockBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            house = new House();
        }

        public void BuildDoors()
        {
            house.Doors = "Doors of block";
        }

        public void BuildWalls()
        {
            house.Walls = "Walls of block";
        }

        public void BuildWindows()
        {
            house.Windows = "Windows of block";
        }

        public void BuildPool()
        {
            house.Pool = "Pool of block house";
        }

        public House GetHouse()
        {

            House result = house;

            this.Reset();

            return result;
        }
    }
}
