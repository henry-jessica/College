using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * Intro - exercise list 2 - Q5                                                                         *                                                                                         
 * Create Date: 09/10/2020                                                                              *
 * Date last modification : 09/10/2020                                                                  *
 ********************************************************************************************************/

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            double resul1, resul2, resul3, resul4;

            resul1 = -1 + 4 * 6;
            resul2 = (35 + 5) % 7;
            resul3 = 14 + -4 * 6 / 11;
            resul4 = 2 + 15 / 6 * 1 - 7 % 2;


            Console.WriteLine(" {0}\n {1}\n {2}\n {3}", resul1, resul2, resul3, resul4);


            Console.ReadLine();
        }
    }
}
