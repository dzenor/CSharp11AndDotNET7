using Exercise_08._04;

//Console.WriteLine("Enter the start of range: ");
//int start = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the end of a range: ");
//int end = int.Parse(Console.ReadLine());

//Console.WriteLine("Do you want to print od or even numbers? E/O: ");
//char choice = Console.ReadLine().ToLower()[0];

//Console.WriteLine("Numbers: ");
//if (choice == 'e')
//{
//    Ex08.PrintEven(start, end);
//}
//else
//{
//    Ex08.PrintOdd(start, end);
//}

//ex2
//2.Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string
Console.WriteLine(Ex08.NumSpaces("dzeno"));
//3.	Write a program in C# Sharp to calculate the sum of elements in an array
int[] myarr = { 1, 2, 3, 4, 5 };
Ex08.arr(myarr);
//5.	Write a program in C# Sharp to create a function to calculate the result of raising an integer number to another.
//Console.WriteLine("Enter the base number: ");
//int baseNum = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the exponent number: ");
//int expNum = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Ex08.raising(baseNum,expNum));

//6.	Write a program in C# Sharp to create a function to display the n number Fibonacci sequence
int n = 10;
Console.WriteLine("Fibonacci sequence up to " + n + " terms:");
for (int i = 0; i < n; i++)
{
    Console.Write(Ex08.FibonacciNumber(i) + " ");
}


//Ex08.FibonacciSequence(10);
//Console.WriteLine(Ex08.FibonacciSequence(10));

//8.Write a program in C# Sharp to create a recursive function to find the factorial of a given number
int answer = 0;
answer = Ex08.factorial(5);
Console.WriteLine("The answer is " + answer);

int[] arr = { 1, 2, 3 };
Ex08.GeneratePermutations(arr, 0);

Console.WriteLine(Ex08.Reverse("dzeno"));

Console.WriteLine("-------------");
//Console.WriteLine(Ex08.FibonacciNumber(10));

