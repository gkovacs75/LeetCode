using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0009_PalindromeNumber
    {
        public void Run()
        {
            var x = IsPalindrome(565);
        }

        public bool IsPalindrome(int x)
        {
            string str = x.ToString();

            if (str.Length == 1 || str == "")
            {
                return true;
            }

            string leftChar = str.Substring(0, 1);
            string rightChar = str.Substring(str.Length - 1, 1);

            if (leftChar == rightChar)
            {
                return IsPalindrome(int.Parse(str.Substring(1, str.Length - 2)));
            }

            return false;
        }
    }
}
