using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * Intro - exercise list 2 - Q8                                                                         *                                                                                         
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = 0, aux = 0;

            Console.Write("Enter the number: ");
            num = double.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                aux = num * i;
                Console.WriteLine(" " + aux);
            }

            Console.ReadKey();

        }
    }
}
