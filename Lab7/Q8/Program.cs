using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            int boxerWeight = 0;

            Console.Write("Enter the weight of the boxer in pounds : ");
            boxerWeight = int.Parse(Console.ReadLine());


            if (boxerWeight <= 90)
            {
                Console.WriteLine("Cruiserweight ");
            }
            else if (boxerWeight <= 175)
            {
                Console.WriteLine("Light Heavyweight ");
            }
            else if (boxerWeight <= 168)
            {
                Console.WriteLine("Super Middleweight");
            }
            else if (boxerWeight <= 160)
            {
                Console.WriteLine("Middleweight");
            }
            else if (boxerWeight <= 154)
            {
                Console.WriteLine("Junior Middleweight");
            }

            else if (boxerWeight <= 147)
            {
                Console.WriteLine("Welterweight");
            }
            else if (boxerWeight <= 140)
            {
                Console.WriteLine("Junior Welterweight ");
            }
            else if (boxerWeight <= 135)
            {
                Console.WriteLine("Lightweight");
            }
            else if (boxerWeight <= 130)
            {
                Console.WriteLine("Junior Lightweight");

            }
            else if (boxerWeight <= 126)
            {
                Console.WriteLine("Featherweight");
            }
            else if (boxerWeight <= 122)
            {
                Console.WriteLine("Junior Featherweight");
            }
            else if (boxerWeight <= 118)
            {
                Console.WriteLine("Bantamweight");
            }
            else if (boxerWeight <= 115)
            {
                Console.WriteLine("Junior Bantamweight");
            }
            else if (boxerWeight <= 112)
            {
                Console.WriteLine("Flyweight");
            }
            else if (boxerWeight <= 108)
            {
                Console.WriteLine("Junior Flyweigh");
            }
            else if (boxerWeight <= 105)
            {
                Console.WriteLine("Strawweight");
            }
            else
            {
                Console.WriteLine("Heavyweight");
            }

            Console.ReadKey();
        }


    }
}


