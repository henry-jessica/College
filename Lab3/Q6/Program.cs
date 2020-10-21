using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * Intro - exercise list 2 - Q6                                                                         *                                                                                         
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, total;

            Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = int.Parse(Console.ReadLine());


            total = num1 * num2 * num3;

            Console.WriteLine("Total = " + total);

            Console.ReadKey();
        }
    }
}
