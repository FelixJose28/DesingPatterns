// See https://aka.ms/new-console-template for more information
using SingletonPattern;
using System;

//singleton: cuando se quiere una sola instancia de un objeto en la aplicacion. Ej: un servicio que tenga la seccion de autenticacion  	


var singleton = Singleton.GetInstance;
Console.WriteLine(singleton.message);
singleton.message = "modified";
Console.WriteLine(singleton.message);