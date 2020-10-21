using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q5 Write a program that reads an integer number of miles, converts it to an equivalent number        *
       of kilometres, and outputs the result (1 km = 0.625 mile)                                       *
------------------------------------------------------------------------------------------------------ *
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/


namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles;
            double km;

            Console.Write("Enter number of miles: ");
            miles = int.Parse(Console.ReadLine());

            km = miles / 0.625;

            Console.WriteLine($"  {km} Km = {miles} mile " );

            //1 km = 0.625 mile 

            Console.ReadKey();
        }
    }
}
