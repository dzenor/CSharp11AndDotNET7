//ex1 every number divided to zero is zero
//int num1 = 21;
//Console.WriteLine(num1/0);


//ex2 infinity
//double num2 = 3.23;
//Console.WriteLine(num2/0);

//ex3
//    koga kje se sluci overflow na variablata int se slucuva toa da variablata se vrakja na svojata najmala vrednost koja taa moze da ja ima

//ex4
//what is difference between x=y++ and x=++y?
//the difference is that y++ first assigned to her current value of y to x then increment by one,++y first incremet by 1 then assign to x


//ex5
//what is the difference between break continue and return when used inside a loop statement?
//break imidiatly terminates the loop and program continue to execute code after the looppp
//continue imidiatly skip the current iteration and proceed to execute another iteration
//return is used to to exit a function or a method and return the value to the caller

//ex6
//what are three parts of a for statement and which of them are required 
//Initialization clause: This is the first part of the "for" statement, and it is used to initialize a loop control variable. It typically includes the declaration and initialization of a loop counter variable, which is used to control the number of iterations in the loop. 
//Condition clause: This is the second part of the "for" statement, and it is used to specify a condition that must be true for the loop to continue executing. 
//Iteration clause: This is the third part of the "for" statement, and it is used to specify how the loop control variable should be updated after each iteration of the loop. 
//all three are ruquired

//ex7
//what is the difference between = and == operator
// the = operator is use to assign a variable
//the == operator is use to compare two variables and check if they are equal

//ex8
////does the following statement compile?
//for (; ; );
//yes the following statement can be compiled and represent a infinity loop where the condition is ommited leaving all three parts of the statements empty This loop will keep executing indefinitely because there is no condition to terminate it. It will continue looping until it is manually terminated by an external means, such as by stopping the program or using a break statement within the loop body.

//ex9
//what does the underscore _ represent in switch statement?
//this is equivalent using default in switch statement its the same thing it get all cases

//ex10
//what interface must an object implement to be enumerated over using foreach statement?
//The IEnumerable interface represents a collection of objects that can be enumerated, while the generic IEnumerable<T> interface represents a collection of objects of a specific type T that can be enumerated. Both interfaces define a single method called GetEnumerator() that returns an object implementing the IEnumerator or IEnumerator<T> interface, respectively.

//what code could you add to warn us about the problem?
//int max = 500;
//for(byte i =0; i < max; i++)
//{
//    //the byte can go from 0-255 and we will never have i to get to 500 and by this we wil create infinity for loop
//    Console.WriteLine(i);
//}    

//FIZZBUZZ

//for(int i = 1; i <= 100; i++)
//{
//   if(i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }else if(i % 5 == 0) {
//        Console.WriteLine("Buzz");
//    }else if(i%3==0 && i%5 == 0)
//    {
//        Console.WriteLine("FizBuzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}

//EXEPTION HANDLING

//try
//{
//    Console.Write("Enter a number between 0 and 255: ");
//    int num1 = Convert.ToInt32(Console.ReadLine());
//    Console.Write("Enter another number between 0 and 255: ");
//    int num2 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"{num1} divided by {num2} is {num1 / num2}");
//}
//catch( Exception ex )
//{
//    Console.WriteLine(ex.Message);
//}









