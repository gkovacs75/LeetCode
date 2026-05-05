using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0125_ValidPalindrome
    {
        public void Run()
        {
            string s1 = "A man, a plan, a canal: Panama"; // true
            string s2 = "race a car"; // false
            string s3 = " "; // true

            var o1 = IsPalindrome(s1);
            var o2 = IsPalindrome(s2);
            var o3 = IsPalindrome(s3);

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
        }

        public bool IsPalindrome(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return true;
            }

            string s2 = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            int start = 0;
            int end = s2.Length-1;

            while (start < end)
            {
                if (s2[start] != s2[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}
