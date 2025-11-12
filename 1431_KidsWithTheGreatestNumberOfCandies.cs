using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class KidsWithTheGreatestNumberOfCandies
    {
        public void Run()
        {
            var x1 = KidsWithCandies([2, 3, 5, 1, 3], 3); // [true,true,true,false,true] 
            var x2 = KidsWithCandies([4, 2, 1, 1, 2], 1); // [true,false,false,false,false]
            var x3 = KidsWithCandies([12, 1, 12], 10); // [true,false,true]

            x1.ToList().ForEach(i => Console.Write(i.ToString() + ", ") );
            Console.WriteLine();
            x2.ToList().ForEach(i => Console.Write(i.ToString() + ", "));
            Console.WriteLine();
            x3.ToList().ForEach(i => Console.Write(i.ToString() + ", "));
            Console.WriteLine();

            //Console.WriteLine(x1.ToString());
            //Console.WriteLine(x2);
            //Console.WriteLine(x3);
            //Console.WriteLine(x4);
            //Console.WriteLine(x5);
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] result = new bool[candies.Length];

            var kidWithMostCandy = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= kidWithMostCandy)
                {
                    result[i] = true;
                }
            }

            return result;
        }
    }
}
