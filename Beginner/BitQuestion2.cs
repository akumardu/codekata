using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner
{                   //Program to count the number of set(1) bits
    class BitQuestion2
    {
        public static int countBits(int input)
        {
            int count = 0;
            while(input>0)
            {
                input = input & (input - 1);
                count++;
            }
            return count;
        }
        public static void testCountBits()
        {
            Console.WriteLine("enter the integer");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("number of 1 bits are" + " " + countBits(input));
        }
    }
}