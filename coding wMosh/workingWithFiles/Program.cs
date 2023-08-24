using System.IO;


Console.WriteLine("Hello, World!");

var path = @"c:\somefile.jpg";

File.Copy("C:\\FN2\\CSharp11AndDotNET7\\one.xml", "C:\\FN2\\JavaScript\\one.xml");

File.Delete(path);

if (File.Exists(path))
{
    //
}

var content = File.ReadAllText(path);

var fileInfo = new FileInfo(path);
fileInfo.CopyTo("....");
fileInfo.Delete();

if (fileInfo.Exists)
{
    //
}


Directory.CreateDirectory(@"c:\temp\folder1");
Directory.GetFiles(@"c:\proje");







