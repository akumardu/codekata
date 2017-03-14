using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.practice
{
    class ArrayInSnakeOrder
    {
        public static void snakeOrder(int[][] matrix, int m, int n)
        {
            int row = 0;
            while (row < m )
            {
                if (row % 2 == 0)
                {
                    for (int k = 0; k <= n - 1; k++)
                    {
                        Console.Write(matrix[row][k] + " ");
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int k = n - 1; k >= 0; k--)
                    {
                        Console.Write(matrix[row][k]);
                        Console.WriteLine();
                    }
                }
                row++;
            }
        }

        public static void snakeOrderByColumn(int[][] matrix, int m, int n)
        {
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int i = 0; i < m; i++)
                    {
                        Console.Write(matrix[i][col] + " ");
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = m - 1; i >= 0; i--)
                    {
                        Console.Write(matrix[i][col] + " ");
                        Console.WriteLine();
                    }
                }
            }
            
        }
        public static void testSnakeOrder()
        {
            int[][] input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
           // snakeOrder(input,3,3);
            snakeOrderByColumn(input, 3, 3);
        }
        
    }
}

