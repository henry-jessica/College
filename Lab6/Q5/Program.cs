using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vArray = new int[3];
            int[] numArray = new int[3];
            int match = 0;
            string choice = "";

            Random rnd = new Random();

            while (choice != "2")
            {

                Console.Clear();

                for (int i = 0; i < 3; i++)
                {
                    numArray[i] = rnd.Next(9);

                    Console.Write("Enter number: ");
                    vArray[i] = int.Parse(Console.ReadLine());

                }
                for (int i = 0; i < numArray.Length; i++)
                {
                    for (int j = 0; j < vArray.Length; j++)
                    {
                        if (numArray[i] == vArray[j])
                        {
                            match++;
                        }

                    }

                }

                Console.WriteLine("\n\n Three Winning Numbers");

                for (int k = 0; k < numArray.Length; k++)
                {
                    Console.Write(" | " + numArray[k]);

                }

                Console.WriteLine("\n\n Total Numbers Matched  " + match);
                Console.WriteLine("\n Guy's Money ");

                switch (match)
                {
                    case 1:
                        Console.WriteLine(" 10");
                        break;

                    case 2:
                        Console.WriteLine(" 100");
                        break;

                    case 3:
                        Console.WriteLine(" 1000");
                        break;
                }

                Console.WriteLine("\n\n Play Again? \n 1 - Yes    2 - No");
                choice = Console.ReadLine();
            }

        }
    }
}

