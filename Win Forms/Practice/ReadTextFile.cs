using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal static class ReadTextFile
    {
        private static string _filetxt = "Lorem ipsum dolor sit amet consectetur adipiscing elit nulla commodo facilisis.\r\nEst litora vitae imperdiet senectus sed purus lacus fermentum libero." +
            "\r\nOdio faucibus nibh massa per euismod etiam netus nunc. Mus ad aliquam non \r\nfermentum eu libero eros nullam varius curabitur, ligula et sem sapien eget fringilla " +
            "\r\nconvallis nostra suscipit, metus egestas curae penatibus potenti fames urna \r\nvulputate himenaeos. Venenatis dapibus congue quis aptent tincidunt vivamus " +
            "\r\nhendrerit litora purus, sollicitudin vestibulum malesuada fusce urna neque luctus integer." +
            "\r\n \r\nCurabitur netus dictum in mollis bibendum auctor ante, molestie suspendisse habitant " +
            "\r\nnostra tempor eu facilisi, nulla quam potenti integer aenean nisi. Litora vivamus hac \r\neuismod justo sociis malesuada aliquet leo pretium nullam ullamcorper vitae nostra mi " +
            "\r\ndis facilisis vehicula, taciti molestie semper aliquam aptent fermentum maecenas eros tempor " +
            "\r\nfelis commodo blandit neque dui dapibus donec. Id erat curabitur sem dapibus eros bibendum, \r\nfeugiat per phasellus enim class mauris auctor, tortor magnis nisi vivamus velit.";

        public static void CreateFile()
        {
            string directory = Directory.GetCurrentDirectory();
            string fileName = "Input.txt";

            string filepath = Path.Combine(directory, fileName);

            if (!File.Exists(filepath))
            {
                
               StreamWriter writer = new StreamWriter(filepath);
                writer.WriteLine(_filetxt);
                writer.Close();
            }
        }

        public static void ReadFile()
        {
            string directory = Directory.GetCurrentDirectory();
            string fileName = "Input.txt";
            string filepath = Path.Combine(directory, fileName);


            if (File.Exists(filepath))
            {
                
                string fileText = File.ReadAllText(filepath);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(fileText);
               Console.ForegroundColor= ConsoleColor.Green;
            }
        }
    }
}
