using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * IntroTo                                                                                              *
 * Q4 Declare two integers, one called apples and the other called oranges. Assign the value 6 to       *
 * apples and the value 8 to oranges.                                                                   *
 * Write code to add the two and display the answer in the form:                                        *
 * You have 6 apples                                                                                    *
 * You have 8 oranges                                                                                   *
 * You have 14 pieces of fruit                                                                          *
 * -----------------------------------------------------------------------------------------------------*
 * Date Create: 06/10/2020                                                                              *
 * Date modi:   08/10/2020                                                                              *
 ********************************************************************************************************/

namespace Lab2Q4_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int oranges = 8;
            int apples = 6;
            int total = 0;

            total = apples + oranges; 

             Console.WriteLine("You have " + apples);
             Console.WriteLine("You have " + oranges);
             Console.WriteLine("You have " + total + " pieces of fruit");

             Console.WriteLine(apples+ " apples and "+ oranges+ " aranges gives you " + total + " pieces of fruit.");
            

            Console.ReadKey();

        }
    }
}

/*int oranges = 0;
int apples = 0;
int total = 0;

            Console.WriteLine("How many Apples?");
            apples = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Oranges? ");
            oranges = Convert.ToInt32(Console.ReadLine());

            total = apples + oranges;

            Console.WriteLine("You have " + total + " pieces of fruit");

            Console.WriteLine(apples + " apples and " + oranges + " aranges gives you " + total + " pieces of fruit.");

            Console.ReadKey();

*/
