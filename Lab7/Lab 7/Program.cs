using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/********************************************************************************************************
* Author: Jessica Henry                                                                                *  
* Intro - exercise Lab 7 - Q1                                                                          *                                                                                         
* Create Date: 09/10/2020                                                                              *
* Date last modification : 09/10/2020                                                                  *
********************************************************************************************************/
namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int movieOption = 0;
            int movie = 0;
            int tabeAge = 0;
            int userAge = 0;
            string choice = "1";


            while (choice == "1")
            {
                Console.Clear();

                Console.WriteLine("\nWelcome to our Sligo Multiplex");
                Console.WriteLine("\nWe are presently showing:");
                Console.WriteLine("\t1.Made in Dagenham(15)");
                Console.WriteLine("\t2.Buried(18)");
                Console.WriteLine("\t3.Despicable Me(U)");
                Console.WriteLine("\t4.The Other Guys(12A)");
                Console.WriteLine("\t5.Takers(12A)");
                Console.WriteLine("\tEnter the number of the film you wish to see: 1");
                Console.WriteLine("\tEnter your age: 12");
                Console.WriteLine("\tAccess denied – you are too young");

                try
                {
                    Console.Write("Enter the number of the film you wish to see : ");
                    movieOption = int.Parse(Console.ReadLine());

                    /// check error ----------------------- Version2---
                    if (movieOption < 1 || movieOption > 5)
                    {
                        Console.WriteLine("Invalid Movie! ");
                        Thread.Sleep(2000);
                        Console.Clear();
                        continue;

                    }
                    Console.Write("Enter your age                               : ");
                    userAge = int.Parse(Console.ReadLine());
                    /// check error ----------------------- Version2---
                    if (userAge < 1 || userAge > 115)
                    {
                        Console.WriteLine("Invalid Age!");
                        Thread.Sleep(2000);
                        Console.Clear();

                        continue;

                    }

                    if ((movieOption == 1 && userAge > 15) || (movieOption == 2 && userAge >= 18) ||
                         (movieOption == 4 && userAge > 12) || (movieOption == 5 && userAge > 12) || (movieOption == 3))
                    {
                        Console.WriteLine("OK you are permited to view");
                    }

                    /* else if (movieOption < 1 || movieOption > 5)
                     {
                         Console.WriteLine("\n\nValue not autorizaded, please try it again");
                     }
                     else
                   */
                    {
                        Console.WriteLine("\n\nAccess denied – you are too young");
                    }


                    Console.WriteLine("\n\nWould you like to Exit    1 - No      2 - Yes");
                    choice = Console.ReadLine();
                }

                catch
                {

                    Console.WriteLine("\n\nValue not autorizaded, please try it again");

                    Thread.Sleep(2000);
                    Console.Clear();

                }


            }

        }
    }
}
