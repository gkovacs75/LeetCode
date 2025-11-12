using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseVowelsOfAString
    {
        public void Run()
        {
            // 'a', 'e', 'i', 'o', and 'u'

            var x = ReverseVowels("IceCreAm"); // "AceCreIm"
            Console.WriteLine(x);
            // "leetcode" -> "leotcede"s
        }

        public string ReverseVowels(string s)
        {
            var s2 = s.ToCharArray();

            var p1 = 0;
            var p2 = s.Length - 1;

            var p1IsVowel = false;
            var p2IsVowel = false;

            while (p1 < p2)
            {
                p1IsVowel = IsVowel(s[p1]);
                p2IsVowel = IsVowel(s[p2]);

                if (p1IsVowel && p2IsVowel)
                {
                    (s2[p1], s2[p2]) = (s[p2], s[p1]);
                    p1++; p2--;
                }
                else if (!p1IsVowel)
                {
                    p1++;
                }
                else if (!p2IsVowel)
                {
                    p2--;
                }
            }

            return new string(s2);
        }

        private bool IsVowel(char c)
        {
            return c == 'a' || c == 'A' || c == 'e' || c == 'E' || c == 'i' || c == 'I' || c == 'o' || c == 'O' || c == 'u' || c == 'U';
        }
    }
}
