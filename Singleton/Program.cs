// See https://aka.ms/new-console-template for more information
using SingletonPattern;
using System;

/*
 what is: Singleton is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.
 When use: Use the Singleton pattern when a class in your program should have just a single instance available to all clients; for example, a single database object shared by different parts of the program.
 */


Singleton singleton = Singleton.GetInstance;
Console.WriteLine(singleton.message);
singleton.message = "modified";
Console.WriteLine(singleton.message);