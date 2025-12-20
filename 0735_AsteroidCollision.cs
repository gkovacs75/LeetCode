using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _0735_AsteroidCollision
    {
        public void Run()
        {
            //var result = AsteroidCollision([5, 10, -5]); // Output: [5, 10]
            //var result = AsteroidCollision([8, -8]); // Output: []
            //var result = AsteroidCollision([10, 2, -5]); // Output: [10]
            var result = AsteroidCollision([3, 5, -6, 2, -1, 4]); // [-6,2,4]

            //var result = AsteroidCollision([5, 10, -15]);



            //Console.WriteLine(x1);
            //Console.WriteLine(x2);
            //Console.WriteLine(x3);
            //Console.WriteLine(x4);

            Console.Write("[");

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]},");
            }

            Console.WriteLine("]");
        }

        public int[] AsteroidCollision(int[] asteroids)
        {
            Stack<int> stack = new Stack<int>();

            foreach (int asteroid in asteroids)
            {
                if (asteroid > 0)
                {
                    stack.Push(asteroid);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0 || stack.Peek() < 0)
                    {
                        stack.Push(asteroid);
                    }
                    else if (stack.Peek() == Math.Abs(asteroid))
                    {
                        stack.Pop();
                    }
                }
            }

            int[] result = new int[stack.Count];
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }

            return result;
        }
    }
}
