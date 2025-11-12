using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class StringCompression
    {
        public void Run()
        {
            var x1 = Compress(['a', 'a', 'b', 'b', 'c', 'c', 'c']); // ['a','2','b','2','c','3'] -> 6
            var x2 = Compress(['a']); // ['a'] -> 1
            var x3 = Compress(['a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b']); // ['a','b','1','2'] -> 4
            var x4 = Compress(['a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a']);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }

        public int Compress(char[] chars)
        {
            var prevChar = ' ';
            var currChar = ' ';
            var charCount = 1;
            var writePointer = 0;

            if (chars.Length == 1)
            {
                return 1;            
            }

            for (int i = 0; i <= chars.Length; i++)
            {
                if (i < chars.Length)
                {
                    currChar = chars[i];
                }
                else
                {
                    currChar = ' ';
                }

                if (currChar == prevChar)
                {
                    charCount++;
                }
                else
                {
                    if (prevChar != ' ')
                    {
                        chars[writePointer] = prevChar;
                        writePointer++;

                        if (charCount == 1)
                        {
                            
                        }
                        else if (charCount > 1 && charCount < 10)
                        {
                            chars[writePointer] = (charCount.ToString())[0];
                            writePointer++;
                        }
                        else if (charCount >= 10 && charCount < 100)
                        {
                            chars[writePointer] = (charCount.ToString())[0];
                            writePointer++;
                            chars[writePointer] = (charCount.ToString())[1];
                            writePointer++;                            
                        }
                        else if (charCount >= 100 && charCount < 1000)
                        {
                            chars[writePointer] = (charCount.ToString())[0];
                            writePointer++;
                            chars[writePointer] = (charCount.ToString())[1];
                            writePointer++;
                            chars[writePointer] = (charCount.ToString())[2];
                            writePointer++;
                        }
                        else if (charCount >= 1000 && charCount < 10000)
                        {
                            chars[writePointer] = (charCount.ToString())[0];
                            writePointer++;
                            chars[writePointer] = (charCount.ToString())[1];
                            writePointer++;
                            chars[writePointer] = (charCount.ToString())[2];
                            writePointer++;
                            chars[writePointer] = (charCount.ToString())[3];
                            writePointer++;
                        }

                        charCount = 1;
                    }
                }

                if (i < chars.Length)
                {
                    prevChar = chars[i];
                }                
            }

            return writePointer;
        }
    }
}
