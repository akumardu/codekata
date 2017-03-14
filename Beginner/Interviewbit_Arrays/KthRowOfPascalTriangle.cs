using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class KthRowOfPascalTriangle
    {
        public static int[] kthRow(int k)
        {
            int[] previous = new int[k];
            int[] current = new int[k];
            previous[0] = 1;
            for (int line = 1; line < k; line++)
            {
                for (int i = 0; i <= line; i++)
                {
                    if (line == i || i == 0)
                    {
                        current[i] = 1;
                    }
                    else
                    {
                        current[i] = previous[i - 1] + previous[i];
                    }
                }
                var temp = previous;
                previous = current;
                current = temp;
            }
            return previous;
        }

        public static void testkthRow()
        {
            int k = 5;
            int[] result = kthRow(k);
            for (int i = 0; i < k; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
