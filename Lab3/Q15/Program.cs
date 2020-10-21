using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Q15
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance, timeHours, speedKmHours;

            Console.Write("Enter the distance a car has covered (in KM)  in a single journey: ");
            distance = double.Parse(Console.ReadLine());

            Console.Write("the time of that journey (in Hours): ");
            timeHours = double.Parse(Console.ReadLine());

            speedKmHours = distance / timeHours;

            Console.WriteLine("the average speed km per hour :" + speedKmHours);


            Console.ReadKey();
        }
    }
}

/*Write a program to enter the distance a car has covered (in KM)  in a single journey and the time of that journey 
 * (in Hours), and return the average speed km per hour. (generate test data first) */
