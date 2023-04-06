
//ex1
//Console.Write("Enter the first number: ");
//int firstNum = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the second number: ");
//int secondNum = Convert.ToInt32(Console.ReadLine());

//if (firstNum == secondNum)
//{
//    Console.WriteLine("The numbers are equal!");
//}
//else
//{
//    Console.WriteLine("The numbers are different");
//}


//ex2
//Console.Write("Enter the first number: ");
//int firstNum = Convert.ToInt32(Console.ReadLine());
//if (firstNum < 0)
//{
//    Console.WriteLine("The number is negative");
//}
//else
//{
//    Console.WriteLine("The number is positive");
//}

//ex3
//Console.WriteLine("Enter your heigh in cm: ");
//double heigh = Convert.ToDouble(Console.ReadLine());
//if (heigh <= 150)
//{
//    Console.WriteLine("You are short");
//}
//else if (heigh >= 150 && heigh <= 180 )
//{
//    Console.WriteLine("Your height is medium");
//}
//else if(heigh > 180){
//    Console.WriteLine("You are tall");
//}

//ex4
//Console.Write("Input the marks in maths: ");
//int math = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input the marks in Phy: ");
//int phy = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input the marks in Chem: ");
//int chem = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Total in all three subjects is: {math + phy + chem}");

//if (math>=65)
//    if (phy>=55)
//        if (chem>=50)
//            if ((math + phy + chem)>=180||(math + phy)>=140)
//            {
//                Console.Write("The  candidate is eligible for admission.\n");
//            }
//            else
//            {
//                Console.Write("The candidate is not eligible.\n\n");
//            }


//ex5
//int sum = 0;
//for (int i = 1; i < 11; i++)
//{
//    sum = sum + i;
//    Console.Write("{0} ", i);

//}
//Console.WriteLine($"the sum is {sum}");

//ex6
//int i,n;
//double avg;
//int sum = 0;

//Console.WriteLine("Input numbers from 1 to 10!");
//for(i = 1; i < 11; i++)
//{
//    Console.Write("Number-{0} :", i);

//    n= Convert.ToInt32(Console.ReadLine());
//    sum +=n;
//}
//avg = sum / 10.0;
//Console.WriteLine($"the sum is {sum}");
//Console.WriteLine($"the average is {avg}");

//ex7
//int i = 1;

//Console.WriteLine("Enter a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

//do
//{
//    int result = num * i;
//    Console.WriteLine("{0} x {1} = {2}", num, i, result);
//    i++;
//} while (i <= 10);

//ex8


//ex9
//Console.WriteLine("Enter a number of elements: ");

//int numElements = int.Parse(Console.ReadLine());
//int[] myArray = new int[numElements];

//for (int i = 0; i < numElements; i++)
//{
//    Console.Write("Element {0}: ", i + 1);
//    int elem = int.Parse(Console.ReadLine());
//    myArray[i] = elem;




//}

//Console.WriteLine("Array elements:");

//for (int i = 0; i < numElements; i++)
//{
//    Console.WriteLine(myArray[i]);
//}

//ex10
int[] arr = { 1, 2, 3, 4, 5, 6 };

int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
    Console.WriteLine(sum);

}
Console.WriteLine("Sum of array elements: " + sum);

//ex11
int[] myArray = { 1, 2, 2, 3, 4, 4, 4, 5 };
int count = 0;

for (int i = 0; i < myArray.Length; i++)
{
    for (int j = i+1; j < myArray.Length; j++)
    {
        if (myArray[i] == myArray[j])
        {
            count++;
            break;
        }
    }
}
Console.WriteLine("Total number of duplicate elements: " + count);











