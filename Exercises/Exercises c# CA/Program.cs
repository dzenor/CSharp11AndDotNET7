// See https://aka.ms/new-console-template for more information
using Exercises_c__CA;


Console.WriteLine("Hello, World!");

Cat.HowManyCats();

Cat marko = new Cat();

Cat.HowManyCats();

Cat pimpa = new Cat();
Cat.HowManyCats();

Stuff staff1 = new Stuff("Ljupcho", "Shemov");
staff1.HoursWorked = 160;
int pay = staff1.CalculatePay();
Console.WriteLine(pay);

Person njuPerson = new Person();
njuPerson.displayAgeName("Dzenis", "Redzovic",21);

Document myDoc = new Document();

myDoc.name = "Phone Num";
myDoc.numOfPages = 1;
myDoc.myDateTime = DateTime.Now;
myDoc.writeLine();
myDoc.Creating();

Document dzenoDoc = new Document();
dzenoDoc.name = "Text.txt";
dzenoDoc.numOfPages = 1323;
dzenoDoc.myDateTime = DateTime.Now;
dzenoDoc.Creating();

