using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0167_TwoSum2InputArrayIsSorted
    {
        public void Run()
        {
            //int[] numbers = [2, 7, 11, 15, 20, 400]; // [1,2]  
            //int target = 9;

            //int[] numbers = [2, 3, 4]; // [1,3]  
            //int target = 6;

            int[] numbers = [-1, 0]; // [1,2]
            int target = -1;

            var o = TwoSum(numbers, target);

            Console.WriteLine($"v1:{o[0]}, v2: {o[1]}");
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            int p1 = 0;
            int p2 = numbers.Length - 1;

            while (p1 < p2)
            {
                int sum = numbers[p1] + numbers[p2];

                if (sum == target)
                {
                    break;
                }
                else if (sum > target)
                {
                    p2--;
                }
                else
                {
                    p1++;
                }
            }

            return [p1 + 1, p2 + 1];
        }

    }
}
