// See https://aka.ms/new-console-template for more information
using Factory;
using System;

/*
 what is: Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
 When use: Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.
 */

var factoryBaseballFac = BallFactory.GetBall(BallFactory.BaseballConst);
Console.WriteLine(BallFactory.BaseballConst);
Console.WriteLine(factoryBaseballFac.BallSize());
Console.WriteLine(factoryBaseballFac.Pounds());

var factoryBasketballFac = BallFactory.GetBall(BallFactory.BasketballConst);
Console.WriteLine(BallFactory.BasketballConst);
Console.WriteLine(factoryBaseballFac.BallSize());
Console.WriteLine(factoryBasketballFac.Pounds());
