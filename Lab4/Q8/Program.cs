using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q8 Write a program to input your first name, your height in feet and inches and print your height in *
  metres.  Your dialogue will appear as follows                                                        *
------------------------------------------------------------------------------------------------------ *
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/
namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            double totalMetres, feet, inches;

            Console.Write("Enter your first name :  ");
            userName = Console.ReadLine();
            Console.Write("        Feet   : ");
            feet = Convert.ToDouble(Console.ReadLine());
            Console.Write("        Inches : ");
            inches = Convert.ToDouble(Console.ReadLine());

            totalMetres = (((inches / 12) + feet) * 0.3048);

            Console.WriteLine($"{userName}, you are {totalMetres:f3} in height");
            Console.ReadKey();
        }
    }
}
