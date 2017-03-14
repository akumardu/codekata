using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class ChocolateDistribution
    {
        public static int minimumDifference(int[] arr, int packets, int students)
        {
            int n = arr.Length;
            int min_difference = int.MaxValue;
            int first = 0;
            int last = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n -2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            if (students == 0 || packets == 0)
                return 0;
            if (students > packets)
                return -1;

            for (int k = 0; k + students - 1 < n; k++)
            {
                int diff = arr[k + students - 1] - arr[k];
                if (diff < min_difference)
                {
                    min_difference = diff;
                    first = arr[k];
                    last = arr[k + students - 1];
                }
            }
            return arr[last] - arr[first];
        }
        public static void testMinimumDifference()
        {
            int[] input = {12, 4, 7, 9, 2, 23, 25, 41,
                 30, 40, 28, 42, 30, 44, 48,
                 43, 50};
            int result = minimumDifference(input, input.Length, 7);
            Console.WriteLine(result);
        }
    }
}
