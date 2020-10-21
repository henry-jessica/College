using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * IntroTo                                                                                              *
 * Q6 - Using variables to store all data, write a program to calculate the sale cost of a pair of      *
 * jeans when the regular price is €125 and the sale is offering a 40% discount                         *                                                         *
 * Date: 06/10/2020                                                                                     *
 * Modi: 08/10/2020                                                                                     *
 ********************************************************************************************************/

namespace Lab2Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            double jeansPrice = 0;
            double jeansSalePrice = 0;
            
            
            jeansSalePrice = 125 * 0.40; //40% Off 
            jeansPrice = 125 - jeansSalePrice;

            Console.WriteLine("Special price " + jeansPrice);

            Console.ReadKey();

        }
    }
}
