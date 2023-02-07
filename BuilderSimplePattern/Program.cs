using BuilderSimplePattern;
using System;

//builder: contructor muy grande o con mucho parametros. DIrector que le digo que metodo usar de acuerdo a ciertas configurciones por ejemplo (otra opcion es crear clase declarar peropiedades y pasar la clase como el proyecto de OIT cambiar funcionalidad a builder que es la correcta)


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



