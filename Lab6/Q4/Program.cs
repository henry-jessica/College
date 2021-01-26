using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            int duration, cost, costMinute, myAreaCode, calledArea;
            duration = cost = costMinute = myAreaCode = calledArea = 0;

            while (choice != "1")
                try
                {
                    Console.Write("Enter customer area code: ");
                    myAreaCode = int.Parse(Console.ReadLine());

                    Console.Write("Enter called area code: ");
                    calledArea = int.Parse(Console.ReadLine());
    
                Console.Write("Enter call time in minutes: ");
                    duration = int.Parse(Console.ReadLine());

                    const string TABLE = "\nMy area code = {0}, called area = {1}, duration = {2}  => cost = {3}";

                    if (myAreaCode != calledArea || duration > 21)
                    {
                        costMinute = 13;
                        cost = duration * costMinute;
                        Console.WriteLine(TABLE, myAreaCode, calledArea, duration, cost);
                    }
                    else
                    {
                        cost = duration * 1;
                        Console.WriteLine(TABLE, myAreaCode, calledArea, duration, cost);
                    }

                    Console.WriteLine("Exit \n 1 - Yes    2 - No");
                    choice = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Value not autorizaded! Please try again");
                    Thread.Sleep(1500);
                    Console.Clear();
                    continue;
                }

      
        }
    }
}
