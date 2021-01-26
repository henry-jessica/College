using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************************
* Author: Jessica Henry                                                                                 *  
* Intro - exercise Lab 7 - Q1                                                                           *                                                                                         
* Create Date: 09/10/2020                                                                               *
* Date last modification : 09/10/2020                                                                   *
/********************************************************************************************************/
namespace Q2

{
    class Program
    {
        static void Main(string[] args)
        {
            double testScore = 0.0;

            const int gradeA = 85;
            const int gradeB = 60;
            const int gradeC = 40;

            Console.Write("Test Score : ");
            testScore = double.Parse(Console.ReadLine());

            if (testScore >= gradeC && testScore < gradeB)
            {
                Console.WriteLine("C ");
            }
            else if (testScore > gradeB && testScore < gradeA)
            {
                Console.WriteLine("B ");
            }
            else if (testScore > gradeA)
            {
                Console.WriteLine("A ");
            }
            else
            {
                Console.WriteLine("F ");
            }


            Console.ReadKey();

        }
    }
}




