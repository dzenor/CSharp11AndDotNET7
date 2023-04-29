using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Rectangle : IPolygon, Icolor
    {
      

        public int calculateArea(int a, int b)
        {
            return a * b;
        }

        public void color()
        {
            Console.WriteLine("The color of triangle is blue");
        }
    }
}
