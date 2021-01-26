using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******************************************************************************************************
* Author: Jessica Henry                                                                                *  
* 4.Modify the method to display the name, age and the town of a person, who’s name,                   *
* age and town is passed to it as an argument.                                                         *                                                                                         
* Create Date: 02/12/2020                                                                              *
* Date last modification : 02/12/2020                                                                  *
********************************************************************************************************/
namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Pat", userTown = "Sligo";
            int userAge = 12;

            PrintGreeting_four(userName, userTown, userAge);
        }
        static private void PrintGreeting_four(string userName, string userTown, int userAge)
        {
            Console.WriteLine("Name {0}  - Town {1}  - Age {2}", userName, userTown,userAge);
        }

    }
}
