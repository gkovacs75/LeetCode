using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MoveZeroes_
    {
        public void Run()
        {
            MoveZeroes([0, 1, 0, 3, 12]);

            //foreach (var x in r1)
            //{
            //    Console.WriteLine(x);
            //}
        }

        public void MoveZeroes(int[] nums)
        {
            int writePointer = 0;

            for (int readPointer = 0; readPointer < nums.Length; readPointer++)
            {
                if (nums[readPointer] != 0) 
                {
                    (nums[readPointer], nums[writePointer]) = (nums[writePointer], nums[readPointer]);
                    writePointer++;
                }
            }
        }
    }
}
