using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TemperatureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tempArray = new int[7];
            double avg = 0;
            int tick = 0;

            for (int i = 0; i < 7; ++i)
            {
                WriteLine("Please enter the high temperatures for the past seven days. ");
                tempArray[i] = Convert.ToInt32(ReadLine());
            }

            avg = tempArray.Sum() / 7;
            int sum = tempArray.Sum();
          

            WriteLine("The sum of the array is " + sum + "\nWhile the average number of the array is " + avg);

            for(int i = 0; i < 7; ++i)
            {
               
                ++tick;

                WriteLine("The tempurature on day " + tick + " is " + Math.Abs(tempArray[i] - avg) + " degrees away from the average. ");
            }
        }
    }
}
