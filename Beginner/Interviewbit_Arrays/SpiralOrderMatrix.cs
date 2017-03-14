using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class SpiralOrderMatrix
    {
        public static void spiralOrder(int[][] matrix, int m, int n)
        {
            int dir = 0;
            int top = 0, bottom = m - 1, left = 0, right = n - 1;
            while (top <= bottom && left <= right)
            {
                if (dir == 0)
                {
                    for (int i = left; i <= right; i++)
                    {
                        Console.Write(matrix[top][i]);
                        Console.Write(" ");
                    }
                    top++;
                    dir++;
                }
                else if (dir == 1)
                {
                    for (int i = top; i <= bottom; i++)
                    {
                        Console.Write(matrix[i][right]);
                        Console.Write(" ");
                    }
                    right--;
                    dir++;
                }
                else if (dir == 2)
                {
                    for (int i = right; i >= left; i--)
                    {
                        Console.Write(matrix[bottom][i]);
                        Console.Write(" ");
                    }
                    bottom--;
                    dir++;
                }
                else if (dir == 3)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        Console.Write(matrix[i][left]);
                        Console.Write(" ");
                    }
                    left++;
                    dir++;
                }
                dir = (dir) % 4;
            }
        }
        public static void testSpiralOrder()
        {
            int[][] matrix = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            spiralOrder(matrix, 3, 3);
        }
    }
}
