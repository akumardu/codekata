using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class Surpasser
    {
        public static void surpasser(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                        count++;
                }
                Console.Write(count + " ");
            }
        }
        public static void testSurpasser()
        {
            int[] input = {2,7,5,3,0,8,1 };
            surpasser(input);
        }
    }
}
