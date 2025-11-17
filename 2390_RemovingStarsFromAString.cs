using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2390_RemovingStarsFromAString
    {
        public void Run()
        {
            var x1 = RemoveStars("leet**cod*e"); // "lecoe"
            var x2 = RemoveStars("erase*****"); // ""


            Console.WriteLine(x1);
            Console.WriteLine(x2);
            //Console.WriteLine(x3);
        }

        public string RemoveStars(string s)
        {
            var stc = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '*')
                {
                    stc.Pop();
                }
                else
                {
                    stc.Push(c);
                }
            }

            return new String(stc.ToArray().Reverse().ToArray());
        }
    }
}
