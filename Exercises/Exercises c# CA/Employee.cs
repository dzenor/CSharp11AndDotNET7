using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_c__CA
{
    public class Employee
    {
        private static int nextAvailableID;
        private String firstName;
        private String lastName;
        private readonly int ID;


        public int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 10000);
        }
      
    }
}
