using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
  Author: Jessica Henry                                                                                *  
  IntroTo    s00214115                                                                                 *
  Q2 - The average is <result>                                                                         *                                                         
  Create Date: 14/10/2020                                                                              *
  Version: 01 - 14/10/2020                                                                             *
 ********************************************************************************************************/
namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double num1, num2, result;

            Console.Write("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());

            //process 

            result = ((num1 + num2)/2);
            
            //output
            Console.WriteLine("The average is " + result);

            Console.WriteLine("------------------------------------------------");


            Console.WriteLine("The average of {0} and {1} is {2} ", num1, num2, result);

            


            Console.ReadKey();


        }
    }
}
