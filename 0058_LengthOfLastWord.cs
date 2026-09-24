using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0058_LengthOfLastWord
    {
        public void Run()
        {
            string s1 = "Hello World"; // 5
            string s2 = "   fly me   to   the moon  "; // 4
            string s3 = "a"; // 1
            string s4 = "a "; // 1
            string s5 = " a"; // 1
            string s6 = "Today is a nice day"; // 3


            var r1 = LengthOfLastWord(s1);
            var r2 = LengthOfLastWord(s2);
            var r3 = LengthOfLastWord(s3);
            var r4 = LengthOfLastWord(s4);
            var r5 = LengthOfLastWord(s5);
            var r6 = LengthOfLastWord(s6);

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            Console.WriteLine(r5);
            Console.WriteLine(r6);
        }

        public int LengthOfLastWord(string s)
        {
            int longestWord = 0;
            int lastIndex = s.Length - 1;

            int i = lastIndex;

            for (int j = lastIndex; j >= 0; j--)
            {
                while (s[i] == ' ' && i > j)
                {
                    i--;
                }

                if (s[j] != ' ')
                {
                    longestWord = int.Max(i - j + 1, longestWord);
                }
                else
                {
                    if (longestWord > 0)
                    {
                        return longestWord;
                    }
                    else
                    {
                        i = j;
                    }
                }
            }

            return longestWord;
        }
    }
}
