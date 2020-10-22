using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0, seconds = 0, hours = 0, minutes = 0;

            Console.Write("Enter seconds: ");
            time = int.Parse(Console.ReadLine());


            hours = (time / 3600);

            minutes = time % 3600 / 60;

            seconds = time % 60;

            Console.WriteLine("{0} seconds is equal to {1} hours, {2} minutes and {3} seconds", time, hours, minutes, seconds);


            Console.ReadKey();
        }
    }
}
