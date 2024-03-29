﻿using BuilderSimplePattern;
using System;

/*
 what is: Builder is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.
 When use: When you have a big constructor
 */

var userBuilder = new UserBuilder();

var user1 = userBuilder
            .weight(175)
            .height(180)
            .name("Felix")
            .lastName("Ynfante")
            .nicknames("Child")
            .nicknames("Kid")
            .Build();


var user2 = userBuilder
            .weight(400)
            .height(400)
            .name("Felix2")
            .lastName("Ynfante2")
            .nicknames("Child2")
            .nicknames("Kid2")
            .Build();

var userProperties1 = user1.GetType().GetProperties();
foreach (var userProperty in userProperties1)
{
    Console.WriteLine(userProperty.GetValue(user1));
}
Console.WriteLine();
var userProperties2 = user2.GetType().GetProperties();
foreach (var userProperty in userProperties2)
{
    Console.WriteLine(userProperty.GetValue(user2));
}

Console.ReadKey();



