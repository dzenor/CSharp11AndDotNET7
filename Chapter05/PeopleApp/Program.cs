using Packt.Shared;
using System.Text;

Person bob = new Person();
WriteLine(bob.ToString());

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
Console.OutputEncoding = Encoding.UTF8;

WriteLine(format: "{0} was born on {1:dddd,d MMMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth);

Person dzenis = new()
{
    Name = "Dzenis Redzovic",
    DateOfBirth = new(2002, 3, 3)
};

WriteLine(format: "{0} was born on {1:dd,d MMM yy}",
    arg0: dzenis.Name,
    arg1: dzenis.DateOfBirth);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(
format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
arg0: bob.Name,
arg1: bob.FavoriteAncientWonder,
arg2: (int)bob.FavoriteAncientWonder);

bob.Children.Add(new Person { Name = "Alfred" });//c# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" }); //c# 9.0 and later

WriteLine($"{bob.Name} HashCode {bob.Children.Count} children:");

for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($">{bob.Children[childIndex].Name}");
}


BankAccount.InterestRate = 0.012M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs.Jones";
jonesAccount.Balance = 2400;
WriteLine(format:"{0} earned {1:C} interest.",
    arg0:jonesAccount.AccountName,
    arg1: jonesAccount.Balance+BankAccount.InterestRate);

BankAccount.InterestRate = 0.012M;
BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms.Gerrier";
gerrierAccount.Balance = 98;
WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance*BankAccount.InterestRate);