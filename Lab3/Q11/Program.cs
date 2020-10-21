using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *                  
 * Intro - exercise list 2 - Q10                                                                        *                                                                                         
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = 0;

            Console.Write("Enter your age: ");
            userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("You look older than " + userAge);


            Console.ReadKey();

        }
    }
}

/*
Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
Test Data:
Enter your age - 25
Expected Output:
You look older than 25
/*/
