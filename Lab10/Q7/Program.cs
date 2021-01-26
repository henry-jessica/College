using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******************************************************************************************************
* Author: Jessica Henry                                                                                *  
* 7.	Write a method that return the area of a circle                                                *                             
*------------------------------------------------------------------------------------------------------*             
* Create Date: 02/12/2020                                                                              *
* Date last modification : 02/12/2020                                                                  *
********************************************************************************************************/
namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.Write("Enter radius: ");
            radius = double.Parse(Console.ReadLine());

            area = CalArea(radius);
            Console.WriteLine("Result : {0} ", area);


            Console.ReadKey();

        }

        static double CalArea(double radius)
        {
            double area = 0.0;
            area = Math.PI * Math.Pow(2, radius);
            return area;
        }
    }

}


