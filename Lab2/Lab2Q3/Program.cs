using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * IntroTo                                                                                              *
 * Q3 - Write a program to declare a single integer variable called age, assign your age to it and      *
 * display it on the screen in the format I am <age>                                                    *
 * Modify it to display                                                                                 *
 * I am <age> years old                                                                                 *
 * -----------------------------------------------------------------------------------------------------*
 * Date: 06/10/2020                                                                                     *
 * Modi: 08/10/2020                                                                                     *
 ********************************************************************************************************/

namespace Lab2Q3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int myAge = 0;

            myAge = 20;

          //  Console.Write0("Insert your Age: ");
            //myAge = Convert.ToInt32(Console.ReadLine());


            Console.Write("I am " + myAge + " years old");


            Console.ReadKey(); 
        }
    }
}
