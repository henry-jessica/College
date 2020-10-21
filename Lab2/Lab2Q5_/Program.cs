using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * IntroTo                                                                                              *
 * Q5. Using variables to store all data, write a program to covert 500 euro to sterling, exchange      *
 * rate is 1 euro = 0.92 sterling                                                                       *
 * -----------------------------------------------------------------------------------------------------*
 * Date: 06/10/2020                                                                                     *
 * Modi: 08/10/2020                                                                                     *
 ********************************************************************************************************/

namespace Lab2Q5_
{
    class Program
    {
        static void Main(string[] args)
        {
            double euro = 0;
            double sterling = 0;
            double convertEuroToSterling = 0;


            euro = 500;
            sterling = 0.92;

            convertEuroToSterling = euro * sterling;

            Console.WriteLine("exchange rate" + convertEuroToSterling);
        }
    }
}
