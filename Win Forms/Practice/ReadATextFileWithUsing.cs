using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ReadATextFileWithUsing
    {
        private string _filePath;

        public ReadATextFileWithUsing(string filePath)
        {
            _filePath=filePath;
        }

        internal void ReadFile()
        {
            string line;

            using (StreamReader sr = new StreamReader(_filePath))
            {

                Console.ForegroundColor = ConsoleColor.Red;
                line = sr.ReadLine();

                while(line != null)
                {
                Console.WriteLine(line);
                line=sr.ReadLine();
            }
                Console.ForegroundColor= ConsoleColor.White;

            }
        }

    }
}
