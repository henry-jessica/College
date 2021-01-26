using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 0.0;
            string choice = "1";

            while (choice == "1")
            {
                try
                {
                    Console.Write("Enter person’s salary: ");
                    salary = int.Parse(Console.ReadLine());

                    if (salary < 10000)
                    {
                        Console.WriteLine("Not Great");
                    }
                    else if (salary > 10000)
                    {
                        Console.WriteLine("Great Salary");
                    }
                    else
                    {
                        Console.WriteLine("Salary is ok");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Would you like to do it again?\n 1 - Yes    2 - No");
                    choice = Console.ReadLine();

                }

                catch
                {
                    Console.Write("Value not authorized! Try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

            }


        }
    }
}
