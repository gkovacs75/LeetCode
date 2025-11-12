using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeStringsAlternately
    {
        public void Run()
        {
            //var x = MergeAlternately("abc", "pqr");
            //var x = MergeAlternately("ab", "pqrs");
            //var x = MergeAlternately("abcd", "pq");
            var x = MergeAlternately("a", "pq");

            Console.WriteLine(x);
        }

        public string MergeAlternately(string word1, string word2)
        {
            int c = Math.Max(word1.Length, word2.Length);
            string o = "";


            int word1Pointer = 0;
            int word2Pointer = 0;


            for (int i = 0; i < c; i++)
            {
                if (word1Pointer < word1.Length)
                {
                    o += word1[word1Pointer++];
                }

                if (word2Pointer < word2.Length)
                {
                    o += word2[word2Pointer++];
                }                
            }

            return o;
        }
    }
}
