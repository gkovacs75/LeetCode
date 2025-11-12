using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ValidParentheses
    {
        public void Run()
        {
            var r1 = IsValid("([{}()()]{})");
            var r2 = IsValid("()[]{}");
            var r3 = IsValid("(]");
            var r4 = IsValid("([])");
            var r5 = IsValid("([)]");
            var r6 = IsValid("[");
            var r7 = IsValid("]");


            Console.WriteLine("() " + r1);
            Console.WriteLine("()[]{} " + r2);
            Console.WriteLine("(] " + r3);
            Console.WriteLine("([]) " + r4);
            Console.WriteLine("([)] " + r5);
            Console.WriteLine("[ " + r6);
            Console.WriteLine("] " + r7);
        }

        public bool IsValid(string s)
        {
            var endings = new Stack<char>();

            foreach (var c in s)
            {
                switch (c)
                {
                    case '(':
                        endings.Push(')');
                        break;
                    case '[':
                        endings.Push(']');
                        break;
                    case '{':
                        endings.Push('}');
                        break;
                    case ')':
                    case ']':
                    case '}':
                        if (endings.Count == 0 || endings.Pop() != c)
                            return false;
                        break;

                }
            }

            return endings.Count == 0;
        }
    }
}
