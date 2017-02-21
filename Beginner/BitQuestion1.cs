using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{    //How to read and set a single bit.
    class BitQuestion1
    {
        public static bool GetBit(int input, int pos)
        {
           Console.WriteLine( Convert.ToString(input, 2));
            return (input & (1 << pos)) != 0;
        }
        public static int SetBit(int input, int pos, bool value)
        {
            Convert.ToString(input, 2);
            int result = input;
            if (value = true && GetBit(input, pos) == false)
            {
                result = (input | (1 << pos));
            }
            else if (value = false && GetBit(input, pos) == true)
            {
                result = (input & ~(1 << pos));
            }

            Console.WriteLine(Convert.ToString(result));
            return result;
        }
        public static void testBit()
        {
            Console.WriteLine("enter the integer input");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the position");
            int pos = int.Parse(Console.ReadLine());
            Console.WriteLine(GetBit(input, pos));

            Console.WriteLine("enter the value");
            bool value = bool.Parse(Console.ReadLine());
            SetBit(input, pos, value);
        }
    }
}
