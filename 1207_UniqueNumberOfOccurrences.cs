using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1207_UniqueNumberOfOccurrences
    {
        public void Run()
        {
            var x1 = UniqueOccurrences([1, 2, 2, 1, 1, 3]); // true
            var x2 = UniqueOccurrences([1, 2]); // false
            var x3 = UniqueOccurrences([-3, 0, 1, -3, 1, 1, 1, -3, 10, 0]); // true

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
        }

        public bool UniqueOccurrences(int[] arr)
        {
            var d1 = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (d1.ContainsKey(arr[i]))
                {
                    d1[arr[i]]++;
                }
                else
                {
                    d1.Add(arr[i], 0);
                }
            }

            var d2 = new Dictionary<int, int>();
            bool added = false;
            foreach (var item in d1)
            {
                added = d2.TryAdd(item.Value, 0);

                if (!added)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
