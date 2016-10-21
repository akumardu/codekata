using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Codewar
{
    class OrderOfBraces
    {
        public static void testCheck()
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            Console.WriteLine(OrderOfBraces.Check(str));
        }
        public static bool Check(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {            
                switch (input[i])
                {
                    case '{':
                        stack.Push('{');             
                        break;

                    case '(':
                        stack.Push('(');                        
                        break;

                    case '[':
                        stack.Push('(');                       
                        break;

                    case '}':
                        if (stack.Count > 0 && stack.Peek() == '{')
                        {
                            stack.Pop();                            
                        }
                        else
                            return false;                
                        break;

                    case ')':
                        if (stack.Count > 0 && stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                            return false;
                        break;

                    case ']':
                        if (stack.Count > 0 && stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                            return false;
                        break;

                    default:
                        break;
                }
            }

            if (stack.Count != 0)
                return false;
            return true;
        }
    }
}

    






    
