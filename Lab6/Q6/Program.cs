using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName, studentTown;


            Console.Write("Enter Student Name: ");
            studentName = Convert.ToString(Console.ReadLine());

            Console.Write("Enter Student Town of Residence: ");
            studentTown = Console.ReadLine();
            studentTown = studentTown.ToUpper();

            if (studentTown == "BOYLE" || studentTown == "CARRICK ON SHANNON" || studentTown == "COLOONEY")
            {
                Console.WriteLine("The  student is in a carpooling town");
            }
            else
            {
                Console.WriteLine("The  student is not in a carpooling town");
            }

            Console.ReadKey();
        }


    }

}

