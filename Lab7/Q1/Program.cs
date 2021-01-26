using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int movieNum = 0;
            // int userAge = 0;
            Boolean ValidInput = true;
            string msgOk = "OK you are permited to view";
            string msgAgeDeny = "Access denied – you are too young";
            //string msgMovieDeny = "Movie doenst exciste";

            Console.WriteLine("\nWelcome to our Sligo Multiplex");
            Console.WriteLine("\nWe are presently showing:");
            Console.WriteLine("\t1.Made in Dagenham(15)");
            Console.WriteLine("\t2.Buried(18)");
            Console.WriteLine("\t3.Despicable Me(U)");
            Console.WriteLine("\t4.The Other Guys(12A)");
            Console.WriteLine("\t5.Takers(12A)");
            Console.WriteLine("\tEnter the number of the film you wish to see: 1");
            Console.WriteLine("\tEnter your age: 12");
            Console.WriteLine("\tAccess denied – you are too young");


            Console.Write("Enter the number of the film you wish to see : ");
            //movieNum = int.Parse(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out int movieNum))
            {
                if (movieNum >= 1 && movieNum <= 5)
                {
                    ValidInput = true;
                }
                else
                {
                    ValidInput = false;
                }
            }
            else
            {
                ValidInput = false;
                Console.WriteLine("\nInvalid Input");
            }
            Console.Write("Enter your age                               : ");
            // userAge = int.Parse(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out int userAge))
            {
                if (userAge > 0 && userAge < 115)
                {
                    ValidInput = true;
                }
                else
                {
                    ValidInput = false;
                    Console.WriteLine("\nInvalid Input");
                }
            }
            if (ValidInput)
            {
                if (userAge < 12)
                {
                    if (movieNum == 3)
                    {
                        Console.WriteLine(msgOk);
                    }
                    else
                    {
                        Console.WriteLine(msgAgeDeny);
                    }
                }

                else if (userAge < 15)
                {
                    if (movieNum == 3)
                    {
                        Console.WriteLine(msgOk);
                    }
                    else
                    {
                        Console.WriteLine(msgAgeDeny);
                    }
                }

                else if (userAge < 18)
                {
                    if (movieNum != 2)
                    {
                        Console.WriteLine(msgOk);
                    }
                    else
                    {
                        Console.WriteLine(msgAgeDeny);
                    }
                }

            }
            else
            {
                Console.WriteLine(msgOk);
            }

            Console.ReadKey();
        }
    }
}
