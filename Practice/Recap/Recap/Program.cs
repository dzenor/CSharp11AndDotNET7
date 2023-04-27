// See https://aka.ms/new-console-template for more information
using Recap_Library.Models;

Console.WriteLine("Hello, World!");

Person myPerson = new Person("Dzenis",43);

myPerson.Greet();
Student student = new Student();

student.SetAge(21);

string intro =  student.Introduce();
Console.WriteLine(intro);