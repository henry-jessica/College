using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q3 Create a project that takes the width and height of a window and outputs the area of glass        *
  required to make the window.  It will also compute the length of wood required  to make the window.  *
  Input will be in millimetres.                                                                        *
------------------------------------------------------------------------------------------------------ *
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = 0.0, height = 0.0, windowArea = 0.0, windowPerimeter = 0.0;
            double priceWood = 0.0, priceGlass = 0.0, totalPriceGlass = 0.0, totalPriceWood = 0.0;

            Console.Write("Enter Window Width: ");
            width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Window Height: ");
            height = Convert.ToDouble(Console.ReadLine());

            windowArea = ((width * height) / 1000000);
            windowPerimeter = (((width * 2) + (height * 2)) / 1000);

            Console.WriteLine("Wood Amont {0} m", windowPerimeter);
            Console.WriteLine("Glass Area {0} sqr m", windowArea);
            Console.WriteLine("");


            Console.Write("Enter Cost of Wood Euro's : ");
            priceWood = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Cost of Glass Euro's : ");
            priceGlass = Convert.ToDouble(Console.ReadLine());


            totalPriceGlass = priceGlass * windowArea;
            totalPriceWood = windowPerimeter * priceWood;

            Console.WriteLine("Cost");

            Console.WriteLine("Wood Cost = {0} Euro's", totalPriceWood);
            Console.WriteLine("Glass Area = {0} Euro's", totalPriceGlass);

            Console.ReadKey();


        }
    }
}
