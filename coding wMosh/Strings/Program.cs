

using Strings;
using System.Globalization;
using System.Text;

string fullName = "Dzenis Redzovic ";

var names = fullName.Split(' ');
Console.WriteLine($"FirstName: {names[0]}");
Console.WriteLine($"LastName: {names[1]}");

if (string.IsNullOrWhiteSpace(" "))
{
    Console.WriteLine("Invalid");
}


var sentence = "This is going to be  really really really  really really really long text";
var summary =StringUtility.SummerizeText(sentence,25);
Console.WriteLine(summary);



//STRING BUILDER MANIPULATING STRINGS

var builder = new StringBuilder();
builder.Append('-', 10);
builder.AppendLine();
builder.Append("Header");
builder.AppendLine();
builder.Append('-', 10);

builder.Replace('-', '+');

builder.Remove(0, 10);

builder.Insert(0, new string('-', 10));

Console.WriteLine(builder);

//EXERCISE 1


//Console.WriteLine("Enter a numbers seperated by hypen:");
//string input = Console.ReadLine();

//string[] numbers = input.Split('-');

//bool isConsecutive = true;

//for(int i =1; i<numbers.Length; i++)
//{
//    int current = int.Parse(numbers[i]);
//    int previuos = int.Parse(numbers[i-1]);

//    if(current != previuos+1)
//    {
//        isConsecutive = false;
//        break;
//    }
//}

//if (isConsecutive)
//{
//    Console.WriteLine("Consecutive");
//}
//else
//{
//    Console.WriteLine("Not Consecutive");
//}

//EXERCISE 2

//Console.WriteLine("Enter a few numbers separated by hypen:");
//string input1 = Console.ReadLine();
//string[] numbers1 = input1.Split('-');

//if(string.IsNullOrEmpty(input1)){
//    return;
//}
//else
//{
//   for(int i = 1; i < numbers1.Length; i++)
//    {
//        int current1 = int.Parse(numbers1[i]);
//        int previous1 = int.Parse(numbers1[i-1]);

//        if(current1 == previous1)
//        {
//            Console.WriteLine("Duplicate");
//        }
//    }
//}


//EXERCISE 3

//Console.Write("Enter words separated by space: ");
//string input = Console.ReadLine();

//// Split the input into individual words
//string[] words = input.Split(' ');


//// Convert words to PascalCase
//TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

//string variableName = "";
//foreach (string word in words)
//{
//    string capitalizedWord = textInfo.ToTitleCase(word);
//    variableName += capitalizedWord;
//}

//Console.WriteLine(variableName);

//EXERCISE 5


Console.Write("Enter an English word: ");
string word = Console.ReadLine();

int vowelCount = CountVowels(word);

Console.WriteLine(vowelCount);
    

    static int CountVowels(string word)
{
    int count = 0;

    foreach (char c in word)
    {
        if (IsVowel(c))
        {
            count++;
        }
    }

    return count;
}

static bool IsVowel(char c)
{
    char lowerC = char.ToLower(c);

    return lowerC == 'a' || lowerC == 'e' || lowerC == 'o' || lowerC == 'u' || lowerC == 'i';
}
