using Iterator;
using System;


/*
 what is: Iterator is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).
 When use: Use the Iterator pattern when your collection has a complex data structure under the hood, but you want to hide its complexity from clients
 */

MyEnumerableCollection myEnumerable = new();
foreach (var element in myEnumerable)
{
    Console.WriteLine(element);
}
