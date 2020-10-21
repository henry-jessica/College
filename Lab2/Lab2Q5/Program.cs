using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * IntroTo                                                                                              *
 * Q4B - Using variables to store all data, write a program to calculate hourly wages plus overtime.    * 
 * Base hourly rate is 25, regular hours is 40, overtime rate is 37.5 and overtime hours is 10          *                                                              
 * -----------------------------------------------------------------------------------------------------*
 * Date: 06/10/2020                                                                                     *
 * Modi: 08/10/2020                                                                                     *
 ********************************************************************************************************/

namespace Lab2Q4_B
{
    class Program
    {
        static void Main(string[] args)
        {
            double  BasehourlyRate = 0;
            int     regularHours = 0;
            double  overTimeHoursRate = 0;
            int  overtimeHours = 0;
            double totalregulartimerate = 0;
            double totalOvertimeRate = 0;
            double totalpayroll = 0;

            BasehourlyRate = 25;
            regularHours = 40;
            overTimeHoursRate = 37.5;
            overtimeHours = 10;

            totalregulartimerate = BasehourlyRate * regularHours;
            totalOvertimeRate = overTimeHoursRate * overtimeHours;

            
            totalpayroll = totalregulartimerate + overtimeHours;
            Console.WriteLine("Total week Payroll " + totalpayroll);


            Console.ReadKey();
        }
    }
}
