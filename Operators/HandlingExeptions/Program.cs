WriteLine("Before parsing");
Write("What is your age?");
string? input = ReadLine();
try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old");

}
catch
{
    WriteLine("After parsing");
}
