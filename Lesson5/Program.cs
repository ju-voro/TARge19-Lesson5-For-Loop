﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int cpuNumber;           
            int tries = 0;
            bool gameOver = false;

            //Generate a random number for the CPU from 1 to 5
            Random rnd = new Random();
            cpuNumber = rnd.Next(1, 11);

            Console.WriteLine("Please, enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");

            //!gameOver = NOT gameOver = true
            while (!gameOver)
            {
                int userNumber;
                Console.WriteLine("Try to guess the number:");
                userNumber = int.Parse(Console.ReadLine());
                
                if(userNumber > cpuNumber)
                {
                    Console.WriteLine("CPU number is smaller.");
                }
                else if(userNumber < cpuNumber)
                {
                    Console.WriteLine("CPU number is bigger.");
                }
                else
                {
                    Console.WriteLine("Got me!");
                    gameOver = true;
                }

            }

            Console.ReadLine();


        }
    }
}
