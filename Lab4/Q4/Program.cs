using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q4 Write a program to enter the distance a car has covered (in KM)  in a single journey and the      *
  time of that journey (in Hours), and return the average speed km per hour.                           *
------------------------------------------------------------------------------------------------------ *
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/
namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarate 
            double distanceKm, timeHours, speedKmHour;


            //input 
            Console.Write("Enter distance (km) : ");
            distanceKm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time of that journey (Hours) : ");
            timeHours = Convert.ToDouble(Console.ReadLine());



            speedKmHour = distanceKm / timeHours;

            //output 

            Console.WriteLine("Average speed km per hour = " + speedKmHour);


            Console.ReadKey();
        }
    }
}
