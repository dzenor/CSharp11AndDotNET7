// See https://aka.ms/new-console-template for more information
using Debugging;


var numbers = new List<int>() { 1,2};
var smallests = Class1.GetSmallests(numbers,3);

foreach (var number in smallests)
{
    Console.WriteLine(number);
}

