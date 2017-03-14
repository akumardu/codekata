using Beginner.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Interviewbit_Arrays
{
    class PascalTriangle
    {
        public static int [] printPascal(int rows)
        {
            int[][] array = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                array[i] = new int[rows]; 
            }
            for (int line = 0; line < rows; line++)
            {
                for (int i = 0; i <= line; i++)
                {
                    if (line == i || i == 0)
                    {
                        array[line][i] = 1;
                    }
                    else
                    {
                        array[line][i] = array[line - 1][i - 1] + array[line - 1][i];
                    }
                    Console.Write(array[line][i] + " ");
                }
                Console.WriteLine();
            }
            return array[rows - 1];
        }
        public static void testPrintPascal()
        {
            int [] result= printPascal(5);
            result.WriteArrayToConsole();
        }
    }
}
