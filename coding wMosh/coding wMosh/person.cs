using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_wMosh
{
    public class Person
    {

        //        public string FirstName;
        //        public string LastName;

        //        public void Introduce()
        //        {
        //            Console.WriteLine("My name is {0} {1} ", FirstName, LastName);
        //        }

        public int Age;
    public static void Increment(int number)
    {
        number +=10;
    }

    public static void MakeOld(Person person)
    {
        person.Age+=10;
    }

        
    }


    public enum ShippingMethod
    {
        RegularAirMail=1,
        RegisteredAirMail=2,
            Express=3
    }
}
