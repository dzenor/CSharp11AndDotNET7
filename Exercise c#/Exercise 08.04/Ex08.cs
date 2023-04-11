using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_08._04
{
    public static class Ex08
    {
        public static int NumSpaces(string s)
        {
            return s.Length;
        }

        public static void arr(int[] array)
        {
            int result = 0;
            foreach (int i in array)
            {
                result += i;
            }
            Console.WriteLine(result);

        }

        public static int raising(int b, int e)
        {
            int result = 1;
            for (int i = 1; i <= e; i++)
            {
                result *= b;

            }
            return result;
        }

        public static int FibonacciNumber(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
            }
        }

        public static void FibonacciSequence(int n)
        {
            int a = 0, b = 1, c;
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " s");
                a = b;
                b = c;
            }
        }

        public static int factorial(int factorialNum)
        {
            if (factorialNum == 1)

                return 1;

            return factorialNum * factorial(factorialNum - 1);

        }

        public static void GeneratePermutations(int[] arr, int start)
        {
            // If start has reached the end of the array, we have generated a permutation
            if (start == arr.Length - 1)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            // Generate permutations by swapping each element with the first element
            for (int i = start; i < arr.Length; i++)
            {
                Swap(arr, start, i);
                GeneratePermutations(arr, start + 1);
                Swap(arr, start, i); // backtrack
            }
        }





        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }


        public static string Reverse(string str)
        {
            if (str.Length == 1)
            {
                return str;
            }
            else
            {
                return str[str.Length - 1] + Reverse(str.Substring(0, str.Length - 1));
            }










            //public static void PrintEven(int start, int end)
            //{
            //    if (start > end)
            //    {
            //        return;
            //    }
            //    if (start % 2 == 0)
            //    {
            //        Console.WriteLine(start);
            //    }
            //    PrintEven(start +1, end);
            //}


            //public static void PrintOdd(int start, int end)
            //{
            //    if (start > end)
            //    {
            //        return;
            //    }
            //    if (start % 2 != 0)
            //    {
            //        Console.WriteLine(start);
            //    }
            //    PrintOdd(start + 1, end);
            }
        }
    } 

