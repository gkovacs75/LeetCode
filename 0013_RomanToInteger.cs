using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RomanToInteger
    {
        internal void Run()
        {
            // 13 Roman to Integer
            var r1 = RomanToInt("MCII");            
            Console.WriteLine(r1);
        }

        int RomanToInt(string s)
        {
            var t = new Dictionary<char, int>();
            t.Add('I', 1);
            t.Add('V', 5);
            t.Add('X', 10);
            t.Add('L', 50);
            t.Add('C', 100);
            t.Add('D', 500);
            t.Add('M', 1000);

            int total = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char currNumeral = s[i];
                int currentValue = t[currNumeral];
                int prevVal = 0;

                try
                {
                    prevVal = t[s[i + 1]];
                }
                catch
                {

                }

                if (currentValue >= prevVal)
                {
                    total += currentValue;
                }
                else
                {
                    total -= currentValue;
                }
            }

            return total;
        }
    }
}
