using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/********************************************************************************************************
* Author: Jessica Henry                                                                                *  
* Q1 - Lab 9                                                                                           *                                                                                         
* Create Date: 01/12/2020                                                                              *
* Date last modification : 01/12/2020                                                                  *
********************************************************************************************************/
namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintingA();
            PrintingB();
            PrintingC();
            PrintingD();

            //parameters num1 and num2 
            Console.WriteLine("\ne)");
            Console.Write("Enter num1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num1: ");
            int num2 = int.Parse(Console.ReadLine());

            PrintingE(num1, num2);

            Console.ReadKey();
        }

        static void PrintingA()
        {
            Console.WriteLine("a) ");
            for (int i = 1; i <= 20; i++)
            {
                //Thread.Sleep(1000);
                Console.Write("{0}  ", i);
            }
        }

        static void PrintingB()
        {
            Console.WriteLine("\nb) ");

            for (int i = 1; i <= 20; i++)
            {

                Thread.Sleep(1000);
                Console.Write("{0}  ", i);
            }
        }

        static void PrintingC()
        {
            Console.WriteLine("\nc) ");
            for (int i = 20; i > 0; i--)
            {

                Console.Write("{0} ", i);
            }

        }

        static void PrintingD()
        {
            Console.WriteLine("\nd)");
            int sum = 0;
            for (int i = 1; i < 21; i++)
            {
                sum += i;
            }
            Console.Write("sum {0} ", sum);

        }

        static void PrintingE(int num1, int num2)
        {
            int sum = 0;

            for (int i = 1; i < 21; i++)
            {
                sum = num1 + num2;
            }
            Console.WriteLine("sum {0} ", sum);


        }

    }

}

