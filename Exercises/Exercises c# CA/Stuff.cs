using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_c__CA
{
    public class Stuff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay....");
        }

        public int CalculatePay()
        {
            PrintMessage();
            int staffPay;
            staffPay = hWorked * hourlyRate;
            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }

        public Stuff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("--------------------------");
        }
    }
}
