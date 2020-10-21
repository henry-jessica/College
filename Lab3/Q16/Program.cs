using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = 0;
            double convertToKm;

            Console.Write("Enter miles: ");
            miles = int.Parse(Console.ReadLine());

            convertToKm = miles / 0.625;

            Console.WriteLine(miles + " miles is = " + convertToKm + " Km");



            Console.ReadKey();
        }
    }
}

/*Write a program that reads an integer number of miles, converts it to an 
 * equivalent number of kilometres, and outputs the result (1 km = 0.625 mile) 
 * (generate test data first)*/
