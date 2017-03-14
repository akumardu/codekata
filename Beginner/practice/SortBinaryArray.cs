using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class SortBinaryArray
    {
        public static void SortBinary(int[] input)
        {
            int size = input.Length;
            int i = 0, j = size - 1;
            while (i < j)
            {
                while (i < size && input[i] == 0)
                    i++;
                while (j >= 0 && input[j] == 1)
                    j--;
                if (i < j)
                {
                    input[i] = 0;
                    input[j] = 1;
                    i++;
                    j--;
                }
            }
        }
        public static void testSortBinary()
        {
            int[] input = { 1, 0, 1, 0, 1, 0, 1 };
            Console.WriteLine("the sorted array is");
            SortBinary(input);
            for (int i = 0; i < input.Length; i++)
                Console.WriteLine(input[i]);
        }
    }
}
