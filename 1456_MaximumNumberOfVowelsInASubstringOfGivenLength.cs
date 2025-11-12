using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1456_MaximumNumberOfVowelsInASubstringOfGivenLength
    {
        public void Run()
        {
            // 'a', 'e', 'i', 'o', and 'u'.
            var x1 = MaxVowels("abciiidef", 3); // 3
            var x2 = MaxVowels("aeiou", 2); // 2
            var x3 = MaxVowels("leetcode", 3); // 2

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
        }

        public int MaxVowels(string s, int k)
        {
            int p1 = 0;
            int p2 = k - 1;

            int maxFound = int.MinValue;
            int subsetFound = 0;

            for (int i = 0; i < k; i++)
            {
                if (IsVowel(s[i]))
                {
                    subsetFound++;
                }
            }

            maxFound = subsetFound;

            

            p1++;
            p2++;

            while (p2 < s.Length)
            {
                if (IsVowel(s[p1 - 1]))
                {
                    subsetFound--;
                }

                if (IsVowel(s[p2]))
                {
                    subsetFound++;
                }

                if (subsetFound > maxFound)
                {
                    maxFound = subsetFound;
                }

                p1++;
                p2++;
            }

            return maxFound;
        }

        private bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
