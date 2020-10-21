using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * Intro - exercise list 2 - Q7                                                                         *                                                                                         
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, sub, mul, div, mod;

            Console.Write("Input the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;

            Console.Write("\n " + sum + " \n " + sub + " \n " + mul + " \n " + div + " \n " + mod);

            Console.ReadKey();
        }
    }
}


