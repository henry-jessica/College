using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variaveis
            string userName, airCode;
            int userAge;

            Console.Write("Enter name : ");
            userName = Console.ReadLine();

            Console.Write("Enter AirCode : ");
            airCode = Console.ReadLine();

            Console.Write("Enter your Age : ");
            userAge = int.Parse(Console.ReadLine());


            Console.WriteLine("Hello " + userName + " From " + airCode);
            Console.WriteLine("You are " + userAge + " Yars Old");


            Console.ReadKey();
        }
    }
}
