using AbstractFactoryPatten.Gregorian;
using AbstractFactoryPatten.Interfaces;
using AbstractFactoryPatten.Modern;
using AbstractFactoryPatten.Victorian;
using System;


/*
 what is: is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.
 When use: Use the Abstract Factory when your code needs to work with various families of related products, but you don’t want it to depend on the concrete classes of those products—they might be unknown beforehand or you simply want to allow for future extensibility.
 */


IAbstractFactory gFactory = new GregorianFactory();
IChair gChair = gFactory.CreateChair();
ICofeeTable gcofeeTable = gFactory.CreateCofeeTable();
ISofa gsofa = gFactory.CreateSofa();
Console.WriteLine(gChair.Legs());
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
