using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountDue, amountReceived, rest;
            int oneCent, twoCents, fiveCents, tenCents, twentCents, fifitycents, oneeuro, twoeuros;

            Console.Write("Enter amount due: ");
            amountDue = int.Parse(Console.ReadLine());

            Console.Write("Enter amount received: ");
            amountReceived = int.Parse(Console.ReadLine());

            rest = amountReceived - amountDue;

            rest = rest * 100;

            //2 euros
            twoeuros = rest / 200;

            //1 euro
            oneeuro = rest % 200 / 100;

            //50 cents
            fifitycents = rest % 100 / 50;

            //20 cents
            twentCents = rest % 50 / 20;

            //10 cents 
            tenCents = rest % 20 / 10;

            // 5 cents 
            fiveCents = rest % 5 / 5;

            // 2 cents 
            twoCents = rest % 5 / 2;

            //1 cent 
            oneCent = rest % 2 / 1;

            Console.WriteLine(" {0}, {1}, {2}, {3} , {4} , {5}, {6} , {7}  ", twoeuros, oneeuro, fifitycents, twentCents, tenCents, fiveCents, twoCents, oneCent);
             
            Console.ReadKey();

        }
    }
}

/*Implement a program that directs a cashier to give change.  
 The program has two inputs: the amount due and the amount received from the customer. 
 Display the euros, fifties, twenties, tens, fives, twos and cents that the customer should receive in return. 
 (Assume highest coin/note is a Euro)

For example, for change of €1.98

1 Euro,1 Fifty,2 Twenties,1 Five, 1 Two1 cent

    coins: 1 cent
           2 cents 
           5 cents 
           10 cents 
           20 cents 
           50 cents 
           1 euro 
           2 euros 


 */
