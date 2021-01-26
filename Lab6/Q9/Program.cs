using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            double userBankBalance, amountWithdraw;
            int userPin, inputPin, choice = 1;

            userBankBalance = 550.35;
            userPin = 1234;

            do
            {
                Thread.Sleep(1000);
                Console.Clear();


                Console.Write("Amount you wish to withdraw: ");
                amountWithdraw = double.Parse(Console.ReadLine());

                Console.Write("Enter your PIN : ");
                inputPin = int.Parse(Console.ReadLine());


                if (inputPin == userPin)
                {
                    if (userBankBalance <= amountWithdraw)
                    {
                        Console.WriteLine("Insufficient Funds");

                        userBankBalance = userBankBalance - amountWithdraw;
                    }
                    else
                    {
                        Console.WriteLine("Wait the money comes out!");
                    }

                }
                else
                {
                    Console.WriteLine("invalid pin! Try again");
                }

                Console.WriteLine("\n\tWould like to make another transaction? \n\t Yes - 1     No - 2");
                choice = int.Parse(Console.ReadLine());

            } while (choice == 1);

        }
    }
}
