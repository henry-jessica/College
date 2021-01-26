using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/********************************************************************************************************
* Author: Jessica Henry                                                                                *  
* Q2 - Lab 9                                                                                           *                                                                                         
* Create Date: 01/12/2020                                                                              *
* Date last modification : 01/12/2020                                                                  *
********************************************************************************************************/
namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4)
            {
                choice = Menu(choice);

                //  Thread.Sleep(500);
                //  Console.Clear();

                if (choice == 1)
                {
                    FixedTermDeposit();
                }
                else if (choice == 2)
                {
                    RegularSavingAccount();
                }
                else if (choice == 3)
                {
                    LoanRepayment();
                }
                else if (choice == 4)
                {
                    break;
                }
            }
        }
        public static int Menu(int choice)
        {
            const string TABLEMENU = "\t{0,-10}";

            Console.WriteLine("\n Financial Calculator Menu");
            Console.WriteLine(TABLEMENU, "1.Fixed Term Deposit");
            Console.WriteLine(TABLEMENU, "2.Regular Saving Account");
            Console.WriteLine(TABLEMENU, "3.Loan repayment");
            Console.WriteLine(TABLEMENU, "4.Exit");

            choice = int.Parse(Console.ReadLine());
            return choice;

        }
        private static void LoanRepayment()
        {
            //  n is the number of payments
            //  r is the rate of interest
            //  PV is the present value of the loan
            Console.WriteLine("Loan Repayment \n========\n");

            double pv, payment, r, totalpayment, totalr;
            int n;
            const int MONTHS = 12; 
            const string TABLEINPUT = "{0,-50}{1,-5}";
            const string TABLE_OUTPUT = "{0,-50}{1,-5}{2:c2}";

            Console.Write(TABLEINPUT, "Enter the number of payments", ":");
            n = int.Parse(Console.ReadLine());

            Console.Write(TABLEINPUT, "Enter the rate of interest", ":");
            r = double.Parse(Console.ReadLine());

            Console.Write(TABLEINPUT, "Enter the present value of the loan", ":");
            pv = double.Parse(Console.ReadLine());

            r = r / 100;

            payment = (pv * Math.Pow((r / MONTHS) + 1, (n)) * r / MONTHS)
                       / (Math.Pow(r / MONTHS + 1, (n)) - 1);

            totalpayment = payment * n;
            totalr = totalpayment - pv;



            Console.WriteLine(TABLE_OUTPUT, "Monthly payment", ":", payment);
            Console.WriteLine(TABLE_OUTPUT, "Total paid in interest", ":", totalr);
            Console.WriteLine(TABLE_OUTPUT, "Total loan paid", ":", totalpayment);

        }
        static void FixedTermDeposit()
        {

            double amount = 0, interestRate = 0, totalAmount = 0;
            int years = 0, numMonths, counter = 0, countYear = 1;

            const string TABLEINPUT   = " {0,-27}{1,-5}";
            const string TABLE_OUTPUT = " {0,-7}{1,3}{2,20:c2}";
            const string TABLE_HEADER = " {0,-7}{1,25}";
            const string space = "\n";
            const int MONTHS = 12;

            Console.Write(TABLEINPUT, "Enter sum amount", ":");
            amount = double.Parse(Console.ReadLine());
            Console.Write(TABLEINPUT, "Number of years", ":");
            years = int.Parse(Console.ReadLine());
            Console.Write(TABLEINPUT, "Interest rate", ":");
            interestRate = double.Parse(Console.ReadLine());

            Console.Write(space);

            numMonths = years * MONTHS;

            interestRate = interestRate / 100;

            Console.WriteLine(TABLE_HEADER, "Year", "Total Amount");

            while (counter < numMonths)
            {
                totalAmount = (amount * interestRate) + totalAmount;
                counter++;

                if (counter % 12 == 0) // every year 
                {
                    
                    Console.WriteLine(TABLE_OUTPUT,countYear,":", totalAmount);
                    

                    countYear++;
                }
            }

        }
        static void RegularSavingAccount()
        {
            double monthlyInvestment = 0, interestRate = 0, totalAmount = 0;
            int years, count = 0, numMonths = 0, countYear = 1;
            const int MONTHS = 12;

            const string TABLEINPUT =   " {0,-27}{1,-5}";
            const string TABLE_HEADER = " {0,-15}{1,25}";
            const string TABLE_OUTPUT = " {0,-15}{1,-15}{2,-15:c2}";
            

            Console.Write(TABLEINPUT,"Monthly Investment",":");
            monthlyInvestment = double.Parse(Console.ReadLine());

            Console.Write(TABLEINPUT,"Duration in years",":");
            years = int.Parse(Console.ReadLine());

            Console.Write(TABLEINPUT,"interest Rate",":");
            interestRate = double.Parse(Console.ReadLine());

            monthlyInvestment *= (MONTHS * years);

            numMonths = years * MONTHS;

            Console.WriteLine(TABLE_HEADER, "Year", "Total Amount");

            while (count < numMonths)
            {

                totalAmount = ((monthlyInvestment * interestRate) / 100) + totalAmount;

                if (count % 12 == 0)
                {
                    Console.WriteLine(TABLE_OUTPUT,countYear,":" ,totalAmount);

                    countYear++;
                }

                count++;
            }

        }

    }

}


