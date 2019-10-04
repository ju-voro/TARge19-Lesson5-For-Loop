using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR-LOOP
            //int i = 0 - start of the loop; i < 10 - stop; i++ - step
            for (int i = 1; i < 11; i+=2)
            {
                Console.WriteLine($"i equals {i}");
            }

            Console.WriteLine("\n");

            for (int j = 10; j > -1; j--)
            {
                Console.WriteLine($"j equals {j}");
            }

           



            Console.ReadLine();

            //TASK1 - write a C# program to check whether a user's number is positive, negative or zero
            //TASK2 - write a C# program to check whether a user's number is divisible by 5 and/or 11 or not
            //TASK3 - write a C# program check whether a user's number is even or odd
            //TASK4 - write a C# program to check if a user's input is a vowel or 
            //or something else
            //TASK5 - Write a C# program that asks a user to input a number(1-7) 
            //and print the corresponding day of week (Monday - Sunday)
        }
    }
}
