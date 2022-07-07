using AbstractFactoryPatten.Gregorian;
using AbstractFactoryPatten.Interfaces;
using AbstractFactoryPatten.Modern;
using AbstractFactoryPatten.Victorian;
using System;

IAbstractFactory gFactory = new GregorianFactory();
IChair gChair = gFactory.CreateChair();
ICofeeTable gcofeeTable = gFactory.CreateCofeeTable();
ISofa gsofa = gFactory.CreateSofa();
Console.WriteLine(gChair.Legs()) ;
Console.WriteLine(gcofeeTable.Legs());
Console.WriteLine(gsofa.Legs());
Console.WriteLine();


IAbstractFactory mFactory = new ModernFactory();
IChair mChair = mFactory.CreateChair();
ICofeeTable mcofeeTable = mFactory.CreateCofeeTable();
ISofa msofa = mFactory.CreateSofa();
Console.WriteLine(mChair.Legs());
Console.WriteLine(mcofeeTable.Legs());
Console.WriteLine(msofa.Legs());
Console.WriteLine();



IAbstractFactory vFactory = new VictorianFactory();
IChair vChair = vFactory.CreateChair();
ICofeeTable vcofeeTable = vFactory.CreateCofeeTable();
ISofa vsofa = vFactory.CreateSofa();
Console.WriteLine(vChair.Legs());
Console.WriteLine(vcofeeTable.Legs());
Console.WriteLine(vsofa.Legs());
