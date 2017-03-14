using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class JollyJumper
    {
        public static bool isJolly(int[] array)
        {
            int n = array.Length;
            List<bool> list = new List<bool>();
            for (int i = 0; i <n; i++)
            {
                list.Add(false);
            }
            for (int i = 0; i < n - 1; i++)
            {
                int difference = Math.Abs(array[i] - array[i + 1]);

                if (difference == 0 || difference > n - 1 || list[difference] == true)
                    return false;

                else
                    list[difference] = true;
            }
            return true;
        }
        public static void testIsJolly()
        {
            int[] input = { 1, 4, 2, -1, 6 };
            int[] input2 = { 11,7,4,2,1,6 };
            bool result = isJolly(input);
            bool result2 = isJolly(input2);
            Console.Write(result + " ");
            Console.WriteLine(result2 + " ");
        }
    }
}
