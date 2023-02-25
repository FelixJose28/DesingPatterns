// See https://aka.ms/new-console-template for more information
using PrototypeCustomClone;
using System;
PrototypeRegistry prototypeRegistry = new();

PPersonShadowCopy defaultPerson = (PPersonShadowCopy)prototypeRegistry.GetPrototype("DefaultPerson");
PPersonShadowCopy defaultPersonCopy = (PPersonShadowCopy)prototypeRegistry.GetPrototype("DefaultPerson");
PCarDeepCopy defaultCar = (PCarDeepCopy)prototypeRegistry.GetPrototype("DefaultCar");
PCarDeepCopy defaultCarCopy = (PCarDeepCopy)prototypeRegistry.GetPrototype("DefaultCar");

Console.WriteLine(defaultPerson.Name);
Console.WriteLine(defaultPerson.Age);
Console.WriteLine();
Console.WriteLine(defaultCar.Model);
Console.WriteLine(defaultCar.Year);
Console.WriteLine(defaultCar.AccessoriesProp.FrontLights);
Console.WriteLine(defaultCar.AccessoriesProp.Stereo);

Console.WriteLine();
Console.WriteLine("After Clone");
defaultPersonCopy.Name = "Name Changed";
defaultPersonCopy.Age = 100;
defaultCarCopy.Model = "Model Changed";
defaultCarCopy.Year = 1999;
defaultCarCopy.AccessoriesProp.FrontLights = "Custom frontLights";
defaultCarCopy.AccessoriesProp.Stereo = "Custom stereo";
Console.WriteLine();

Console.WriteLine(defaultPerson.Name);
Console.WriteLine(defaultPerson.Age);
Console.WriteLine(defaultPersonCopy.Name);
Console.WriteLine(defaultPersonCopy.Age);
Console.WriteLine("---------------");
Console.WriteLine(defaultCar.Model);
Console.WriteLine(defaultCar.Year);
Console.WriteLine(defaultCar.AccessoriesProp.FrontLights);
Console.WriteLine(defaultCar.AccessoriesProp.Stereo);
Console.WriteLine(defaultCarCopy.Model);
Console.WriteLine(defaultCarCopy.Year);
Console.WriteLine(defaultCarCopy.AccessoriesProp.FrontLights);
Console.WriteLine(defaultCarCopy.AccessoriesProp.Stereo);
Console.WriteLine();

PPersonShadowCopy customPerson = new("Lebron James", 38);
prototypeRegistry.AddPrototype("Goat", customPerson);
PPersonShadowCopy addedPerson = (PPersonShadowCopy)prototypeRegistry.GetPrototype("Goat");
Console.WriteLine(addedPerson.Name);
Console.WriteLine(addedPerson.Age);