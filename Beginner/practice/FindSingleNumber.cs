using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
   // http://www.practice.geeksforgeeks.org/problem-page.php?pid=836
    class FindSingleNumber
    {
        public static int NonRepeatingNumber(int[] array)
        {
            int number = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                number = number ^ array[i];
            }
            return number;
        }
        public static void testNonRepeatingNumber()
        {
            int[] input = { 1,2,2,3,4,5,6,6,7,1,3,5,4 };
            int number = NonRepeatingNumber(input);
            Console.Write("the missing number is " + number);
        }
    }
}
