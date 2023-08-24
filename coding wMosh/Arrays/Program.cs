
using System.Collections.Generic;
Console.WriteLine("Hello, World!");


int[] numbers = new int[] {3,7,9,2,14,6};

//lenght property

Console.WriteLine("Lenght: " + numbers.Length);

//indexOf()

int index= Array.IndexOf(numbers, 9);
Console.WriteLine("Index of 9 is: " + index);

//clear()
Array.Clear(numbers, 0, 2);

foreach (var n in numbers)
{
    Console.WriteLine(n);
}

Console.WriteLine("Copy method");
//copy()
int[] another = new int[3];

Array.Copy(numbers, another, 3);
foreach (var n in another)
{
    Console.WriteLine(n);
}
Console.WriteLine();

//sort()

Array.Sort(numbers);
foreach (var n in numbers)
{
    Console.WriteLine(n);
}

//reverse()

Array.Reverse(numbers);
foreach (var n in numbers)
{
    Console.WriteLine(n);
}


Console.WriteLine("LISTS-------------------");
var newNumbers = new List<int>() { 1,2,3,4};
newNumbers.Add(1);
newNumbers.AddRange(new int[3] { 5, 6, 7 });
foreach (var n in newNumbers)
{
    Console.WriteLine(n);
};

Console.WriteLine();
Console.WriteLine("Index of 1 is: "+
newNumbers.IndexOf(1));

Console.WriteLine("Last Index of 1 is: "+
newNumbers.LastIndexOf(1));




for (int i = 0; i < newNumbers.Count; i++)
{
    if (newNumbers[i] == 1)
    {
        newNumbers.Remove(newNumbers[i]);
    }
}





foreach (var n in newNumbers)
{
    Console.WriteLine(n);
};

newNumbers.Clear();

Console.WriteLine("Count: " + newNumbers.Count());