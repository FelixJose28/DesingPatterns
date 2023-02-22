namespace Builder2
{
    internal class HouseDirector
    {
        public IHouseBuilder HouseBuilder { get; set; }

        public void HouseNormal()
        {
            HouseBuilder.BuildWalls();
            HouseBuilder.BuildDoors();
            HouseBuilder.BuildWindows();
        }


        public void HouseWithPool()
        {
            HouseBuilder.BuildWalls();
            HouseBuilder.BuildDoors();
            HouseBuilder.BuildWindows();
            HouseBuilder.BuildPool();
        }
    }
}
