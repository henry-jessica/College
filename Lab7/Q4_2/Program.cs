using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Declarate
            string userName;
            double lawnsNum, lawnMeter;
            double fertiliser50lt, seed25kg, totalmeters, amountFertiliser50lt, amountSeed25kg, amountHoursWorked, vatSeed = 0, vatFertiliser = 0, vatWorker = 0, totalLawn = 0, totalWorked = 0, totalCostJob = 0, discountRate, totalDis, MountCharge = 0;

            fertiliser50lt = seed25kg = totalmeters = amountFertiliser50lt = amountSeed25kg = amountHoursWorked = 0;


            const double VAT = 0.20;
            const double VAT_LABOUR = 0.15;
            const string TABLE_FORM_MONEY = "{0,-51}{1,-5}{2,-5:c2}";
            const string TABLE_FORM_PER = "{0,-51}{1,-5}{2,-5:p2}";
            const string TABLE = "{0,-51}{1,-5}";
            const string TABLE_2 = "{0,-51}{1,-5}{2,-5}";
            const string Space = "------------------------------------------------------------------";

            //input
            Console.Write(TABLE, "The customer name", ":");
            userName = Console.ReadLine();

            Console.Write(TABLE, "The number of lawns that are to be laid", ":");
            lawnsNum = int.Parse(Console.ReadLine());

            Console.Write(TABLE, "The square meters of each lawn", ":");
            lawnMeter = double.Parse(Console.ReadLine());

            Console.Write(TABLE, "The price, before tax of 50lt of fertiliser", ":");
            fertiliser50lt = double.Parse(Console.ReadLine());

            Console.Write(TABLE, "The price, before tax of one 25kg bag of lawn seed", ":");
            seed25kg = double.Parse(Console.ReadLine());

            totalmeters = (double)lawnMeter / 25;


            if (totalmeters != 0)
            {
                amountFertiliser50lt = (totalmeters * fertiliser50lt) * lawnsNum;
                amountSeed25kg = (totalmeters * (2 * seed25kg)) * lawnsNum;
                amountHoursWorked = (totalmeters * (5 * 25) * lawnsNum);
                vatSeed = amountSeed25kg * VAT;
                vatFertiliser = amountFertiliser50lt * VAT;
                vatWorker = amountHoursWorked * VAT_LABOUR;
                totalLawn = amountFertiliser50lt + amountSeed25kg + vatSeed + vatFertiliser;
                totalWorked = vatWorker + amountHoursWorked;

            }
            totalCostJob = totalLawn + totalWorked;

            if (totalCostJob >= 5000)
            {
                discountRate = 0.08;
                totalDis = (totalCostJob * discountRate);
                MountCharge = totalCostJob - totalDis;
            }
            else if (totalCostJob >= 1000 && totalCostJob < 5000)
            {
                discountRate = 0.05;
                totalDis = (totalCostJob * discountRate);
                MountCharge = totalCostJob - totalDis;

            }
            else
            {
                discountRate = 0;
                totalDis = 0;
                MountCharge = totalCostJob;

            }

            // output
            Console.WriteLine(TABLE_2, "Total numbers of lawns", ":", lawnsNum);
            Console.WriteLine(TABLE_FORM_MONEY, "Cost of 50 l of Fertiliser", ":", fertiliser50lt);
            Console.WriteLine(TABLE_FORM_MONEY, "Cost of one 25kg bag", ":", seed25kg);
            Console.WriteLine("");
            Console.WriteLine(TABLE_FORM_MONEY, "Cost of festilezer", ":", amountFertiliser50lt);
            Console.WriteLine(TABLE_FORM_MONEY, "Cost of festilezer VAT", ":", vatFertiliser);
            Console.WriteLine(TABLE_FORM_MONEY, "Cost of Seed", ":", amountSeed25kg);
            Console.WriteLine(TABLE_FORM_MONEY, "Cost of Seed VAT", ":", vatSeed);
            Console.WriteLine(TABLE_FORM_MONEY, "Total Lawn Cost", ":", totalLawn);
            Console.WriteLine(Space);

            Console.WriteLine(TABLE_FORM_MONEY, "Cost of Seed", ":", amountHoursWorked);
            Console.WriteLine(TABLE_FORM_MONEY, "Cost of Seed VAT", ":", vatWorker);
            Console.WriteLine(TABLE_FORM_MONEY, "Total Lawn Cost", ":", totalWorked);

            Console.WriteLine(Space);

            Console.WriteLine(TABLE_FORM_MONEY, "Total Cost of Job", ":", totalCostJob);
            Console.WriteLine(TABLE_FORM_PER, "Discount", ":", discountRate);
            Console.WriteLine(TABLE_FORM_MONEY, "Discount Value", ":", totalDis);
            Console.WriteLine(TABLE_FORM_MONEY, "Nett Cost", ":", MountCharge);



            Console.ReadKey();
        }
    }
}
