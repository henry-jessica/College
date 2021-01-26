using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******************************************************************************************************
* Author: Jessica Henry                                                                                *  
* 3 - Modify the method to display the name and age of a person, who’s name and age is passed to       *
*     it as an argument                                                                                *
* Date last modification : 02/12/2020                                                                  *
********************************************************************************************************/
namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Pat";
            int age = 12;

            PrintGreeting_three(name, age);
        }

        static private void PrintGreeting_three(string studentName, int age)
        {
            Console.WriteLine("Name {0} and Age {1}", studentName, age);
        }
    }
}
