// See https://aka.ms/new-console-template for more information
using DependencyContainer;

Console.WriteLine("Hello, World!");

var services = new DummyServiceCollection();

services.AddSingleton<DummyClass>();
services.AddSingleton<IDummyPrint, DummyPrintTata>();
services.AddTransient<DummyClassWithCtorInjection>();
var container = services.GetContainer();

//var svc1 = container.GetService<DummyClass>();
//var svc2 = container.GetService<DummyClass>();
//Console.WriteLine(svc1.RandomGuid);
//Console.WriteLine(svc2.RandomGuid);

//var svc3 = container.GetService<IDummyPrint>();
//svc3.Print();

var final = container.GetService<DummyClassWithCtorInjection>();
final.PrintIt();


