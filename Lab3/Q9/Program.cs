using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * Intro - exercise list 2 - Q9                                                                         *                                                                                         
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/
namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0, num3 = 0, num4 = 0, result = 0;

            Console.Write("Enter the First number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the Third number: ");
            num3 = double.Parse(Console.ReadLine());

            Console.Write("Enter the Four number: ");
            num4 = double.Parse(Console.ReadLine());

            result = ((num1 + num2 + num3 + num4) / 4);

            Console.WriteLine("The average of {0}, {1}, {2}, {3} ", num1, num2, num3, num4 + " is:" + result);

            Console.ReadKey();

        }
    }
}


/* Teste :
Enter the First number: 10
Enter the Second number: 15 
Enter the third number: 20 
Enter the four number: 30 
*/
