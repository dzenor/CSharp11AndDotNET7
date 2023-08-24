using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Xml;



//string currentDirectory = Environment.CurrentDirectory;

//string dir = Combine(GetFolderPath(SpecialFolder.Personal), "OutpuFiles");
//CreateDirectory(dir);

string directory = "C:\\Users\\Lenovo\\Documents";

string fileName = "mytest.txt";
string backupFile = "mytest.bak";

string filePath = Path.Combine(directory, fileName);
//File.Create(filePath).Close();

WriteLine($"Working with:{fileName}");
WriteLine($"Does it exists? {File.Exists(fileName)}");

StreamWriter textWriter = File.CreateText(fileName);
textWriter.WriteLine("dzeno web developer");
textWriter.Close();
StreamReader textReader = File.OpenText(fileName);
WriteLine(textReader.ReadToEnd());

//File.Create(filePath).Close();

//StreamWriter textWriter = File.CreateText(fileName);
//textWriter.WriteLine("Hello, c#");
//textWriter.Close();
//WriteLine($"Does it exists? {File.Exists(fileName)}");



//File.Copy(sourceFileName: fileName,
//    destFileName: backupFile, overwrite: true);

//WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");

//Write("Confirm the files exist, and then press ENTER: ");
//ReadLine();

//File.Delete(fileName);

//WriteLine($"Does it exist? {File.Exists(fileName)}");


//WriteLine($"Reading contents of {backupFile}:");
//StreamReader textReader = File.OpenText(backupFile);

//WriteLine(textReader.ReadToEnd());
//textReader.Close();






WriteLine($"A file created with name {fileName}");


//WriteLine("Remove a file from the disk (at first create the file\r\n)):");
//WriteLine("-------------------------------------------------------------");


//if (File.Exists(filePath))
//{
//    File.Delete(filePath);
//    WriteLine("The file mytest.txt was deleted successfully.");
//}

ReadLine();

