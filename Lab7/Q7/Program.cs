using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            //double potatoWeight;
            Boolean ValidInput = true;

            Console.Write("Enter the Weight of the Potato in gms: ");
            //potatoWeight = double.Parse(Console.ReadLine());

            if (double.TryParse(Console.ReadLine(), out double potatoWeight))
            {

                if (potatoWeight > 0)
                {
                    ValidInput = true;
                }
                else
                {
                    ValidInput = false;

                }

            }

            if (ValidInput == true)
            {
                if (potatoWeight >= 200 && potatoWeight < 400)
                {
                    Console.WriteLine("Grade A");
                }

                else if (potatoWeight >= 400 && potatoWeight < 800)
                {
                    Console.WriteLine("Grade B");
                }
                else if (potatoWeight >= 800)
                {
                    Console.WriteLine("Grade Z");
                }
                else
                {
                    Console.WriteLine("Grade X");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid Input, Potato grams have to be more than 0! ");
            }

            Console.ReadKey();
        }
    }
}

