using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Library.Models
{
    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I`m studying!");
        }

        public string Introduce()
        {
            return $"Hi my name is {this.name}.I`am a student,and i`m {this.GetAge()} old";

        }

        
    }
}
