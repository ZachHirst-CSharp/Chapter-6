using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SavingIntoAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Write("\n \n Read and Print elements of an array. ");
            Write("___________________________________________");
            WriteLine("Input 10 elements in the array. ");

            for (i = 0; i < 10; ++i)
            {
                Write("Enter a number - " + i + " << ");
                arr[i] = Convert.ToInt32(ReadLine());
            }

            for(int j = 0; j < arr.Length; ++j)
            {
                WriteLine("" + arr[j]);
            }
        }
    }
}
