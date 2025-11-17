using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1657_DetermineIfTwoStringsAreClose
    {
        public void Run()
        {



            var x1 = CloseStrings("abc", "bca"); //true
            var x2 = CloseStrings("a", "aa"); // false
            var x3 = CloseStrings("cabbba", "abbccc"); // true
            var x4 = CloseStrings("abbzzca", "babzzcz"); // false
            var x5 = CloseStrings("uau", "ssx"); // false

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
            Console.WriteLine(x5);
        }

        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }

            var d1 = new Dictionary<char, int>();
            var d2 = new Dictionary<char, int>();

            for (int i = 0; i < word1.Length; i++)
            {
                if (d1.ContainsKey(word1[i]))
                {
                    d1[word1[i]]++;
                }
                else
                {
                    d1.Add(word1[i], 0);
                }

                if (d2.ContainsKey(word2[i]))
                {
                    d2[word2[i]]++;
                }
                else
                {
                    d2.Add(word2[i], 0);
                }
            }

            foreach (var k in d1.Keys)
            {
                if (!d2.ContainsKey(k))
                {
                    return false;
                }
            }

            foreach (var k in d2.Keys)
            {
                if (!d1.ContainsKey(k))
                {
                    return false;
                }
            }



            int[] a1 = d1.Values.ToArray();
            Array.Sort(a1);

            int[] a2 = d2.Values.ToArray();
            Array.Sort(a2);


            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i])
                {
                    return false;
                }
            }

            return true;

        }
    }
}
