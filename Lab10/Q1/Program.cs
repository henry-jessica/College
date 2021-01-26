using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*******************************************************************************************************
* Author: Jessica Henry                                                                                *  
* Q1 LAB10                                                                                             *                                                                                         
* Create Date: 02/12/2020                                                                              *
* Date last modification : 02/12/2020                                                                  *
********************************************************************************************************/
namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string userName = "pat";

            PrintGreeting(userName);
            PrintGreeting_Two(userName);
            
        }

        static private void PrintGreeting(string userName)
        {
            Console.WriteLine("Hello {0}", userName);
        }


        static private void PrintGreeting_Two(string studentName)
        {
            Console.WriteLine("Hello {0}", studentName);
        }

        
    }
}
