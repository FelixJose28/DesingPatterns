// See https://aka.ms/new-console-template for more information
using SingletonPattern;
using System;

var singleton = Singleton.GetInstance;
Console.WriteLine(singleton.message);
singleton.message = "modified";
Console.WriteLine(singleton.message);