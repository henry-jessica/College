using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *                  
 * Intro - exercise list 2 - Q14                                                                        * 
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/
namespace Q14
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1, num2;

            Console.Write("Input the First Number : ");
            num1 = Console.ReadLine();

            Console.Write("Input the Second Number : ");
            num2 = Console.ReadLine();

            Console.WriteLine("After Swapping : \nFirst Number : " + num2 + "\nSecond Number: " + num1);

            Console.ReadKey();
        }
    }
}


/*14.Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6

Expected Output: 
After Swapping :
First Number : 6 
Second Number : 5 
*/
