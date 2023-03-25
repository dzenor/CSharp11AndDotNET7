using System;
//int num1 = 2;
//int num2 = 3;
//int result = num1 + num2;
//Console.WriteLine(result);

//int a = 2;
//int b = 3;
//int c = a;
//a=b;
//b=c;
//Console.Write("After swap a= "+a+" b= "+b);


//public class Exercise6
//{
//    public static void Main()
//    {
//        int num1, num2, num3;

//        Console.Write("Input the first number to multiply: ");
//        num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Input the second number to multiply: ");
//        num2 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Input the third number to multiply: ");
//        num3 = Convert.ToInt32(Console.ReadLine());

//        int result = num1 * num2 * num3;
//        Console.WriteLine("Output: {0} x {1} x {2} = {3}",
//                            num1, num2, num3, result);
//    }
//}

//public class Exercise7
//{
//    public static void Main()
//    {
//        Console.Write("Enter a number: ");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter another number: ");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1+num2);
//        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1-num2);
//        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1*num2);
//        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1/num2);
//        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1%num2);
//    }
//}



//Console.Write("Enter your age: ");
//int numAge = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("You look older than {0}", numAge);

//public class Exercise7
//{
//    public static void Main()
//    {
//        float distance;
//        float hour, min, sec;

//        float timeSec;
//        float mps;
//        float kph, mph;

//        Console.Write("Input distance(metres): ");
//        distance = Convert.ToSingle(Console.ReadLine());
//        Console.Write("Input timeSec(hour): ");
//        hour = Convert.ToSingle(Console.ReadLine());
//        Console.Write("Input timeSec(minutes): ");
//        min = Convert.ToSingle(Console.ReadLine());
//        Console.Write("Input timeSec(seconds): ");
//        sec = Convert.ToSingle(Console.ReadLine());

//        timeSec = (hour*3600) + (min*60) + sec;
//        mps = distance/timeSec;
//        kph = (distance/1000.0f)/(timeSec/3600.0f);
//        mph = kph / 1.609f;

//        Console.WriteLine("Your speed in metres/sec is {0}", mps);
//        Console.WriteLine("Your speed in km/h is {0}", kph);
//        Console.WriteLine("Your speed in miles/h is {0}", mph);
//    }
//}

//public class Exercise1
//{
//    public static void Main()
//    {
//        char letter, letter1, letter2;

//        Console.Write("Input letter: ");
//        letter = Convert.ToChar(Console.ReadLine());

//        Console.Write("Input letter: ");
//        letter1 = Convert.ToChar(Console.ReadLine());

//        Console.Write("Input letter: ");
//        letter2 = Convert.ToChar(Console.ReadLine());

//        Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
//    }
//}
//public class Exercise5
//{
//    public static void Main()
//    {

//        double r, per_cir;
//        double PI = 3.14;
//        Console.WriteLine("Input the radius of the circle : ");
//        r = Convert.ToDouble(Console.ReadLine());
//        per_cir = 2 * PI * r;
//        Console.WriteLine("Perimeter of Circle : {0}", per_cir);
//        Console.Read();
//    }
//}

//public class Exercise2
//{
//    public static void Main()
//    {
//        string str; /* Declares a string of size 100 */
//        int l = 0;

//        Console.Write("\n\nFind the length of a string :\n");
//        Console.Write("---------------------------------\n");
//        Console.Write("Input the string : ");
//        str = Console.ReadLine();

//        foreach (char chr in str)
//        {
//            l += 1;

//        }

//        Console.Write("Length of the string is : {0}\n\n", l);
//    }
//}


//public class Exercise5
//{
//    public static void Main()
//    {
//        string str;
//        int i, wrd, l;

//        Console.Write("\n\nCount the total number of words in a string :\n");
//        Console.Write("------------------------------------------------------\n");
//        Console.Write("Input the string : ");
//        str = Console.ReadLine();

//        l = 0;
//        wrd = 1;

//        /* loop till end of string */
//        while (l <= str.Length - 1)
//        {
//            /* check whether the current character is white space or new line or tab character*/
//            if (str[l]==' ' || str[l]=='\n' || str[l]=='\t')
//            {
//                wrd++;
//            }

//            l++;
//        }

//        Console.Write("Total number of words in the string is : {0}\n", wrd);
//    }
//}



