using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0394_DecodeString
    {
        public void Run()
        {
            //var x1 = DecodeString("3[a]2[bc]"); // "aaabcbc"
            //var x2 = DecodeString("3[a2[c]]"); // "accaccacc"
            //var x3 = DecodeString("2[abc]3[cd]ef"); // "abcabccdcdcdef"
            var x4 = DecodeString("100[leetcode]"); // "abcabccdcdcdef"

            //Console.WriteLine(x1 + " = aaabcbc");
            //Console.WriteLine(x2 + " = accaccacc");
            //Console.WriteLine(x3 + " = abcabccdcdcdef");
            Console.WriteLine(x4);
            //Console.WriteLine(x5);
        }

        public string DecodeString(string s)
        {
            var stack = new Stack<char>();
            int i = 0;

            while (i < s.Length)
            {
                var c = s[i];

                if (c == ']')
                {
                    string poppedChars = "";

                    while (stack.Peek() != '[')
                    {
                        poppedChars += stack.Pop();
                    }

                    poppedChars = new string(poppedChars.Reverse().ToArray());

                    stack.Pop(); // '['

                    string multBuilder = "";
                    while (stack.Count > 0 && char.IsDigit(stack.Peek()))
                    {
                        multBuilder += stack.Pop();
                    }


                    int multiplier = int.Parse(new string(multBuilder.Reverse().ToArray()));

                    var poppedCharsMultipled = String.Concat(Enumerable.Repeat(poppedChars, multiplier));

                    foreach (char cx in poppedCharsMultipled)
                    {
                        stack.Push(cx);
                    }

                }
                else
                {
                    stack.Push(c);
                }

                i++;

            }

            return new string(stack.Reverse().ToArray());
        }
    }
}

