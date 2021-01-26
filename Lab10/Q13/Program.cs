using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = 0;
            double discount = 0.0;

            Console.Write("Enter Days: ");
            numDays = int.Parse(Console.ReadLine());

            discount = Discount(numDays);

            Console.WriteLine("You have {0:p0} off ", discount);

            Console.ReadKey();
        }

        static double Discount(int numDays)
        {

            double discount = 0.0;

            if (numDays >= 1 && numDays <= 7)
            {
                discount = 0;
            }
            else if (numDays >= 8 && numDays <= 14)
            {
                discount = 0.05;

            }
            else if (numDays >= 15 && numDays <= 21)
            {
                discount = 0.10;

            }
            else if (numDays >= 22)
            {
                discount = 0.15;

            }


            return discount;
        }


    }

}
