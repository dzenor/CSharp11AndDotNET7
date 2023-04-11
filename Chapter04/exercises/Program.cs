// See https://aka.ms/new-console-template for more information
using exercises;
using System.Runtime.Intrinsics.X86;
using System.Xml;

Console.WriteLine("Hello, World!");

Console.WriteLine("The area of the triangle is: {0}",Exercise1.areaOfTriangle(5,6));
int minutes = 5;
int convert = Exercise1.MinutesToSec(minutes);

Console.WriteLine($"{minutes}min to seconds is {convert}");

Console.WriteLine(Exercise1.lesOrEqual(4));

Console.WriteLine(Exercise1.something("dzeno"));

Console.WriteLine(Exercise1.FlipBool(true));

Console.WriteLine(Exercise1.equalNums(3,4));

Console.WriteLine(Exercise1.basketballPoints(1,1));
//Console.WriteLine(Exercise1.arr("dzeno","tom","john"));

Console.WriteLine(Exercise1.divisible(15));
Console.WriteLine("------------");
Console.WriteLine(Exercise1.IsChristmasEve(2023,11,24));

Console.WriteLine(Exercise1.stringCount("av","bs"));
Console.WriteLine("------------");
Console.WriteLine(Exercise1.insensitiveCase("helLo","HELLO"));

Console.WriteLine(Exercise1.changePlaces("dzenis ","redzovic"));
