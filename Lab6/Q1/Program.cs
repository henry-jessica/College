using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 0;
            string choice = "";

            while (choice != "2")
            {
                Console.Clear();

                try
                {
                    Console.Write("Enter the temperature of a nuclear reactor: ");
                    temperature = int.Parse(Console.ReadLine());

                    if (temperature > 250)
                    {
                        Console.WriteLine("\n Shut down the reactor NOW! \n");
                       
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Would you like to do it again?\n 1 - Yes    2 - No");
                    choice = Console.ReadLine();


                }
                catch 
                {

                    Console.Write("Value not autorizeded, please try again");
                    Thread.Sleep(1000);
                    Console.Clear();

                    continue;

                }
            }

        }

    }

}
