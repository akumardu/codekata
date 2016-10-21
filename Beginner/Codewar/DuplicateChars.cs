using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Codewar
{
    class DuplicateChars
    {
        public static int CountDuplicate(string str)
        {
            int count = 0;

            int[] charArray = new int[256];
            for (int j = 0; j < 256; j++)
            {
                charArray[j] = 0;
            }

            for (int i = 0; i < str.Length; i++)
            {
                char currentCharacter = char.ToUpper(str[i]);
                charArray[(int)(currentCharacter)] = (charArray[(int)(currentCharacter)]) +1 ;
            }
            for (int k = 0; k < 256; k++)
            {
                if (charArray[k] >1)
                {
                    count++;
                }
            }
            return count;
        }
        public static void TestCountDuplicate()
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            Console.WriteLine(DuplicateChars.CountDuplicate(str));
        }
    }
}
