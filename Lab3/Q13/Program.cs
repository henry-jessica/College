using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *                  
 * Intro - exercise list 2 - Q13                                                                        * 
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = 0, kelvin = 0, fahrenheit = 0;

            Console.Write("Enter the amount of celsius: ");
            celsius = int.Parse(Console.ReadLine());

            fahrenheit = celsius * 9 / 5 + 32;

            kelvin = celsius + 273;

            Console.WriteLine("Kelvin = " + kelvin + "\nFahrenheit = " + fahrenheit);

            Console.ReadKey();

        }
    }
}


/*13 Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
 Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86
*/
