using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class SpiralOrderMatrixII
    {
        public static int[][] spiralMatrix(int m, int n)
        {
            int[][] matrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
            }
            int left = 0, right = n - 1, top = 0, bottom = m - 1;
            int dir = 0;
            int number = 1;

            while (top <= bottom && left <= right)
            {
                if (dir == 0)
                {
                    for (int i = top; i <= right; i++)
                    {
                        matrix[top][i] = number;
                        number++;
                    }
                    dir++;
                    top++;
                }
                
                else if (dir == 1)
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        matrix[i][right] = number;
                        number++;
                    }
                    dir++;
                    right--;
                }

                else if (dir == 2)
                {
                    for (int i = right; i >= left; i--)
                    {
                        matrix[bottom][i]= number;
                        number++;
                    }
                    dir++;
                    bottom--;
                }

                else if (dir == 3)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        matrix[i][left] = number;
                        number++;
                    }
                    dir++;
                    left++;
                }
                dir = dir % 4;
            }
            return matrix;
        }
        public static void testSpiralMatrix()
        {
            int m = 3, n = 3;
            int[][] input = new int[m][];
            for (int i = 0; i < m; i++)
                input[i] = new int[n];
           input= spiralMatrix(3, 3);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(input[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
