using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program to find out all possible unique substrings of a string.
namespace Beginner
{
    class UniqueSubstrings
    {
        public static List<string> Substrings(string input)
        {
            List<string> final = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string str = "";
                for (int j = i; j < input.Length; j++)
                {
                    str = str + input[j];
                    final.Add(str);
                }
            }
            var result = final.Distinct();
            return result.ToList();
        }
        public static void testSubstrings()
        {
            Console.WriteLine("enter the input string ");
            string input = Console.ReadLine();
            Console.WriteLine("Substrings are ");
            var result = Substrings(input);
            for (int i = 0; i < result.Count; i++)
                Console.WriteLine(result[i]);
        }
    }

}
        
       
 
