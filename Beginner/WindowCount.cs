using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class WindowCount
    {
        public static void Count(int[] array, int k)
        {
            int n = array.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < k; i++)
            {
                if (!dict.ContainsKey(array[i]))
                {
                    dict.Add(array[i], 1);
                }
                else
                {
                    dict[array[i]]++;
                }
            }
            Console.WriteLine("window count: " + dict.Count);
            for (int i = 0; i+k < n; i++)
            {
                dict[array[i]]--;
                if (dict[array[i]] == 0)
                    dict.Remove(array[i]);

                if (!dict.ContainsKey(array[i + k]))
                {
                    dict.Add(array[i + k], 1);
                }
                else
                {
                    dict[array[i + k]]++;
                }
                Console.WriteLine("window count: " + dict.Count);
            }
        }
        public static void testCount()
        {
            int[] input = { 1, 2, 1, 3, 4, 2, 3 };
            Count(input, 4);
        }
    }
}
