using Packt.Shared;

namespace PeopleApp
{
    partial class Program 
    {
        static void Harry_Shout(object? sender, EventArgs e)
        {
            if (sender is null) return;
            Person? p = sender as Person;
            if (p is null) return;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}
