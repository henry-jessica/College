using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string emploName = "";
            double salary = 0, tax = 0, payment = 0;

            Console.Write("Enter employee’s name: ");
            emploName = Console.ReadLine();

            Console.Write("Enter employee’s salary: ");
            salary = int.Parse(Console.ReadLine());

            tax = (salary * 0.40);
            payment = salary - tax;

            Console.WriteLine("With a tax rate of {0:p0}, tax is {1:c2} and take home pay is {2:c2}",0.40, tax, payment);

            Console.ReadKey();
        }
    }
}

/*Write a program to read in an employee’s name and salary calculate their tax and take home pay.  
 * Tax is charged at 40%.  Store the tax rate as a constant in your program.

Output the result in the format

With a tax rate of xx%, tax is €x,xxx.xx and take home pay is €x,xxx.xx
 
*/
