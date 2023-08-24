using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Xml;


//WriteLine("Input the number of lines to write in the file:");
//int numLines = int.Parse(Console.ReadLine());

//string[] lines = new string[numLines];

//for (int i = 0; i < numLines; i++)
//{
//    Console.WriteLine($"Input line {i + 1}");
//    lines[i]= ReadLine();
//}

//string fileName = "fileWithStrings.txt";
//string directory = "C:\\Users\\Lenovo\\Documents\\OutputFiles";

//string filePath = Path.Combine(directory, fileName);

//File.WriteAllLines(filePath, lines);

//string[] fileContent =  File.ReadAllLines(filePath);

//Console.WriteLine("The content of the file is:");
//foreach (string line in fileContent)
//{
//    Console.WriteLine(line);
//}

//Console.ReadLine();


//ex7

WriteLine("Input the string to ignore the line: ");
string ignoreString = ReadLine();

WriteLine("Input the number of lines you want to be writen in the file");
int numLines= int.Parse(ReadLine());

string[] lines =  new string[numLines];

for(int i = 0; i < numLines; i++)
{
    Console.WriteLine($"Input line {i + 1}");
    lines[i] = ReadLine();
}

string fileName = "ex7.txt";
string directory = "C:\\Users\\Lenovo\\Documents\\OutputFiles";

string filePath = Path.Combine(directory, fileName);

File.Create(filePath).Close();

StreamWriter textWriter = new StreamWriter(filePath);

foreach (string line in lines)
{
    if(!line.Contains(ignoreString))
    {
        textWriter.WriteLine(line); 
    
    }else{
        WriteLine("The line ignored contains the string '" + ignoreString + "'.");
    }
    
}

string[] fileContent = File.ReadAllLines(filePath);

WriteLine("The content of the file is:");

foreach (string line in fileContent)
{
    WriteLine(line);
}

ReadLine();