using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_Library.Models
{
    public class Person
    {
        public string name = "";
        private int age;

        public Person(string name, int age)
        {
            this.name=name??throw new ArgumentNullException(nameof(name));
            this.age=age;
        }

        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int age)
        {
            this.age= age;
        }

        protected int GetAge()
        {
            return this.age;
        }
    }
}
