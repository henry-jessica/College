using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            double loanAmount, salary, maxLoan;
            int yearJob;
            loanAmount = salary = yearJob = 0;
            string choice = "";

            do
            {
                try
                {
                    Console.Write("Enter Loan amount : ");
                    loanAmount = double.Parse(Console.ReadLine());

                    Console.Write("Enter Salary : ");
                    salary = double.Parse(Console.ReadLine());

                    Console.Write("Enter year in job: ");
                    yearJob = int.Parse(Console.ReadLine());


                    maxLoan = loanAmount * 5;

                    if (maxLoan < salary && yearJob > 2)
                    {

                        Console.WriteLine("Congratulations , you qualify for the loan: ");
                    }
                    else
                    {
                        Console.WriteLine("Sorry , you are not in your current job long enough");
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Would you like to do it again?\n 1 - Yes    2 - No");
                    choice = Console.ReadLine();
                }
                catch
                {
                    Console.Write("Value not authorized! Try again.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

            } while (choice != "2");
        }
    }
}
