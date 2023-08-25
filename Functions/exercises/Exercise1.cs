using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public static class Exercise1
    {
        public static int areaOfTriangle(int height, int basse)
        {
            int result = (height*basse)/2;
            return result;
        }

        public static int MinutesToSec(int min)
        {
            int result = min * 60;
            return result;
        }

        public static bool lesOrEqual(int num)
        {
            if (num <= 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public static string something(string a)
        {

            string res = "something " + a;
            return res;
        }



        public static bool FlipBool(bool t)
        {
            if (t == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public static bool equalNums(int a, int b)
        {
            if(a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static int basketballPoints(int trojki,int dvojki)
        {

            int result = trojki*3 + dvojki*2;

            return result; 



        }

        //public static Array arr(Array arr)
        //{

        //    //return arr[0];
        //}

        public static bool divisible(int num)
        {
            if (num%5==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsChristmasEve(int year, int month, int day)
        {
            DateTime date = new DateTime(year, month, day);

            return date.Month == 12 && date.Day == 24;
        }


        public static bool stringCount(string a,string b)
        {
            if(a.Length== b.Length)
            {
                return true;
            }
            else { return false; }
        }

        public static bool insensitiveCase(string a, string b)
        {
            if (a.ToLower() == b.ToLower())
            {
                return true;
            }
            else return false;
        }

        public static string changePlaces(string nameAndLastname) {

            string name = nameAndLastname.Split();
            return ;
        }

    }
}
