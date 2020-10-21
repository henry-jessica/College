using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *                  
 * Intro - exercise list 2 - Q12                                                                        *
 * Write a C# program to that takes a number as input and display it four times in a row                *
 * (separated by blank spaces) and then four times in the next row, with no separation.                 *
 * You should do it two times: Use a formatted *                                                        *
 * string *                                                                                             *
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;

            Console.Write("Enter a digit: ");
            num = Console.ReadLine();

            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);


            Console.ReadKey();

        }
    }
}


/*
 Test Data:
Enter a digit: 25 
Expected Output:
25 25 25 25 
25252525 
25 25 25 25 
25252525
*/
