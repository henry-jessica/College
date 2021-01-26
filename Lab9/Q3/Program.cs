using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
* Author: Jessica Henry                                                                                *  
* Q3 - Lab 9                                                                                           *                                                                                         
* Create Date: 01/12/2020                                                                              *
* Date last modification : 01/12/2020                                                                  *
********************************************************************************************************/
namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            double feeRate, weightBooks = 0, total = 0;
            // string typeDelivery = " ";
            string choice = "";

            Boolean ValidInput = true;
            const double FLAT = 2.5;
            const string TABLEINPUT = "{0,-55}{1,10}";

            do
            {
                Console.WriteLine("Online Book Retailer Cost\n");
                Console.Write(TABLEINPUT, "Please enter Weigh of Book(s) in grams", ":");
                weightBooks = double.Parse(Console.ReadLine());
                Console.Write(TABLEINPUT, "Delivery  (r :  regular    x : express)", ":");
                //typeDelivery = Console.ReadLine().ToUpper();
                if (char.TryParse(Console.ReadLine().ToUpper(), out char typeDelivery))
                {
                    if (typeDelivery == 'R' || typeDelivery == 'X')
                    {
                        ValidInput = true;
                    }
                    else
                    {
                        ValidInput = false;
                    }
                }
                else
                {
                    ValidInput = false;

                }
                if (ValidInput)
                {
                    if (weightBooks >= 0 && weightBooks <= 2000)
                    {
                        feeRate = 0.025;
                        total = FLAT + weightBooks * feeRate;
                    }
                    else if (weightBooks > 2000 && weightBooks < 5000)
                    {
                        total = (FLAT + (2000 * 0.025) + ((weightBooks - 2000) * 0.03));
                    }
                    else
                    {
                        total = (FLAT + (2000 * 0.025) + ((weightBooks - 2000) * 0.05));
                    }


                    if (typeDelivery == 'X')
                    {
                        total = total + 1.50;
                    }

                    Console.WriteLine("\nThe cost of books weighting {0} is {1}", weightBooks, total);
                    Console.Write("\nCalculate another (y / n) :");
                    choice = Console.ReadLine().ToUpper();
                }
                else
                {
                    Console.WriteLine("\nInvalid Delivery");
                }

            } while (choice != "N");
        }
    }
}
