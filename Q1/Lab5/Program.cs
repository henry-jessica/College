using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8; 

            Console.WriteLine("My hourly rate is {0:c}", 22.5);
            Console.WriteLine("My name is {0} and hourly rate is {1:c}”, “frank", 22.5);



            Console.ReadKey();
        }
    }
}
