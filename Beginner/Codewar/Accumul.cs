using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Codewar
{
    using System;

    public class Accumul
    {
        public static String Accum(string s)
        {
            // Initialize result to empty string
            string result = "";

            // Pick characters from the string s one by one
            for (int i = 0; i < s.Length; i++)
            {
                // Save the current character that we are working on as currentChar
                char currentChar = s[i];
                // The first occurrence must be upper char. Save it in result.
                result = result + Char.ToUpper(currentChar);
                // We need to repeat the character as many times as it's position
                for (int j = 0; j < i; j++)
                {
                    // 2+ occurences need to be lower case
                    result = result + Char.ToLower(currentChar);
                }

                // Add the separator between processing different i
                result = result + "-";
            }
            // Remove the last dash
            return result.Substring(0, result.Length - 1);
        }
    }
}
