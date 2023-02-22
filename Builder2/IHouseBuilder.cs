namespace Builder2
{
    internal interface IHouseBuilder
    {
        public void BuildWalls();
        public void BuildDoors();
        public void BuildWindows();
        public void BuildPool();
        public void Reset();
    }
}
