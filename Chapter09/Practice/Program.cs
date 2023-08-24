// See https://aka.ms/new-console-template for more information
using Practice;

Console.WriteLine("Hello, World!");

Console.WriteLine(Directory.GetCurrentDirectory());

//ReadTextFile.CreateFile();
//ReadTextFile.ReadFile();

ReadATextFileWithUsing readATextFileWithUsing = new ReadATextFileWithUsing(Path.Combine(Directory.GetCurrentDirectory(),"input.txt"));
readATextFileWithUsing.ReadFile();