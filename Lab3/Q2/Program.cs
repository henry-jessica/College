using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * Intro - exercise list 2 - Q2                                                                         *                                                                                         
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/
namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";

            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + ", welcome to Sligo");
            Console.ReadKey();
        }
    }
}
