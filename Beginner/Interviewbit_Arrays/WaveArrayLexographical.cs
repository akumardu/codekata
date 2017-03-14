using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class WaveArrayLexographical
    {
        //https://gist.github.com/cruxrebels/2d6c2a74ecca2a8014ee9acfad15d2ca

        public static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        public static void waveLexographical(int[] array)
        {
            int n = array.Length;
            Array.Sort(array);
            for (int i = 0; i < n - 1; i += 2)
            {
                swap(ref array[i], ref array[i + 1]);
            }
        }
        public static void testWaveLexographical()
        {
            int[] input = { 10, 5, 6, 3, 2, 20, 100, 80 };
            waveLexographical(input);
            for (int i = 0; i < input.Length; i++)
                Console.Write(input[i] + " ");
        }

    }
}
