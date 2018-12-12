using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipcodes = {52801, 52802, 52803, 52804, 52805, 52806, 52807, 52808, 52809, 52810};
            int input;
            int i = 0;
            bool wrong = true;

            WriteLine("Please enter the desired zip code you would like to ship too. ");
            input = Convert.ToInt32(ReadLine());

            while(i < 10)
            {
                if(input == zipcodes[i])
                {
                    wrong = false;
                    WriteLine("You are in our delivery area. ");
                }
                else
                {

                }
                ++i;
            }

            if(wrong == false)
            {

            }
            else if(wrong == true)
            {
                WriteLine("I'm sorry you're not in our area of delivery. ");
            }
        }
    }
}
