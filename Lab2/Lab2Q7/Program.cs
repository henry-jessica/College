using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * IntroTo                                                                                              *
 * Q7. Using variables to store all data, write a program to solve the following.                       *
 * Suppose  certain car has a fuel tank with a capacity of 60 litres and an average fuel                *
 * consumption of 14km/l.                                                                               *       
 * How many times must you fill the tank to travel 2000 km ?                                            *
 * How many miles can you travel on 10 gallons of fuel using the same car?                              *
 * Date: 06/10/2020                                                                                     *
 * Modi: 08/10/2020                                                                                     *
 ********************************************************************************************************/

namespace Lab2Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            double consumptionKm = 60.00 / 14.00;
            double GallonsinLitres = 3.7854;
            double travel = ((2000.00 * consumptionKm) / 60.00);
            double totalmiles = ((GallonsinLitres * 10.00) / consumptionKm);
            double milestokm = totalmiles*1.60934;

            Console.WriteLine("Times must you fill the tank to travel 2000 km is:" + travel);
            Console.WriteLine("You can travel " + totalmiles + " miles with 10 gallons of fuel using the same car. ");

            Console.ReadKey();
        }
    }
}
