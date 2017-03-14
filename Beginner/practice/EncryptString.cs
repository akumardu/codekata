using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{
    class EncryptString
    {
        public static void encrypt(string str)
        {
            int n = str.Length;
            for (int i = 0; i < n;)
            {
                int count = 1;

                int j=i+1;  
                while (j<n && str[i] == str[j])
                        j++;
                
                count = j - i;
                Console.Write(str[i]);
                Console.Write(count);
                i=j;
                
            }
        }
        public static void testEncrypt()
        {
            string input = "aabc";
            encrypt(input);
            
        }
    }
}


