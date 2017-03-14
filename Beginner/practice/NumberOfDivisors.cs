using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class NumberOfDivisors
    {
        public static int divisors(int[] array, int k)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % k) > 0)
                {
                    sum = sum + 1;
                }
                sum = sum + (array[i] / k);
            }
            return sum;
        }
        public static void testDivisors()
        {
            int[] input = {5,8,10,13,6,2};
            int count = divisors(input,3);
            Console.WriteLine(count);
        }
    }
}
