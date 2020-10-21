using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
 * Author: Jessica Henry                                                                                *
 * Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of         *   
 * (x+y).z and x.y + y.z.                                                                               *                  
 * Intro - exercise list 2 - Q10                                                                        *                                                                                         
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, z = 0, resulFormula1 = 0, resulFormula2 = 0;

            Console.Write("Enter first number: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = double.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            z = double.Parse(Console.ReadLine());

            resulFormula1 = ((x + y) * z);
            resulFormula2 = (x * y + y * z);

            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x + y).z is {3}", x, y, z, resulFormula1 + " and x.y + y.z is " + resulFormula2);


            Console.ReadKey();
        }
    }
}

/*Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7
Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
*/
