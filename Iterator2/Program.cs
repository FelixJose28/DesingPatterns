using Iterator2;
using System;

/*
 what is: Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).
 When use: Use the Iterator pattern when your collection has a complex data structure under the hood, but you want to hide its complexity from clients
 */


var collection = new MyEnumerableCollection();
collection.AddItem("1");
collection.AddItem("2");
collection.AddItem("5");
collection.AddItem("4");

Console.WriteLine("Straight traversal:");

foreach (var element in collection)
{
    Console.WriteLine(element);
}

Console.WriteLine("\nReverse traversal:");

collection.ReverseDirection();

foreach (var element in collection)
{
    Console.WriteLine(element);
}
