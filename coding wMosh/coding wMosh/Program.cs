// See https://aka.ms/new-console-template for more information
using coding_wMosh;
using coding_wMosh.Math;
using System;

Console.WriteLine("Hello, World!");


//try
//{
//    string str = "true";
//    bool b = Convert.ToBoolean(str);
//    Console.WriteLine(b);

//}
//catch (Exception)
//{
//    Console.WriteLine("The number could not be converted to a byte!");
//}

//var a = 1;
//var b = 2;
//var c = 3;

//Console.WriteLine(a+b*c);

//var dzeno = new Person();
//dzeno.FirstName = "Dzenis";
//dzeno.LastName = "Redzovic";
//dzeno.Introduce();

Calculator calculator = new Calculator();
var result = calculator.Add(1, 2);
Console.WriteLine(result);

var numbers = new int[3];
numbers[0] = 1;



Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[1]);
Console.WriteLine(numbers[2]);

var flags = new bool[3];
flags[0] = true;
Console.WriteLine(flags[0]);
Console.WriteLine(flags[1]);
Console.WriteLine(flags[2]);


var names = new string[3] { "jack", "john", "mary" };
Console.WriteLine(names[0]);
Console.WriteLine(names[1]);
Console.WriteLine(names[2]);

var firsName = "Mosh";
var lastName = "Hamedani";

var namesNew = new string[3] { "John", "Jack", "Mary" };
var formattedNames = string.Join(", ", namesNew);
Console.WriteLine(formattedNames);


var method=ShippingMethod.Express;

Console.WriteLine((int)method);

var methodID = 3;
Console.WriteLine((ShippingMethod)methodID);

Console.WriteLine("---------------------------------------------");
Console.WriteLine(method.ToString());

var methodName = "Express";
var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);


var a = 10;
var b = a;
b++;

Console.WriteLine($"{a} {b}",a,b);


var array1= new int[3] {1,2,3};

var array2 = array1;

array2[0]=0;
Console.WriteLine($"{array1[0]}  {array2[0]}");

var num = 1;


bool isGoldCostumer = false;
float price = (isGoldCostumer) ? 19.95F : 29.34F;
Console.WriteLine(price);


var season = Season.Autumn;

switch(season)
{
    case Season.Autumn:
        Console.WriteLine("It autumn and beautiful season");
        break;


    case Season.Summer:
        Console.WriteLine("Its time for beach");
        break;

    default:
        Console.WriteLine("i dont know the season");
        break;
}