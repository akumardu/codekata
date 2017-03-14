using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class CoverageForZeroes
    {
        public static int Coverage(int[][] array, int m, int n)
        {
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i][j] == 0)
                    {
                        if (i < (m-1) && (array[i + 1][j]) == 1)
                            sum++;
                        if (j < (n-1) && (array[i][j + 1]) == 1)
                            sum++;
                        if (i > 0 && (array[i - 1][j]) == 1)
                            sum++;
                        if (j > 0 && (array[i][j - 1]) == 1)
                            sum++;
                    }      
                }
            }
            return sum;
        }
        public static void testCoverage()
        {
            Console.WriteLine("enter rows");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("columns");
            int n = int.Parse(Console.ReadLine());
            int[][] array = new int[m][];
            for (int i = 0; i < m; i++)
            {
                array[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                } 
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(array[i][j]);

                }
            }
            int sum =Coverage(array, m, n);
            Console.WriteLine("sum is " + sum);
        }
    }
}
