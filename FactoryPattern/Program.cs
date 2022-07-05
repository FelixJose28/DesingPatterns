// See https://aka.ms/new-console-template for more information
using FactoryPattern;
using System;

var factoryBaseballFac = BallFactory.getBall(BallFactory.BaseballConst);
Console.WriteLine(BallFactory.BaseballConst);
Console.WriteLine(factoryBaseballFac.BallSize()); 
Console.WriteLine(factoryBaseballFac.Pounds());

var factoryBasketballFac = BallFactory.getBall(BallFactory.BasketballConst);
Console.WriteLine(BallFactory.BasketballConst);
Console.WriteLine(factoryBaseballFac.BallSize());
Console.WriteLine(factoryBasketballFac.Pounds());
