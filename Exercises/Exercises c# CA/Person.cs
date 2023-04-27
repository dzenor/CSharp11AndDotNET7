using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_c__CA
{
    public class Person
    {
        public string name;
        public int  age;

       


        public void displayAgeName(string firstName, string lastName,int ages)
        {
            name = firstName + " " + lastName;
            age = ages;
            Console.WriteLine("The full name of the person is {0} The age of person is {1}",name,age);

        }
    }
}
