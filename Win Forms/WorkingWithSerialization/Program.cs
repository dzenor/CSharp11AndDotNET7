using System.Xml.Serialization;
using Packt.Shared;

using static System.Environment;
using static System.IO.Path;
using static System.Console;
using Newtonsoft.Json;

List<Person> people = new List<Person>()
{
    new Person(30000M)
    {
        FirstName = "Alice",
        LastName="Smith",
        DateOfBirth = new DateTime(2002,3,3)
    },

     new Person(40000M)
    {
        FirstName = "Bob",
        LastName="Jones",
        DateOfBirth = new DateTime(1969,1,13)
    },

      new Person(20000M)
    {
        FirstName = "Charlie",
        LastName="Cox",
        DateOfBirth = new DateTime(1984,5,4),
        Children = new HashSet<Person>()
        {
             new Person(0M)
             {
                FirstName = "Sally",
                LastName="Cox",
                DateOfBirth = new DateTime(2012,2,13)
             }
        }
    }
};

XmlSerializer xs = new XmlSerializer(typeof(List<Person>));

string path = Path.Combine(Environment.CurrentDirectory, "people.xml");

using (FileStream stream = File.Create(path))
{
    xs.Serialize(stream, people);
}
WriteLine("Written {0:N0} in {1}",new FileInfo(path).Length, path);
WriteLine("---------------------------------------------------");

string[] lines = File.ReadAllLines(path);

foreach (string line in lines)
{
    WriteLine(line);
}


WriteLine("---------------------------------");
WriteLine("Deserialiizing XML");

using(FileStream xmlLoad = File.Open(path, FileMode.Open))
{
    List<Person>? loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;
     if (loadedPeople != null)
    {
        foreach (Person person in loadedPeople)
        {
            WriteLine($"{person.LastName} has {person.Children.Count} children");
        }
    }
}


WriteLine("---------------------------------");
WriteLine("Serialiizing JSON");

string pathJson = Combine(CurrentDirectory, "people.json");
using (StreamWriter streamJson = File.CreateText(pathJson))
{
    JsonSerializer jss = new JsonSerializer();

    string json = JsonConvert.SerializeObject(people, Formatting.Indented);
    streamJson.Write(json);

    //jss.Serialize(streamJson, people);
};
WriteLine("Written {0:N0} in {1}", new FileInfo(pathJson).Length, pathJson);
WriteLine("---------------------------------------------------");
WriteLine(File.ReadAllText(pathJson));


WriteLine("---------------------------------");
WriteLine("Deserialiizing JSON files");

string jsonText = File.ReadAllText(pathJson);
List<Person>? jsonPeople = JsonConvert.DeserializeObject<List<Person>>(jsonText);

if (jsonPeople != null)
{
    foreach (Person person in jsonPeople)
    {
        int childrenCount = person.Children != null ? person.Children.Count : 0;
        WriteLine($"{person.FirstName} has {childrenCount} children");
    }
}