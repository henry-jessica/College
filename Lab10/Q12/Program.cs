using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            string examGrade = "";
            double examScore = 0;


            Console.Write("Enter exam score: ");
            examScore = double.Parse(Console.ReadLine());

            examGrade = Grade(examScore);

            PrintGrade(examGrade);


            Console.ReadKey();

        }
        static private string Grade(double score)
        {

            string grade = " ";

            if (score >= 0 && score < 40)
            {
                grade = "F";
            }
            else if (score > 39 && score < 60)
            {
                grade = "C";
            }
            else if (score > 59 && score < 80)
            {
                grade = "B";
            }
            else if (score > 79 && score <= 100)
            {
                grade = "A";
            }
            else
            {
                grade = "Error";
            }


            return grade;
        }

        static private void PrintGrade(string grade)
        {

            Console.WriteLine("Your Grade is {0}", grade);
        }
    }
}


