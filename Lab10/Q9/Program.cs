using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*******************************************************************************************************
* Author: Jessica Henry                                                                                *  
* 9.Packages containing 6, 9 or 20 pieces                                                              *                             
*------------------------------------------------------------------------------------------------------*             
* Create Date: 02/12/2020                                                                              *
* Date last modification : 02/12/2020                                                                  *
********************************************************************************************************/
namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool package = true;

            Console.Write(" Enter num nuggets at McDonalds ");
            num = int.Parse(Console.ReadLine());

            package = CheckOrder(num);


            if (package == true)
            {
                Console.WriteLine(" Valid Order ");
            }
            else
            {
                Console.WriteLine(" Invalid Order ");

            }

        }

        static bool CheckOrder(int OrderQuantity)
        {
            bool package;

            if (OrderQuantity == 6 || OrderQuantity == 9 || OrderQuantity == 20)
            {
                package = true;
            }
            else
            {
                package = false;
            }

            return package;
        }


    }

}
