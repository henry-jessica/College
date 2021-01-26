using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //declare
            int numRooms = 0;
            double costTile = 0, areaWall, areaCeiling, areaFloor, costTotal, costFloor = 0, costCeilling, costWalls, vat, vatPercentagem = 0, costTotalroom;
            const double length = 5.1, width = 3.9, height = 3.0, doorArea = 2.5;


            Console.Write("Number of rooms                         : ");
            numRooms = int.Parse(Console.ReadLine());

            Console.Write("Cost per square meter to tile the floor : ");
            costTile = double.Parse(Console.ReadLine());



            areaWall = ((2 * (length + width)) * height) - doorArea;
            areaCeiling = (length * width);
            areaFloor = (length * width);

            /*areaWall = areaWall * numRooms;
            areaCeiling = areaCeiling * numRooms;
            areaFloor = areaFloor * numRooms;
            */

            const string TABLE_FORM_EURO = "{0,-30}{1,10}{2,40:c2}";
            const string TABLE_FORM =      "{0,-30}{1,10}{2,40}";
            const string TABLE_FORM_PER =  "{0,-30}{1,10}{2,40:c2}";
           
            costWalls = areaWall * costTile;
            costFloor = areaFloor * costTile;
            costCeilling = areaCeiling * costTile;

            costTotal = ((areaFloor + areaCeiling + areaWall) * costTile);

            costTotalroom = costTotal * 4;

            if (costTotal < 500)
            {
                vatPercentagem = .01;
                vat = costTotal * vatPercentagem;
            }
            else if (costTotal >= 500 && costTotal <= 900)
            {
                vatPercentagem = .025;
                vat = costTotal * vatPercentagem;
            }
            else if (costTotal > 900 && costTotal <= 1100)
            {
                vatPercentagem = .075;
                vat = costTotal * vatPercentagem;
            }
            else
            {
                vatPercentagem = .085;
                vat = costTotal * vatPercentagem;
            }

            Console.WriteLine(TABLE_FORM_EURO, "Title Cost per meter square", ":", costTile);
            Console.WriteLine(TABLE_FORM, "Celling area is ", ":", areaCeiling);

            Console.WriteLine(TABLE_FORM, "Wall area is ", ":", areaWall);
            Console.WriteLine(TABLE_FORM,"","","================");
            Console.WriteLine(TABLE_FORM_EURO, "Cost to tiles Floor", ":", costWalls);
            Console.WriteLine(TABLE_FORM_EURO, "Celling area is ", ":", costCeilling);
            Console.WriteLine(TABLE_FORM, "", "", "================");
            Console.WriteLine(TABLE_FORM_EURO, "Total of Cost", ":", costTotal);
            Console.WriteLine(TABLE_FORM_PER, "VAT Percentage ", ":", vatPercentagem);
            Console.WriteLine(TABLE_FORM, "Vat Cost", ":", vat);
            Console.WriteLine(TABLE_FORM, "", "", "================");
            Console.WriteLine(TABLE_FORM, "Total of Cost", ":", costTotal);
            Console.WriteLine(TABLE_FORM, "Total of all rooms ", ":", costTotalroom);
            Console.WriteLine(TABLE_FORM, "", "", "================");


            Console.ReadKey();
        }
    }
}
