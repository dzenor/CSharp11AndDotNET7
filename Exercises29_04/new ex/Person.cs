using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_ex
{
    public class Person : Iwork,Isleep,Irecreation
    {
        public object date(DateTime date)
        {
          return DateTime.Now;
            Console.WriteLine($"today date is {date}");
        }

        public string sleeping()
        {
            return "Im sleeping";
            
        }

        public int working(int x)
        {
            return x;
        }
    }
}
