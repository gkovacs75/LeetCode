using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestCommonPrefix_
    {
        public void Run()
        {
            string[] strs1 = ["flower", "flow", "flight"];
            string[] strs2 = ["dog", "racecar", "car"];
            string[] strs3 = [""];
            string[] strs4 = ["a"];
            string[] strs5 = ["", ""];
            string[] strs6 = ["ab", "a"];
            string[] strs7 = ["a", "b"];

            var result1 = LongestCommonPrefix(strs1);
            var result2 = LongestCommonPrefix(strs2);
            var result3 = LongestCommonPrefix(strs3);
            var result4 = LongestCommonPrefix(strs4);
            var result5 = LongestCommonPrefix(strs5);
            var result6 = LongestCommonPrefix(strs6);
            var result7 = LongestCommonPrefix(strs7);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);


            
        }

        string LongestCommonPrefix(string[] strs)
        {
            //if (strs[0].Length == 1)
            //{
            //    return strs[0];
            //}

            if (strs[0] == "")
            {
                return strs[0];
            }


            string charsInCommon = "";

            char _char = (strs[0])[0];

            int charIndex = 0;

            bool sameAsPrevChar = true;

            // Loop Characters
            while (sameAsPrevChar)
            {
                // Loop Words
                for (int w = 0; w < strs.Length; w++)
                {
                    if (charIndex < strs[w].Length)
                    {
                        _char = (strs[w])[charIndex];

                        sameAsPrevChar = true;

                        if (w - 1 >= 0)
                        {
                            char _sameCharInPrevWord = (strs[w - 1])[charIndex];

                            if (_char != _sameCharInPrevWord)
                            {
                                sameAsPrevChar = false;
                                return charsInCommon;
                            }
                        }

                        //Console.WriteLine(_char);
                    }
                    else
                    {
                        return charsInCommon;
                    }
                }

                charsInCommon += _char;

                charIndex++;
            }

            return "";
        }
    }
}
