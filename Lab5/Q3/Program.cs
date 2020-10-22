using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            //  n is the number of payments
            //  r is the rate of interest
            //  PV is the present value of the loan

            double pv, payment, r, totalpayment, totalr;
            int n;

            Console.Write("Enter the number of payments: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter the rate of interest: ");
            r = double.Parse(Console.ReadLine());

            Console.Write("Enter the present value of the loan: ");
            pv = double.Parse(Console.ReadLine());

            r = r / 100;
            
            payment = (pv * Math.Pow((r / 12) + 1, (n)) * r / 12)
                       / (Math.Pow(r / 12 + 1, (n)) - 1);

            totalpayment = payment * n;

            totalr = totalpayment - pv;

            Console.WriteLine(" Monthly payment {0:c2} :" , payment);
            Console.WriteLine(" Total paid in interest {0:c2}:",  totalr); 
            Console.WriteLine(" Total loan paid: {0:c2}", totalpayment);
            


            Console.ReadKey();
        }
    }
}

