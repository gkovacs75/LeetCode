using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FizzBuzz_
    {
        public void Run()
        {
            var r1 = FizzBuzz(3);

            foreach (var x in r1)
            {
                Console.WriteLine(x);
            }
        }

        public IList<string> FizzBuzz(int n)
        {
            IList<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        list.Add("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        list.Add("Buzz");
                    }
                    else
                    {
                        list.Add(i.ToString());
                    }
                }

            }

            return list;
        }
    }
}
