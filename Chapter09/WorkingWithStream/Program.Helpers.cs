
  partial class Program
{
   static void SectionTitle(string title)
    {
        ConsoleColor previousColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Red;
        WriteLine("*");
        WriteLine($"*{title}");
        WriteLine("*");
        ForegroundColor = previousColor;
    }
}

//internal static class Viper
//{
//    // define an array of Viper pilot call signs
//    public static string[] Callsigns = new[]
//    {
//        "Husker", "Starbuck", "Apollo", "Boomer",
//        "Bulldog", "Athena", "Helo", "Racetrack"
//    };
//}





