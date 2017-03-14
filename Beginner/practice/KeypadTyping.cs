using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class KeypadTyping
    {
        public static char[] typing(String str)
        {
            int n = str.Length;
            char[] hash = { '2', '2', '2', '3', '3', '3', '4', '4', '4', '5', '5', '5',
                '6', '6', '6', '7', '7', '7', '7', '8', '8', '8', '9', '9', '9', '9' };
            char[] result= new char[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = hash[str[i] - 'a'];
            }
   
            return result;
        }
        public static void testTyping()
        {
            String str = "amazon";
            char []result = typing(str);
            result.ToString();
            for(int i=0; i<result.Length; i++)
            Console.Write(result[i]);
        }
    }
}
