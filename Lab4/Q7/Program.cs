using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q7 Write a program to calculate the amount of a tip in a restaurant.  The tip rate is 18%.           *
  Your program will read in the cost of the meal, calculate the tip and display the total due.         *
------------------------------------------------------------------------------------------------------ *
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost, tip, totalDue, totalsplitbill;
            int totalusers;

            Console.Write("Enter Meal Cost ");
            mealCost = Convert.ToDouble(Console.ReadLine());

            tip = (mealCost * 0.18);
            totalDue = mealCost + tip;
            Console.WriteLine("");
            Console.WriteLine(" Meal Cost {0,5}", mealCost);

            Console.WriteLine(" Tip Rate    18%");
            Console.WriteLine(" Tip {0,11}", tip);
            Console.WriteLine(" Total Due {0,6} ", totalDue);


            Console.WriteLine("-------------------------------------- ");

            Console.Write("Enter the number of diners ");
            totalusers = Convert.ToInt16(Console.ReadLine());


            totalsplitbill = totalDue / totalusers;

            Console.WriteLine($"Total to be charged for each = { totalsplitbill} ");


            Console.ReadKey();
        }
    }
}

