using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Xml;

WriteLine("Hello!");

SectionTitle("Writing to text streams");

string textFile = Combine(CurrentDirectory, "streams.txt");

StreamWriter text = File.CreateText(textFile);

foreach (string item in Viper.Callsigns)
{
    text.WriteLine(item);
}

text.Close();
WriteLine("{0} contains {1:N0} bytes.",
    arg0: textFile,
    arg1: new FileInfo(textFile).Length);
WriteLine(File.ReadAllText(textFile));