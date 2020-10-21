using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************************************
 * Author: Jessica Henry                                                                                *  
 * IntroTo                                                                                              *
 * Q2 - Create a new project called Lab2Q2, then write the c# code to display a verse of your favourite *
 * song.                                                                                                *
 * Date: 06/10/2020                                                                                     *
 * Modi: 08/10/2020                                                                                     *
 ********************************************************************************************************/

namespace Lab2Q2
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" My eyelids are starting to get a little bit heavy \n " +
                                "But I don't wanna sleep tonight \n " +
                                "And I'm trying to stay awake \n " +
                                "But my body feels so weak \n " +
                                "(It happens to me everytime \n " +
                                "As I lay here tonight on this bed all alone \n " +
                                "I'll try to convience myself that \n " +
                                "I don't miss you at all.\n " +
                                "But everytime the lights turn off \n " +
                                "The lights turn off \n " +
                                "I've got to face the truth \r\n ");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(" That I'll see you in my dreams \n " +
                                  "(All night long)");

            }
            Console.ReadKey();

        }
    }
}
