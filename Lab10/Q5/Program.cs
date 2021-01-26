using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******************************************************************************************************
* Author: Jessica Henry                                                                                *  
* 5.	Write a new version of Q4, where all data is declared at class level.                          *
*       Hint : you will not have to pass parameters as class level variables                           *
*       can be seen by all methods in the *                                                            *                             
* Create Date: 02/12/2020                                                                              *
* Date last modification : 02/12/2020                                                                  *
********************************************************************************************************/
namespace Q5
{
    class Program
    {
        static public string userName, userTown;
        static public int userAge;

        static void Main(string[] args)
        {
            userName = "GuysName";
            userTown = "GuysTown";
            userAge = 12;

            PrintGreeting_five();

        }
        static void PrintGreeting_five()
        {
            Console.WriteLine("Name {0} - town {1} - Age {2} ", userName, userTown, userAge);
            
        }

    }
}
