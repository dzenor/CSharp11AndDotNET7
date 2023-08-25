using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
using System.Xml;

SectionTitle("Handling cross-platform enviorments and file systems");
WriteLine("{0,-33} {1}", arg0: "Path.Separator", arg1: PathSeparator);
WriteLine("{0,-33} {1}", arg0: "Path.DirectorySeparatorChar", arg1: DirectorySeparatorChar);
WriteLine("{0,-33} {1}", arg0: "Path.Directory.GetCurrentDirectory()", arg1: GetCurrentDirectory());
WriteLine("{0,-33} {1}", arg0: "Enviorment.CurrentDirectory", arg1: CurrentDirectory);
WriteLine("{0,-33} {1}", arg0: "Enviorment.SystemDirectory", arg1: CurrentDirectory);
WriteLine("{0,-33} {1}", arg0: "Path.GetTempPath()", arg1: GetTempPath());
WriteLine("GetFolderPath(SpecialFolder");
WriteLine("{0,-33} {1}", arg0: " .System", arg1: SpecialFolder.System);
WriteLine("{0,-33} {1}", arg0: " .ApplicationData", arg1: SpecialFolder.ApplicationData);
WriteLine("{0,-33} {1}", arg0: " .MyDocuments", arg1: SpecialFolder.MyDocuments);
WriteLine("{0,-33} {1}", arg0: " .Personal", arg1: SpecialFolder.Personal);

SectionTitle("Managing drives");
WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
"NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");
foreach (DriveInfo drive in DriveInfo.GetDrives())
{
    if (drive.IsReady)
    {
        WriteLine(
        "{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
        drive.Name, drive.DriveType, drive.DriveFormat,
        drive.TotalSize, drive.AvailableFreeSpace);
    }
    else
    {
        WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);
    }
}

SectionTitle("Managing directories");

string newFolder = Combine(GetFolderPath(SpecialFolder.Personal),"NewFolder");

WriteLine($"Working with:{newFolder}");

WriteLine($"Does it exists? {Path.Exists(newFolder)}");

WriteLine("Creating it.....");
CreateDirectory(newFolder);

WriteLine($"Does it exists? {Path.Exists(newFolder)}");
Write("Confirm the directory exists,and then press ENTER: ");
ReadLine();

WriteLine("Deleting it....");
Delete(newFolder, recursive: true);
WriteLine($"Does it exists? {Path.Exists(newFolder)}");


SectionTitle("Managing files");
// define a directory path to output files
// starting in the user's folder
string dir = Combine(
GetFolderPath(SpecialFolder.Personal), "OutputFiles");
CreateDirectory(dir);


string textFile = Combine(dir, "Dummy.txt");
string backupFile = Combine(dir, "Dummy.bak");
WriteLine($"Working with:{textFile}");

WriteLine($"Does it exists? { File.Exists(textFile)}");

StreamWriter textWriter = File.CreateText(textFile);
textWriter.WriteLine("Hello, c#");
textWriter.Close();
WriteLine($"Does it exists? {File.Exists(textFile)}");


File.Copy(sourceFileName: textFile,
    destFileName: backupFile, overwrite: true);

WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");

Write("Confirm the files exist, and then press ENTER: ");
ReadLine();

File.Delete(textFile);

WriteLine($"Does it exist? {File.Exists(textFile)}");


WriteLine($"Reading contents of {backupFile}:");
StreamReader textReader = File.OpenText(backupFile);

WriteLine(textReader.ReadToEnd());
textReader.Close();


SectionTitle("Managing paths");


WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
WriteLine($"File Name: {GetFileName(textFile)}");
WriteLine("File Name without Extension: {0}",GetFileNameWithoutExtension(textFile));
WriteLine($"File Extension: {GetExtension(textFile)}");
WriteLine($"Random File Name: {GetRandomFileName()}");
WriteLine($"Temporary File Name: {GetTempFileName()}");

 
string root =   GetParent(GetParent(GetCurrentDirectory()).Parent.FullName).FullName;
string myFileCs = Combine(root, "MyFile.cs");
WriteLine($"Does MyFile exists? {File.Exists(myFileCs)}");
StreamWriter myFileCsWriter = File.CreateText(myFileCs);
myFileCsWriter.WriteLine($"namespace WorkingWithFileSystems {System.Environment.NewLine} {{ {System.Environment.NewLine} internal class MyFile " +
    $"{System.Environment.NewLine} {{ {System.Environment.NewLine}}} {System.Environment.NewLine} }}");
myFileCsWriter.Close();


SectionTitle("Getting file information");

FileInfo info = new(myFileCs);
WriteLine($"{myFileCs}:");
WriteLine($"Contains {info.Length} bytes");
WriteLine($"Last accessed {info.LastAccessTime}");
WriteLine($"Has readonly set to {info.IsReadOnly}");

string myFileInfoTest = @"C:\Users\Lenovo\Documents\Visual Studio 2022\Visualizers\attribcache140.bin";

FileInfo myFileInfo = new FileInfo(myFileInfoTest);
WriteLine($"{myFileInfoTest}:");
WriteLine($"Contains {myFileInfo.Length} bytes");
WriteLine($"Last accessed {myFileInfo.LastAccessTime}");
WriteLine($"Has readonly set to {myFileInfo.IsReadOnly}");




//SectionTitle("Writing to XML streams");


//// define a file path to write to
//string xmlFile = Combine(CurrentDirectory, "streams.xml");

//// declare variables for the filestream and XML writer
//FileStream? xmlFileStream = null;
//XmlWriter? xml = null;

//try
//{
//	//create file stream
//	xmlFileStream = File.Create(xmlFile);
//    // wrap the file stream in an XML writer helper
//    // and automatically indent nested elements
//    xml = XmlWriter.Create(xmlFileStream,new XmlWriterSettings { Indent = true });
//    // write the XML declaration
//    xml.WriteStartDocument();
//    // write a root element
//    xml.WriteStartElement("callsigns");

//    foreach (string item in Viper.Callsigns)
//    {
//        xml.WriteElementString("callsings", item);
//    }

//    // write the close root element
//    xml.WriteEndElement();
//    // close helper and stream
//    xml.Close();
//    xmlFileStream.Close();

//}
//catch (Exception ex)
//{
//    // if the path doesn't exist the exception will be caught
//    WriteLine($"{ex.GetType()} says {ex.Message}");
//    throw;
//}
//finally
//{
//    if (xml != null)
//    {
//        xml.Dispose();
//        WriteLine("The XML writer's unmanaged resources have been disposed.");
//    }
//    if (xmlFileStream != null)
//    {
//        xmlFileStream.Dispose();
//        WriteLine("The file stream's unmanaged resources have been disposed.");
//    }
//}
