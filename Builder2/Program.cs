using Builder2;
using System;

HouseDirector director = new();
HouseWoodBuilder builderHouseWood = new();
HouseBlockBuilder builderHouseBlock = new();


#region HouseWoodBuilder
director.HouseBuilder = builderHouseWood;
director.HouseWithPool();
House houseWood = builderHouseWood.GetHouse();
Console.WriteLine(houseWood.Walls);
Console.WriteLine(houseWood.Doors);
Console.WriteLine(houseWood.Windows);
Console.WriteLine(houseWood.Pool);
#endregion
Console.WriteLine();

#region HouseBlockBuilder

director.HouseBuilder = builderHouseBlock;
director.HouseWithPool();

House houseBlock = builderHouseBlock.GetHouse();
Console.WriteLine(houseBlock.Walls);
Console.WriteLine(houseBlock.Doors);
Console.WriteLine(houseBlock.Windows);
Console.WriteLine(houseBlock.Pool);
#endregion


//director.HouseBuilder = builderHouseBlock;