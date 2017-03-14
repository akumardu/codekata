using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
   // http://www.geeksforgeeks.org/inplace-rotate-square-matrix-by-90-degrees/
    class RotateMatrixBy90Degree
    {
        public static void inplaceRotateMatrix(int [][]matrix, int n)
        {
            
            for (int x = 0; x < n/2; x++)
            {
                for (int y = x; y < n- x - 1; y++)
                {
                    int temp = matrix[x][y];
                    matrix[x][y] = matrix[y][n - x - 1];
                    matrix[y][n - x - 1] = matrix[n - x - 1][n - y - 1];
                    matrix[n - x - 1][n - y - 1] = matrix[n - 1 - y][x];
                    matrix[n- 1 - y][x] = temp;
                }
            }
        }
        public static void testInplaceRotateMatrix()
        {
            Console.WriteLine("enter the rows or columns of a matrix ");
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = int.Parse(Console.ReadLine());
                }
            }
            inplaceRotateMatrix(matrix, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   Console.WriteLine(matrix[i][j]);
                }
            }
        }

    }
}
