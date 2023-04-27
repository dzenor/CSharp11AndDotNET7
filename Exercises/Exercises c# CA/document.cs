using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_c__CA
{
    public class Document
    {
        public string name;
        public int numOfPages;
        public DateTime myDateTime;

        public void writeLine()
        {
            Console.WriteLine("1) Create Document Class...");
        }

        public void Creating()
        {
          
            Console.WriteLine("Name:{0},Number of Pages:{1},Created on:{2}",name,numOfPages,myDateTime);
        }
    }
}
