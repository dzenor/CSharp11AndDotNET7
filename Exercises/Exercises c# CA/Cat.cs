using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_c__CA
{
    public class Cat
    {
        private static int instances = 0;

        public Cat() {
        instances++;
        }

        public static void HowManyCats() {
            Console.WriteLine("{0} cats adopted",instances);
        }
    }
}
