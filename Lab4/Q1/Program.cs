using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q1 - Create a program that asks the user to enter their name and then displays a personalised        *
  greeting.                                                                                            *                                                         
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/
namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            String userName, userAge;

            Console.Write("Enter your name  : ");
            userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Welcome to It Sligo", userName);

            Console.WriteLine("");

            Console.Write("Enter your age  : ");
            userAge = Console.ReadLine();

            Console.WriteLine("Hello {0}, you are {1}", userName, userAge);

            Console.ReadKey();
        }
    }
}
