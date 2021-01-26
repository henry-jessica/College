using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 0;
            double amount = 0;
            string choice = "1";

            do
            {
                Console.Clear();

                try
                {
                    Console.Write("Enter the number of days rental: ");
                    days = int.Parse(Console.ReadLine());

                    if (days > 3 && days < 33)
                    {
                        const int fixPrice = 6;
                        const double priceAddDays = 1.50;
                        const int fixDays = 3;

                        days = days - fixDays;
                        amount = (days * priceAddDays) + fixPrice;

                        Console.WriteLine("The cost of renting a game is: {0:c2}", amount);

                    }
                    else if (days >= 33)
                    {
                        Console.WriteLine("The cost of renting a game is: 50.00 euros");

                    }
                    else
                    {
                        amount = days * 2;
                        Console.WriteLine("The cost of renting a game is: {0:c2}", amount);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Exit \n 1 - Yes    2 - No");
                    choice = Console.ReadLine();
                }

                catch
                {
                    Console.Write("Value not authorized! Try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

            } while (choice != "1");


        }
    }
}
