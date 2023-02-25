namespace Builder2
{
    internal class HouseDirector
    {
        public void HouseNormal(IHouseBuilder HouseBuilder)
        {
            HouseBuilder.BuildWalls();
            HouseBuilder.BuildDoors();
            HouseBuilder.BuildWindows();
        }


        public void HouseWithPool(IHouseBuilder HouseBuilder)
        {
            HouseBuilder.BuildWalls();
            HouseBuilder.BuildDoors();
            HouseBuilder.BuildWindows();
            HouseBuilder.BuildPool();
        }
    }
}
