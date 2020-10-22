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

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine(" {0:c}", 1547.20);
            Console.WriteLine(" {0:p0}", 0.23);
            Console.WriteLine(" {0:c0}", 15000);
            Console.WriteLine(" {0:F3}", 432.8175);
            Console.WriteLine(" {0:E2}", 300000);

            Console.ReadKey();

        }
    }
}


