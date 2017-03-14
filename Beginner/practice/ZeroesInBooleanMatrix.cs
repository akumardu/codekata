using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://www.practice.geeksforgeeks.org/problem-page.php?pid=700272
namespace Beginner
{
    class ZeroesInBooleanMatrix
    {
        //Complexity is O(mn)
        public static int countZeroes(int[,] matrix, int m, int n)
        {
            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matrix[i,j] == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        //Complexity is O(m+n)
        public static int countZeroesModified(int[][] matrix, int m, int n)
        {
            int count = 0;
            int end = n - 1;
            for (int i = 0; i < m; i++)
            {
                while (end >= 0)
                {
                    if (matrix[i][end] == 1)
                        end--;
                    else
                        break;
                }
                if (end>=0)
                    count = count + (end + 1);
            }
            return count;
        }
        public static void testCountZeroes()
        {
            int[,] matrix = new int[ , ]{ { 0, 0, 0 }, { 1, 1, 1 }, { 1, 1, 1 } };
            int[][] matrix2 = new int[][] { new int[]{ 0, 0, 0 }, new int[]{ 1, 1, 1 }, new int[]{ 1, 1, 1 } };
            int count = countZeroes( matrix, 3, 3);
            Console.WriteLine(count);
            int count2 = countZeroesModified(matrix2, 3, 3);
            Console.WriteLine(count2);

        }
    }
}
