using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class EquilibriumInAnArray
    {
        public static int equilibrium(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum = leftSum + array[j];
                }
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum = rightSum + array[k];
                }
                if (leftSum == rightSum)
                    return i + 1;
            }
            return -1;
        }
        public static void testEquilibrium()
        {
            int[] input = { 1, 3, 5, 2, 2 };
            int equi = equilibrium(input);
            Console.WriteLine($"the equilibrium is {equi} ");
        }
    }
}
