using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2352_EqualRowAndColumnPairs
    {
        public void Run()
        {
            var x1 = EqualPairs([[3, 2, 1], [1, 7, 6], [2, 7, 7]]); // 1
            var x2 = EqualPairs([[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]]); // 3


            Console.WriteLine(x1);
            Console.WriteLine(x2);
            //Console.WriteLine(x3);
        }

        public int EqualPairs(int[][] grid)
        {
            int subCount = 0;
            int count = 0;

            int length = grid.Length;

            for (int incA = 0; incA < length; incA++)
            {
                for (int incB = 0; incB < length; incB++)
                {
                    subCount = 0;

                    for (int incC = 0; incC < grid.Length; incC++)
                    {
                        if (grid[incA][incC] != grid[incC][incB])
                        {
                            break;
                        }
                        subCount++;
                    }

                    if (subCount == length)
                    {
                        count++;                        
                    }
                }
            }

            return count;
        }
    }
}
