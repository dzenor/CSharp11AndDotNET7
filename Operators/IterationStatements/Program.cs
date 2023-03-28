int x = 0;
while(x<10)
{
    WriteLine(x);
    x++;
}

string? password;
do
{
    Write("Enter your password: ");
    password = ReadLine();
}
while (password != "Pa$$word");
WriteLine("Correct!");