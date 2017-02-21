using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner

{
    //http://cseinterviewquestions2016.blogspot.com/2016/12/find-number-of-numbers.html
    class CountNumberOfRepeatingDigits
    {
        public static int numberOfDigits(int [] array, int k)
        {
            int n = array.Length;
            int r, count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == 0 && k == 0)
                    count++;
                while (array[i] > 0)
                {
                    r = array[i] % 10;
                    if (r == k)
                        count++;
                    array[i] = array[i] / 10;
                }
            
            }
            return count;
        }
        public static void testNumberOfDigits()
        {
            int[] input = {11,12,13,14,15,16 };
            Console.WriteLine("enter the value of k");
            int k = int.Parse(Console.ReadLine());
            int count = numberOfDigits(input, k);
            Console.WriteLine(count);
        }
    }
}
