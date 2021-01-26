using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string choice = "0";

            while (choice != "1")
            {
                Console.Clear();

                try
                {
                    Console.Write("Enter person`s age: ");
                    age = int.Parse(Console.ReadLine());

                    if (age > 18 && age <= 25)
                    {
                        Console.WriteLine("You are eligible for a visa to visit the country!");
                    }
                    else
                    {
                        Console.WriteLine("You are NOT eligible for a visa to visit the country!");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Exit \n 1 - Yes    2 - No");
                    choice = Console.ReadLine();

                }
                catch
                {
                    Console.Write("Value not autorizaded! Please try again ");
                    Thread.Sleep(1000);

                }

            }
           
        }
    }
}

