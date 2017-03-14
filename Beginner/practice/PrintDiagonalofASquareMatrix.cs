using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.practice
{
    class PrintDiagonalofASquareMatrix
    {
        public static void diagonal(int[][] matrix, int n)
        {
            Console.Write("first diagonal is ");
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(matrix[row][row]);
            }
            Console.WriteLine();

            Console.Write("second diagonal is ");
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(matrix[row][n-1-row]);
            }
        }
        public static void testDiagonal()
        {
            int[][] input = new int[][] { new int[] { 1, 2, 3, 1 }, new int[] { 4, 5, 6, 1 }, new int[] { 7, 8, 9, 1 }, new int[] { 1, 1, 1, 1 } };
            diagonal(input, 4);
        }

    }
}
