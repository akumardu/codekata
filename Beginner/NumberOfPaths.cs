using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class NumberOfPaths
    {
        public static int Paths(int m, int n)
        {
            int[][] result = new int[m][];
            for (int k = 0; k < m; k++)
            {
                result[k]= new int[n];
            }

            result[0][0] = 1;

            // if there is only one element in the matrix.


            for (int k = 0; k < m; k++) // path to access 1st column
            {
                result[k][0] = 1;
            }
            for (int k = 0; k < n; k++) // path to access 1st row
            {
                result[0][k] = 1;
            }
            for (int i = 1; i < m ; i++) // since 1st row and 1st column are already been accessed. loop starts from 1.
            {
                for (int j = 1; j < n ; j++)
                {
                    result[i][j] = result[i-1][j] + result[i][j-1];
                }
            }
            return result[m - 1][n - 1];
        }
        public static void testPaths()
        {
          //  int[][] input = new int[][] { new int[] {1,2,3 }, new int[] {4,5,6 } }; // here we dont need the matrix. we just need m and n
            int count = Paths(3, 4);
            Console.WriteLine(count);
        }
    }
}
