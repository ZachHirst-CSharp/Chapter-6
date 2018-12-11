using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, input;
            const int MAX = 100, MIN = 0;
            int[] array = new int[4];

            for (i = 0; i < 4; ++i)
            {
               
                WriteLine("Please enter a test score for the computer. ");
                input = Convert.ToInt32(ReadLine());

                if (input >= MIN && input <= MAX)
                {
                    array[i] = input;
                    WriteLine(" Test score " + i);
                }
                else 
                {
                    WriteLine("Please enter an acceptable score. ");
                    --i;
                }
            }

            if(array[0] <= array[1] && array[1] <= array[2] && array[2] <= array[3])
            {
                WriteLine("Congratulations on the improvement. ");
                for (i = 0; i < 4; ++i)
                {
                    WriteLine(array[i]);
                }
            }
            else if(array[0] >= array[1] && array[1] >= array[2] && array[2] >= array[3])
            {
                WriteLine("OOOO These scores don't look good... ");
                for (i = 0; i < 4; ++i)
                {
                    WriteLine(array[i]);
                }
                WriteLine("Let me make this look like more of an improvement. ");
                for (i = 3; i >= 0; --i)
                {
                    WriteLine(array[i]);
                }
            }
            else
            {
                WriteLine("Your scores are all over the place.. What are you doing? ");
            }
        }
    }
}
