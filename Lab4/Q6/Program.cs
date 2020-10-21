using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q6 Write a program to convert degrees Fahrenheit to degrees Celsius.  Input an integer Fahrenheit    * 
  temperature and convert to an integer Celsius temperature using the formula:                         *
   Celsius = 5(Fahrenheit – 32) / 9.  Output the result.                                               *
------------------------------------------------------------------------------------------------------ *
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, fahrenheit;

            Console.Write("Enter degrees Fahrenheit: ");
            fahrenheit = int.Parse(Console.ReadLine());


            celsius = 5 * (fahrenheit - 32) / 9;

            Console.WriteLine($"   {fahrenheit} °F = {celsius} °C");

            Console.ReadKey();
        }
    }
}


/*Write a program to convert degrees Fahrenheit to degrees Celsius.  
 * Input an integer Fahrenheit temperature and convert to an integer Celsius temperature using the formula:
Celsius = 5(Fahrenheit – 32) / 9.  Output the result/**/
