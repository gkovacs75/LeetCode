using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseWordsInAString
    {
        public void Run()
        {
            //var x = ReverseWords("the sky is blue");
            //var x = ReverseWords("  hello world  ");
            var x = ReverseWords("a good   example");
            Console.WriteLine(x);            
        }

        public string ReverseWords(string s)
        {
            s = s.Trim();

            s = s.Replace("    ", " ").Replace("   ", " ").Replace("  ", " ");

            var x = s.Split(" ");

            var y = x.Reverse();

            return string.Join(" ", y);
        }
    }
}
