using Builder2;
using System;

HouseDirector director = new();
HouseWoodBuilder builderHouseWood = new();
HouseBlockBuilder builderHouseBlock = new();


#region HouseWoodBuilder
director.HouseWithPool(builderHouseWood);
House houseWoodWithPool = builderHouseWood.GetHouse();
Console.WriteLine(houseWoodWithPool.Walls);
Console.WriteLine(houseWoodWithPool.Doors);
Console.WriteLine(houseWoodWithPool.Windows);
Console.WriteLine(houseWoodWithPool.Pool);
#endregion

Console.WriteLine();

#region HouseBlockBuilder
director.HouseWithPool(builderHouseBlock);
House houseBlockWithPool = builderHouseBlock.GetHouse();
Console.WriteLine(houseBlockWithPool.Walls);
Console.WriteLine(houseBlockWithPool.Doors);
Console.WriteLine(houseBlockWithPool.Windows);
Console.WriteLine(houseBlockWithPool.Pool);
#endregion


//director.HouseBuilder = builderHouseBlock;