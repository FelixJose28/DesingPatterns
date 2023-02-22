namespace Builder2
{
    internal class HouseWoodBuilder : IHouseBuilder
    {
        private House house = new();

        public HouseWoodBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            house = new House();
        }

        public void BuildDoors()
        {
            house.Doors = "Doors of wood";
        }

        public void BuildWalls()
        {
            house.Walls = "Walls of wood";
        }

        public void BuildWindows()
        {
            house.Windows = "Windows of wood";
        }

        public void BuildPool()
        {
            house.Pool = "Pool of wood house";
        }

        public House GetHouse()
        {

            House result = house;

            this.Reset();

            return result;
        }
    }
}
