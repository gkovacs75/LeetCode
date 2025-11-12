using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IsSubsequence_
    {
        public void Run()
        {
            var r1 = IsSubsequence("abc", "ahbgdc");
            var r2 = IsSubsequence("axc", "ahbgdc");
            var r3 = IsSubsequence("", "ahbgdc");
            var r4 = IsSubsequence("abc", "");
            var r5 = IsSubsequence("", "");

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            Console.WriteLine(r5);
        }

        public bool IsSubsequence(string s, string t)
        {
            int sPointer = 0, tPointer = 0;


            while (sPointer < s.Length && tPointer < t.Length)
            {
                if (s[sPointer] == t[tPointer])
                {
                    sPointer++;
                }

                tPointer++;
            }

            return sPointer == s.Length;
        }
    }
}
