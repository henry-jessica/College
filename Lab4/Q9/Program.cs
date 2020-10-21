using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q9 A farmer  wants to spread fertiliser on his fields at the recommended rate of 50 grams per        *
  square metre. Given that fertiliser cost €10.00 per kilogram write a program to input the length     *
  and width of the field in metres and which calculates and outputs.                                   *
------------------------------------------------------------------------------------------------------ *
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthMetres, widthMetres, area, totalFertiliser, totalCostFer;

            Console.Write("Enter length (metres) : ");
            lengthMetres = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Width (metres)  : ");
            widthMetres = Convert.ToDouble(Console.ReadLine());

            area = (lengthMetres * widthMetres);

            totalFertiliser = area * 0.50;

            totalCostFer = 0.01 * totalFertiliser;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"1. The area of the lawn                   : {area} square metre");
            Console.WriteLine($"2. The total amount of fertiliser needed  : {totalFertiliser} grams");
            Console.WriteLine($"3. The total cost of the fertiliser       : {totalCostFer} euros");

            Console.ReadKey();
        }
    }
}
