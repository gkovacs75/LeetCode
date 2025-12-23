using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0933_NumberOfRecentCalls
    {
        public void Run()
        {
            RecentCounter obj = new RecentCounter();

            int param_1 = obj.Ping(1);
            int param_2 = obj.Ping(100);
            int param_3 = obj.Ping(3001);
            int param_4 = obj.Ping(3002);

            Console.WriteLine(param_1);
            Console.WriteLine(param_2);
            Console.WriteLine(param_3);
            Console.WriteLine(param_4);
        }
    }

    internal class RecentCounter
    {
        Queue<int> q;

        public RecentCounter()
        {
            q = new Queue<int>();
        }

        public int Ping(int t)
        {
            int counter = 0;

            q.Enqueue(t);

            int r1 = t - 3000;
            int r2 = t;

            foreach (int i in q)
            {
                if (i >= r1 && i <= r2)
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
