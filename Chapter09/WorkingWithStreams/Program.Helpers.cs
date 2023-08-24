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
