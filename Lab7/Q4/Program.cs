using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
* Author: Jessica Henry                                                                                *  
* Intro - exercise Lab 7 - Q1                                                                          *                                                                                         
* Create Date: 09/10/2020                                                                              *
* Date last modification : 09/10/2020                                                                  *
********************************************************************************************************/
/*
 * Exam scores and degree classifications
A program to print out the degree classification (or not) of a candidate with a particular score. The user will enter the mark and the program would print out the classification:
1.	Less than 35% - fail
2.	Between 35% and 40% - compensatble
3.	Between 40% and 50% - third class degree - III
4.	Between 50% and 60% - lower second class degree – II(ii)
5.	Between 60% and 70% - upper second class degree – II(i)
6.	Above 70% - first class degree – I
/*/

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean ValidInput = true;
            //  double mark = 0.0;

            Console.Write("Enter the mark  : ");
            //  mark = double.Parse(Console.ReadLine());
            if (double.TryParse(Console.ReadLine(), out double mark))
            {

                if (mark >= 1 && mark <= 100)
                {
                    ValidInput = true;
                }
                else
                {
                    ValidInput = false;
                }

                if (ValidInput)
                {
                    if (mark >= 35 && mark < 40)
                    {
                        Console.WriteLine("Compensatble");
                    }
                    else if (mark >= 40 && mark < 50)
                    {
                        Console.WriteLine("Third Class Degree - III");
                    }
                    else if (mark >= 50 && mark < 60)
                    {
                        Console.WriteLine("Lower Second Class Degree – II(ii)");
                    }
                    else if (mark >= 60 && mark < 70)
                    {
                        Console.WriteLine("Upper Second Class Degree – II(i)");
                    }
                    else if (mark > 70)
                    {
                        Console.WriteLine("First Class Degree – I");
                    }
                    else
                    {

                        Console.WriteLine("Fail");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input! ");
                }

            }


            Console.ReadKey();
        }
    }
}
