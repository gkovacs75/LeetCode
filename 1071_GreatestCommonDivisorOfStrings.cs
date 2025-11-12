using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class GreatestCommonDivisorOfStrings
    {
        public void Run()
        {
            var x1 = GcdOfStrings("ABCABC", "ABC");
            var x2 = GcdOfStrings("XBCABC", "ABC");
            var x3 = GcdOfStrings2("ABABAB", "ABAB");
            var x4 = GcdOfStrings2("LEET", "CODE");
            var x5 = GcdOfStrings2("A", "ABCABC");

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
        }

        public string GcdOfStrings2(string str1, string str2)
        {
            // a > b
            // the common divisors of a and b are the same as the common divisors of a – b and b.

            var l1 = str1.Length;
            var l2 = str2.Length;

            if (l1 == 0 || l2 == 0 || str1 + str2 != str2 + str1)
                return "";

            while (l1 != 0)
            {
                (l1, l2) = (l2 % l1, l1);
            }

            return str1.Substring(0, l2);
        }

        public string GcdOfStrings(string str1, string str2)
        {
            var l1 = str1.Length;
            var l2 = str2.Length;

            if (l1 == 0 || l2 == 0 || str1 + str2 != str2 + str1)
            {
                return "";
            }

            while (l1 != 0)
                (l1, l2) = ((l2 % l1), l1);

            return str1.Substring(0, l2);
        }
    }
}
