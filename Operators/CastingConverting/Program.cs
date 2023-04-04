using static System.Convert;

int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine(b);

double c = 9.8;
int d = (int)c;
WriteLine(d); // d is 9 losing the .8 part

long e = 5_000_000_000;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

double g = 9.8;
int h = ToInt32(g); // a method of System.Convert
WriteLine($"g is {g} and h is {h}");

// Understanding the default rounding rules

double[] doubles = new[]
  { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}

foreach (double n in doubles)
{
    WriteLine(format:
        "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0:n,
        arg1: Math.Round(value: n, digits:0,
        mode: MidpointRounding.AwayFromZero)
        );
}

WriteLine("------------------");

int number = 12;
WriteLine(number.ToString());
bool boolean = true;
WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
WriteLine(now.ToString());
object me = new();
WriteLine(me.ToString());


WriteLine("------------------");


byte[] binaryObject = new byte[128];

Random.Shared.NextBytes(binaryObject);
WriteLine("Binary Object ad bytes");
for(int i = 0; i < binaryObject.Length; i++)
{
    Write($"{binaryObject[i]:X}");

}

WriteLine();

string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64:{encoded}");


WriteLine("------------------");


int age = int.Parse("21");
DateTime birthday = DateTime.Parse("3 March 2002");
WriteLine($"I was born {age} years ago");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}.");

Write("How many eggs are there?");
string? input = ReadLine();
WriteLine(int.TryParse(input, out int count2));
if(int.TryParse(input, out int count))
{
    WriteLine($"There are {count} egss");
}
else
{
    WriteLine("i could not parse the input.");
}

