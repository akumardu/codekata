using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Codewar
{
    public class LongestConsecutives
    {

        public static String LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0 || (k <= 0) || (k> strarr.Length))
                return "";
            int max_sum = 0;
            int beginning_index = 0;
            for (int current_beginning_index = 0; current_beginning_index < strarr.Length; current_beginning_index++)
            {
                int currentSum = 0;
                for (int j = current_beginning_index; j < current_beginning_index + k && j < strarr.Length; j++)
                {
                    currentSum = currentSum + strarr[j].Length;
                }

                if (currentSum > max_sum)
                {
                    max_sum = currentSum;
                    beginning_index = current_beginning_index;
                }
            }

            string result = "";
            for (int i = beginning_index; i < beginning_index + k; i++)
            {
                result = result + strarr[i];
            }
            return result;
        }

        public static void testLongestConsec()
        {
            string result = LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2);
            Console.WriteLine(result);
        }
    }
}
