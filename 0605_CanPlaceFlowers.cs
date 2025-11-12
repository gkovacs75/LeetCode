using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CanPlaceFlowers_
    {
        public void Run()
        {
            //var x = CanPlaceFlowers([1, 0, 0, 0, 1], 1);
            //var x = CanPlaceFlowers([1, 0, 0, 0, 1], 2);
            var x = CanPlaceFlowers([0, 0, 1, 0, 0], 1);

            Console.WriteLine(x);
        }

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int prev = -1;
            int next = 1;

            for (int curr = 0; curr < flowerbed.Length; curr++)
            {
                if ((prev == -1 || flowerbed[prev] == 0) && flowerbed[curr] == 0 && (next == flowerbed.Length || flowerbed[next] == 0))
                {
                    flowerbed[curr] = 1;
                    n--;

                }

                prev++;
                next++;
            }

            return n <= 0;
        }
    }
}
