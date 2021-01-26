using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******************************************************************************************************
* Author: Jessica Henry                                                                                *  
* 6.	Write a method that return the area of a rectangle                                             *                             
*------------------------------------------------------------------------------------------------------*             
* Create Date: 02/12/2020                                                                              *
* Date last modification : 02/12/2020                                                                  *
********************************************************************************************************/
namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int height, width, myResult;

            Console.Write("Enter height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            width = int.Parse(Console.ReadLine());
            myResult = CalArea(width, height);
            Console.WriteLine("Result : {0}", myResult);

        }

        static int CalArea(int height, int width)
        {
            int myResult = 0;
            myResult = height * width;
            return myResult;
        }
    }
}
