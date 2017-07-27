using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
   public static class Utility
    {
        public static int[] ReadArrayFromConsole()
        {
            Console.WriteLine("enter the size of array");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
                a[i] = int.Parse(Console.ReadLine());
            return a;
        }
        public static void WriteArrayToConsole(this int[] input, int numberOfItems = Int32.MaxValue)
        {
            for (int i = 0; i < input.Length && i < numberOfItems; i++)
                Console.Write(input[i] + " ");
            //Console.WriteLine();
        }

    }
}
