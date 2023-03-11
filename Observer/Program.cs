// See https://aka.ms/new-console-template for more information
using Observer;

/*
 what is: Observer Observer is a behavioral design pattern that allows some objects to notify other objects about changes in their state.
 When use: Use the Observer pattern when changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically. 
 */

Subject subject = new();
ObserverA observerA = new();
subject.Subscribe(observerA);

ObserverB observerB = new();
subject.Subscribe(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.Unsubscribe(observerB);

subject.SomeBusinessLogic();