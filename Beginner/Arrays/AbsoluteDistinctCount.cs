using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Arrays
{
    class AbsoluteDistinctCount
    {
        public static int absoluteCount(int[] array)
        {
            int n = array.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                if (!dict.ContainsKey(Math.Abs(array[i])))
                {
                    dict.Add(Math.Abs(array[i]), 1);
                    
                }
                else
                {
                    dict[Math.Abs(array[i])]++;
                }
            }
            return dict.Count;
         }

        public static int absoluteDistinctModified(int[] array)
        {
            int n = array.Length;
            int count = n;
            int i = 0, j = n - 1;
            int sum = 0;
            while (i < j)
            {
                while (i!=j && array[i] == array[i + 1])
                {
                    i++;
                    count--;
                }
                while (i!=j && array[j] == array[j - 1])
                {
                    j--;
                    count--;
                }
                if (i == j)
                    break;

                sum = array[i] + array[j];
                if (sum == 0)
                {
                    i++;
                    j--;
                    count--;
                }
                else if (sum < 0)
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return count;
        }
        public static void testAbsolutecount()
        {

            int []array = { 1, 1, 1, 1 };
            int output = absoluteCount(array);
            int result = absoluteDistinctModified(array);
            Console.WriteLine(output + "  ");
            Console.WriteLine(result + "  ");
        }
    } 
 }

