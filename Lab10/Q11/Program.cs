using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthNum = 0;
            Console.Write("the month number: ");
            monthNum = int.Parse(Console.ReadLine());

            Month(monthNum);

            Console.ReadKey();
        }
        static void Month(int monthNumber)
        {

            switch (monthNumber)
            {
                case 1:
                    {
                        Console.WriteLine("Jan");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Fev");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Mar");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Apr");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("May");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Jun");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Jul");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Aug");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Sep");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Oct");
                        break;
                    }

                case 11:
                    {
                        Console.WriteLine("Nov");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("Dec");
                        break;
                    }
            }

        }

    }
}
