using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aray = new int[8];
            int i, arrayView;
            string exit;

            do
            {
               
                WriteLine("Please enter elements of an array for 8 integers. ");
                for (i = 0; i < 8; ++i)
                {
                    WriteLine("Please enter an integer. ");
                    aray[i] = Convert.ToInt32(ReadLine());
                }

                WriteLine("How would you like to see your array? ");
                WriteLine("   1 = Normal \n   2 = Reverse \n   3 = Specific ");
                arrayView = Convert.ToInt32(ReadLine());
                if (arrayView == 1)
                {
                    for (i = 0; i < 8; ++i)
                    {
                        WriteLine(aray[i]);
                    }
                }
                else if (arrayView == 2)
                {
                    for (i = 8; i > 0; --i)
                    {
                        WriteLine(aray[i]);
                    }
                }
                else if (arrayView == 3)
                {
                    WriteLine("Please select which element in the array you would like to view (0-7)");
                    arrayView = Convert.ToInt32(ReadLine());
                    WriteLine(aray[arrayView]);
                }
                else
                {
                    WriteLine("Error 404. Not a valid number. ");
                }

                WriteLine("Would you like to exit? \n If yeas please enter a '!'");
                exit = ReadLine();
                if(exit == "!")
                {
                    //do nothing and it will exit the loop
                }
                else
                {
                    // do nothing to continue the loop
                }

            } while (exit != "!");


            WriteLine("BYE. ");
        }
    }
}
