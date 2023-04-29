// See https://aka.ms/new-console-template for more information
using new_ex;

Console.WriteLine("Hello, World!");

Person Dzeno = new Person();

int hrsWorking=Dzeno.working(8);
string sleeping= Dzeno.sleeping();

object datanow=Dzeno.date(DateTime.Now);


Console.WriteLine($"Im working {hrsWorking}hours then im {sleeping}.Today date is {datanow}");