using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    class Program
    {
        static int menuChoice = 0;

        static void Main(string[] args)
        {
            while (menuChoice != 4)
            {

                if (menuChoice == 1)
                {
                    CalcRectangle();
                }
                else if (menuChoice == 2)
                {
                    CalcCircle();
                }
                else if (menuChoice == 3)
                {

                }

                PrintMenu();
            }

        }

        static void PrintMenu()
        {
            Console.WriteLine("1. Area o rectangle");
            Console.WriteLine("2. Area of circle");
            Console.WriteLine("3. Area of cyclinder");
            Console.WriteLine("4. Exit");
            menuChoice = int.Parse(Console.ReadLine());

        }
        static void CalcRectangle()
        {
            int height, width, myResult;

            Console.Write("Enter height: ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            width = int.Parse(Console.ReadLine());
            myResult = height * width;

            Console.WriteLine("Result : {0}\n", myResult);

        }
        static void CalcCircle()
        {
            double radius, area;

            Console.Write("Enter radius: ");
            radius = double.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(2, radius);

            Console.WriteLine("Result : {0} ", area);
        }
    }
}

