using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class ProfessorParty
    {
        public static void party(int[] array)
        {
            Array.Sort(array);
            for (int i = 0, j = 1; i < array.Length && j < array.Length; i++, j++)
            {
                if (array[i] == array[j])
                {
                    Console.WriteLine("Its a boys party");
                    return; 
                }
            }

            Console.WriteLine("Its a girls party");
            
        }
        public static void testParty()
        {
            int[] input = { 1, 3, 2, 4, 5,6};
            party(input);
        }
    }
}
