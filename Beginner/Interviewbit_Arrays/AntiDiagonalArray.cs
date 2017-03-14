

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class AntiDiagonalArray
    {
        public static List<List<int>> antiDiagonal(int[][] array,int n)
        {
            List<List<int>> result = new List<List<int>>();

            
            for (int d = 0; d <= 2 * (n - 1); d++)
            {
                List<int> temp = new List<int>();

                for (int i = 0; i <= d; i++)
                {
                    if (i<n && (d - i) <n)
                    
                        temp.Add(array[i][d - i]);
                }
                result.Add(temp);
            }
            return result;
        }
        public static void testAntiDiagonal()
        {
            int[][] input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };

            List<List<int>> result = antiDiagonal(input, 3);
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j++)
                {
                    Console.Write(result[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
