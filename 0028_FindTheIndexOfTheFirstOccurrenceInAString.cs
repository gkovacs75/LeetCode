using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0028_FindTheIndexOfTheFirstOccurrenceInAString
    {
        public void Run()
        {
            Console.WriteLine(StrStr("sadbutsad", "sad"));// 0
            Console.WriteLine(StrStr("leetcode", "leeto")); //  -1
            Console.WriteLine(StrStr("sapbutsad", "sad"));// 6
            Console.WriteLine(StrStr("sapbutsad", "sads"));// -1
            Console.WriteLine(StrStr("mississippi", "issip"));//  4
            Console.WriteLine(StrStr("mississippi", "pi"));// 9
        }

        public int StrStr(string haystack, string needle)
        {
            int n = 0;

            for (int h = 0; h < haystack.Length; h++)
            {
                if (haystack[h] == needle[n])
                {
                    if (n == needle.Length - 1)
                    {
                        return h - n;
                    }

                    n++;
                }
                else
                {
                    h = h - n;
                    n = 0;                    
                }

            }

            return -1;
        }
    }
}
