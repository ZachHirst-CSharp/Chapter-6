using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights, i = 0, total = 0;
            int[] nightprice = { 0, 200, 200, 180, 180, 160, 160, 160, 145 };

            WriteLine("Welcome to The CareFree Resort. \n");
           
            WriteLine("How many nights would you like to stay? ");
            nights = Convert.ToInt32(ReadLine());

            if (nights < 8 )
            {
                total += nightprice[nights] * nights;

            }
            else if(nights >= 8)
            {
                total += nightprice[8] * nights;
            }
            

            WriteLine();
            WriteLine("Here are our nightly rates.");
            WriteLine("________________________________");
            for (i = 0; i < 9; ++i)
            {
                if (i < 8)
                {
                    WriteLine("The price for " + i + " night(s) is $" + nightprice[i]);
                }
                else
                {
                    WriteLine("The price for 8 nights or more is $" + nightprice[7]);
                }

            }

           
            WriteLine("\n _________________________________");
            WriteLine("Your total for " + nights + " nights stayed is " + total.ToString("C"));
        }
    }
}
