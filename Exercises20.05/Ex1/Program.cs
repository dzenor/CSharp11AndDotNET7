using Ex1;
using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Serialization;


List<Employee> One = new List<Employee>()
{
    new Employee()
    {
        Id = 1, Name = "Dzeno", Address ="Jane Sandanski",Subordinared=new List<Employee>
        {
            new Employee() { Id = 2,Name="john",Address="Borche Janev"  }
        }
    },
     new Employee()
    {
        Id = 2, Name = "Tom", Address ="Tome Sandanski",Subordinared=new List<Employee>
        {
            new Employee() { Id = 3,Name="Ulem",Address="Hendy Mary"  }
        }
    }
};


//serialization without newton with json
//string fileName = @"C:\FN2\CSharp11AndDotNET7\Exercises20.05\Proba.json";
//string jsonString = JsonSerializer.Serialize(One);
//File.WriteAllText(fileName, jsonString);
//Console.WriteLine(File.ReadAllText(fileName));





//serialization with  xml


//XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
//using (TextWriter writer = new StreamWriter(@"C:\FN2\CSharp11AndDotNET7\Exercises20.05\One.xml"))
//{
//    serializer.Serialize(writer, One);
//}



//deserialization with xml
//using(FileStream fileStream = new FileStream(@"C:\FN2\CSharp11AndDotNET7\Exercises20.05\One.xml", FileMode.Open))
//{
//    List<Employee>? emp = serializer.Deserialize(fileStream) as List<Employee>;

//    if(emp != null)
//    {
//        foreach (Employee employee in emp)
//        {
//            var under = employee.Subordinared;
//            foreach (Employee employee1 in under )
//            {
//                Console.WriteLine($"{employee.Name} has under {employee1.Name} employee ");
//            }
//        }
//    }
//}

//serialization with newton  json
Account account = new Account
{
    Email = "james@example.com",
    Active = true,
    CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
    Roles = new List<string>
    {
        "User",
        "Admin"
    }
};

string json = JsonConvert.SerializeObject(account,Formatting.Indented);
Console.WriteLine(json);


